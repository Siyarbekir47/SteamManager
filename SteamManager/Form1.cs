using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.DirectoryServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Security.Policy;
using System.Net;

/* TODO:
dotnet publish -r win-x64 -p:PublishSingleFile=true --self-contained false

-add search function for games, (all users)

-add some visuals on the left, like a profile picture, name, etc.
*/
namespace SteamManager
{


    public partial class MainForm : Form
    {


        private string appLocalFolder;
        private string myAppFolder;
        private string fullPath;
        private string myResourcesFolder;
        private string apiKey = "EDF2C147BDAEAD8453FB0FAA92E657E8";
        private Dictionary<string, List<string>> userGames = new Dictionary<string, List<string>>();


        public struct user
        {
            public user(string user, string pass, bool isPasswordEncrypted, string steamid)
            {
                username = user;
                password = pass;
                steamID64 = steamid;
                this.isPasswordEncrypted = isPasswordEncrypted;
            }

            public string username { get; set; }
            public string password { get; set; }
            public string steamID64 { get; set; }

            public bool isPasswordEncrypted { get; set; }

        }

        List<user> userlist = new List<user>();

        public class GameInfo
        {
            [JsonProperty("Name")]
            public string Name { get; set; }

            [JsonProperty("AppID")]
            public string AppID { get; set; }

            [JsonProperty("playtime_forever")]
            public string Playtime { get; set; }

            [JsonProperty("img_icon_url")]
            public string IconURL { get; set; }

        }
        public class AccountInfo
        {
            [JsonProperty("Nickname")]
            public string Nickname { get; set; }

            [JsonProperty("ProfileLink")]
            public string ProfileLink { get; set; }

            [JsonProperty("ProfileIcon")]
            public string ProfileIcon { get; set; }

            [JsonProperty("SteamID64")]
            public string SteamID64 { get; set; }
        }

        public void AddNewUser(string user, string pass)
        {
            var newUser = new user(user, pass, false, null);
            userlist.Add(newUser);

            SaveUsers(); // This will update the storage with the new user list.

            comboBox1.Items.Clear();
            foreach (user u in userlist)
            {
                comboBox1.Items.Add(u.username);
            }

            MessageBox.Show("Benutzer erfolgreich hinzugefügt.");

        }

        private void LoadUserGames()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string selectedUser = comboBox1.SelectedItem.ToString();
                for (int i = 0; i < userlist.Count; i++)
                {
                    if (userlist[i].username == selectedUser)
                    {
                        selectedUser = userlist[i].steamID64;
                        break;
                    }
                }
                string gamesFilePath = Path.Combine(myAppFolder, selectedUser + "Gi.json");

                if (File.Exists(gamesFilePath))
                {
                    try
                    {
                        // Deserialize the JSON data as a List<string>
                        string json = File.ReadAllText(gamesFilePath);
                        List<GameInfo> loadedGames = JsonConvert.DeserializeObject<List<GameInfo>>(json);

                        if (loadedGames != null)
                        {
                            // Clear the existing list and add the loaded games to lstGames
                            lstvGames.Items.Clear();
                            imgIcons.Images.Clear();
                            foreach (var game in loadedGames)
                            {

                                string iconPath = Path.Combine(myResourcesFolder, game.AppID + ".jpg");

                                // Check if the icon file exists, if not use the default icon
                                if (!File.Exists(iconPath))
                                {
                                    iconPath = Path.Combine(myResourcesFolder, "0.jpg"); // Path to your default icon
                                }

                                // Load the image from the iconPath
                                Image img = Image.FromFile(iconPath);

                                // Add the image to the ImageList
                                imgIcons.Images.Add(img);

                                // Create a ListViewItem with the game name and assign the image index
                                ListViewItem item = new ListViewItem(game.Name, imgIcons.Images.Count - 1);

                                // Add the item to the ListView
                                lstvGames.Items.Add(item);
                                item.Tag = game.AppID; // Store the AppID in the Tag property

                            }
                        }
                        else
                        {
                            MessageBox.Show("The games file is empty or contains invalid data.", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                    }
                    catch (JsonException jsonEx)
                    {
                        MessageBox.Show("An error occurred while deserializing the games file: " + jsonEx.Message, "JSON Deserialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("An error occurred while loading games: " + ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    //MessageBox.Show("The games file does not exist for the selected user.", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void LoadUsersGames(string steamid64)
        {
            string gamesFilePath = Path.Combine(myAppFolder, steamid64 + "Gi.json");
            if (File.Exists(gamesFilePath))
            {

                try
                {
                    string json = File.ReadAllText(gamesFilePath);
                    List<GameInfo> loadedGames = JsonConvert.DeserializeObject<List<GameInfo>>(json);

                    if (loadedGames != null)
                    {
                        // Clear the existing list and add the loaded games to lstGames
                        lstvGames.Items.Clear();
                        loadedGames.ForEach(loadedGames => lstvGames.Items.Add(loadedGames.Name));
                        LoadUserGames();
                    }
                    else
                    {
                        MessageBox.Show("The games file is empty or contains invalid data.", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                catch (JsonException jsonEx)
                {
                    MessageBox.Show("An error occurred while deserializing the games file: " + jsonEx.Message, "JSON Deserialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading games: " + ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void SaveUsers()
        {
            for (int i = 0; i < userlist.Count; i++)
            {
                if (!userlist[i].isPasswordEncrypted)
                {
                    // Encrypt only if the password isn't already encrypted
                    var encryptedUser = new user(userlist[i].username, CryptoUtility.EncryptString(userlist[i].password), true, null);
                    userlist[i] = encryptedUser; // Replace the old user struct with the new one
                }
            }
            // Now serialize and save the user list
            string json = JsonConvert.SerializeObject(userlist, Formatting.Indented);
            File.WriteAllText(Path.Combine(myAppFolder, "sysus.json"), json);
        }

        public void LoadUsers()
        {
            string usersFilePath = Path.Combine(myAppFolder, "sysus.json");

            if (File.Exists(usersFilePath))
            {
                string json = File.ReadAllText(usersFilePath);

                try
                {
                    var tempList = JsonConvert.DeserializeObject<List<user>>(json);

                    if (tempList != null)
                    {
                        userlist = tempList;
                        comboBox1.Items.Clear();
                        foreach (var userItem in userlist)
                        {
                            comboBox1.Items.Add(userItem.username);
                        }
                    }
                    else
                    {
                        MessageBox.Show("The users file is empty or contains invalid data.", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                catch (JsonException jsonEx)
                {
                    MessageBox.Show("An error occurred while deserializing the users file: " + jsonEx.Message, "JSON Deserialization Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occurred while loading users: " + ex.Message, "General Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
            else
            {
                //MessageBox.Show("The users file does not exist.", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public MainForm()
        {
            InitializeComponent();
            appLocalFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            myAppFolder = Path.Combine(appLocalFolder, "SM");
            myResourcesFolder = Path.Combine(myAppFolder, "Resources");
            fullPath = Path.Combine(myAppFolder, "syspl");
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (!Directory.Exists(myAppFolder))
            {
                Directory.CreateDirectory(myAppFolder);
            }
            if (!Directory.Exists(myResourcesFolder))
            {
                Directory.CreateDirectory(myResourcesFolder);
            }

            LoadUsers();
            LoadUserGames();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Wähle erst einen Bentzer!");
                return;
            }


            foreach (var process in Process.GetProcessesByName("steam"))
            {
                process.Kill();
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.FileName = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamExe", "null");
            startInfo.Arguments = " -login " + userlist[comboBox1.SelectedIndex].username + " " + CryptoUtility.DecryptString(userlist[comboBox1.SelectedIndex].password);
            Process.Start(startInfo);

        }


        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedUser = comboBox1.SelectedItem.ToString();
            lstvGames.Items.Clear();
            LoadUserGames();

            string profileJsonPath = Path.Combine(myAppFolder, userlist[comboBox1.SelectedIndex].steamID64 + "Ai.json");
            if (File.Exists(profileJsonPath))
            {
                string jsonContent = File.ReadAllText(profileJsonPath);
                dynamic profileData = JsonConvert.DeserializeObject<dynamic>(jsonContent)[0];


                string profilePicUrl = profileData.ProfileIcon;
                string profileLink = profileData.ProfileLink;

                using (WebClient wc = new WebClient())
                {
                    byte[] bytes = wc.DownloadData(profilePicUrl);
                    using (MemoryStream ms = new MemoryStream(bytes))
                    {
                        pictureBoxProfile.Image = Image.FromStream(ms);
                    }
                }

                linkLabelProfile.Tag = profileLink;

                linkLabelProfile.Text = profileData.Nickname;


            }

        }


        private void deleteUser_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Wähle erst einen benutzer aus.");
                return;

            }

            string selectedUser = comboBox1.SelectedItem.ToString();

            //confirmation dialog to make sure the user wants to delete this
            var confirmResult = MessageBox.Show("Sicher das du den Benutzer löschen willst?", "Löschen bestätigen!", MessageBoxButtons.YesNo);

            if (confirmResult == DialogResult.Yes)
            {
                //remove user from combobox
                comboBox1.Items.Remove(selectedUser);

                //remove user from userGames dictinoary
                if (userGames.ContainsKey(selectedUser))
                {
                    userGames.Remove(selectedUser);
                }

                //remove user from userlist and update storage
                user userToRemove = userlist.First(u => u.username == selectedUser);
                if (userToRemove.username != null)
                {
                    userlist.Remove(userToRemove);
                    SaveUsers();

                }
                if (File.Exists(Path.Combine(myAppFolder, userToRemove.steamID64 + "Gi.json")))
                {
                    File.Delete(Path.Combine(myAppFolder, userToRemove.steamID64 + "Gi.json"));
                }
                if (File.Exists(Path.Combine(myAppFolder, userToRemove.steamID64 + "Ai.json")))
                {
                    File.Delete(Path.Combine(myAppFolder, userToRemove.steamID64 + "Ai.json"));
                }
                lstvGames.Items.Clear();

            }


        }




        private void btnShowPassword_Click(object sender, EventArgs e)
        {
            // Make sure a user is selected
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte wähle zuerst einen Benutzernamen.");
                return;
            }

            string selectedUser = comboBox1.SelectedItem.ToString();

            // Find the user object
            user? userToShow = userlist.FirstOrDefault(u => u.username == selectedUser);

            if (userToShow.HasValue)
            {
                // Decrypt the password and show it
                string decryptedPassword = CryptoUtility.DecryptString(userToShow.Value.password);

                MessageBox.Show("Passwort für " + selectedUser + " ist: " + decryptedPassword, "Passwort", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("User not found.");
                return;
            }
        }

        private void btnCopyPassword_Click(object sender, EventArgs e)
        {
            // Make sure a user is selected
            if (comboBox1.SelectedIndex == -1)
            {
                MessageBox.Show("Bitte wähle zuerst einen Benutzernamen.");
                return;
            }

            string selectedUser = comboBox1.SelectedItem.ToString();

            // Find the user object
            user? userToShow = userlist.FirstOrDefault(u => u.username == selectedUser);

            if (userToShow.HasValue)
            {
                // Decrypt the password and copy it
                string decryptedPassword = CryptoUtility.DecryptString(userToShow.Value.password);
                Clipboard.SetText(decryptedPassword);
                MessageBox.Show("In den Clipboard kopiert, STRG+V zum einfügen.");
            }
            else
            {
                MessageBox.Show("User not found.");
                return;
            }
        }



        private async Task<string> GetSteamBib(string steamid64)
        {
            string urlGames = $"http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key={apiKey}&steamid={steamid64}&format=json&include_appinfo=1";
            string urlAccount = $"https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key={apiKey}&format=json&steamids={steamid64}";
            string urlProfile = $"https://steamcommunity.com/profiles/{steamid64}";
            if (steamid64 == null)
            {
                MessageBox.Show("Keine SteamID64 gefunden.");
                return null;
            }


            using (HttpClient client = new HttpClient())
            {
                var firstResponse = await client.GetStringAsync(urlGames);
                var gamesJsonData = JObject.Parse(firstResponse);
                string gamesFilePath = Path.Combine(myAppFolder, steamid64 + "Gi.json");
                var gamesArray = gamesJsonData["response"]["games"] as JArray; // Cast to JArray to access the array methods



                if (gamesArray != null && gamesArray.Count > 0)
                {
                    // There are games in the JSON data, so you can proceed with processing
                    var games = gamesJsonData["response"]["games"].Select(game => new
                    {
                        Name = game["name"].ToString(),
                        AppID = game["appid"].ToString(),
                        Playtime = game["playtime_forever"].ToString(),
                        IconURL = game["img_icon_url"].ToString()
                    }).ToList();


                    if (File.Exists(gamesFilePath))
                    {
                        File.Delete(gamesFilePath);
                    }


                    MessageBox.Show("Spiele gefunden.");
                    // Serialize the list of games to JSON as an array



                    // download the image of the game icons for every appid found in the gameArray
                    foreach (var img in games)
                    {
                        string tempFilePath = Path.Combine(myResourcesFolder, img.AppID + ".jpg");
                        if (!File.Exists(tempFilePath))
                        {
                            string urlGameIcon = $"https://cdn.cloudflare.steamstatic.com/steamcommunity/public/images/apps/{img.AppID}/{img.IconURL}.jpg";
                            using (var client2 = new HttpClient())
                            {

                                var response = await client2.GetAsync(urlGameIcon);
                                if (response.IsSuccessStatusCode)
                                {
                                    using (var stream = await response.Content.ReadAsStreamAsync())
                                    using (var fileStream = new FileStream(tempFilePath, FileMode.Create, FileAccess.Write, FileShare.None, 4096, true))
                                    {
                                        await stream.CopyToAsync(fileStream);
                                    }
                                }



                            }
                        }
                    }


                    string json = JsonConvert.SerializeObject(games, Formatting.Indented);


                    // Write the JSON to the file
                    File.WriteAllText(gamesFilePath, json);
                }
                else
                {
                    lstvGames.Items.Clear();
                    MessageBox.Show(@"  -Keine Spiele gefunden.-
1. Stelle sicher das dein Profil Öffentlich ist.
2. Stelle sicher das die Spieldetails auf Öffentlich ist.
            (Diese einstellung findest du unter:)
(->Profil bearbeiten->Datenschutzeinstellungen-> Spieldetails)");

                }


                var secondResponse = await client.GetStringAsync(urlAccount);
                var accountJsonData = JObject.Parse(secondResponse);
                string accountFilePath = Path.Combine(myAppFolder, steamid64 + "Ai.json");

                var account = accountJsonData["response"]["players"].Select(account => new
                {
                    SteamID64 = account["steamid"].ToString(),
                    Nickname = account["personaname"].ToString(),
                    ProfileLink = account["profileurl"].ToString(),
                    ProfileIcon = account["avatarfull"].ToString()
                }).ToList();


                // Delete the file if it exists

                if (File.Exists(accountFilePath))
                {
                    File.Delete(accountFilePath);
                }



                if (account.Count == 0)
                {
                    MessageBox.Show("Kein Account gefunden.");
                }
                else
                {
                    string json = JsonConvert.SerializeObject(account, Formatting.Indented);
                    File.WriteAllText(accountFilePath, json);
                }
                LoadUsersGames(steamid64);
                return null;
            }
        }



        private void feetchGamesButton_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Wähle zuerst einen Benutzer aus.");
                return;
            }
            string SteamID64 = SteamData.GetCurrentSteamID64();

            if (SteamID64 != null)
            {
                Clipboard.SetText(SteamID64);
                GetSteamBib(SteamID64);
                LoadUsersGames(SteamID64);

                for (int i = 0; i < userlist.Count; i++)
                {

                    if (userlist[i].username == comboBox1.SelectedItem.ToString())
                    {
                        user newUser = userlist[i];
                        newUser.steamID64 = SteamID64;
                        userlist[i] = newUser; // Replace the old struct with the new one
                        string json = JsonConvert.SerializeObject(userlist, Formatting.Indented);
                        File.WriteAllText(Path.Combine(myAppFolder, "sysus.json"), json);
                        break;
                    }
                }

            }
            else
            {
                return;
            }

        }



        private void addUserButton_Click(object sender, EventArgs e)
        {
            using (var addUserForm = new AddUserForm(this))
            {
                addUserForm.ShowDialog();
            }
        }


        private void buttonStartGame_Click(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Wähle erst einen Benutzer!");
                return;
            }

            // Kill any running Steam processes
            foreach (var process in Process.GetProcessesByName("steam"))
            {
                process.Kill();
            }

            // Prepare the process start info
            ProcessStartInfo startInfo = new ProcessStartInfo();
            startInfo.FileName = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamExe", "null");
            string username = userlist[comboBox1.SelectedIndex].username;
            string decryptedPassword = CryptoUtility.DecryptString(userlist[comboBox1.SelectedIndex].password);

            // Add login arguments
            startInfo.Arguments = $"-login {username} {decryptedPassword}";

            // Check if a game is selected in listvGames and append its AppID to the arguments
            if (lstvGames.SelectedItems.Count > 0)
            {
                string selectedGameAppID = lstvGames.SelectedItems[0].Tag.ToString(); // Assuming the Tag property holds the AppID
                startInfo.Arguments += $" -applaunch {selectedGameAppID}";
            }

            // Start Steam with the arguments
            Process.Start(startInfo);
        }

        private void linkLabelProfile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (linkLabelProfile.Tag is string url)
            {
                Process.Start(new ProcessStartInfo(url) { UseShellExecute = true });
            }
        }

        private void txtSearchBox_TextChanged(object sender, EventArgs e)
        {
            //get search query from textbox
            string searchQuery = txtSearchBox.Text.ToLower();

            //filter list of games based on search query

        }
    }

}
//https://cdn.cloudflare.steamstatic.com/steamcommunity/public/images/apps/555160/d537afd8696affb4b2294aed07be5e13bcfc5d87.jpg
//http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=EDF2C147BDAEAD8453FB0FAA92E657E8&steamid=76561198399121690&format=json&include_appinfo=1
//https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key=EDF2C147BDAEAD8453FB0FAA92E657E8&format=json&steamids=76561199196109384 