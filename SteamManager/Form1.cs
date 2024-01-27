using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.DirectoryServices;
using System.Threading.Tasks;
using Newtonsoft.Json;
using System.Net.Http;
using Newtonsoft.Json.Linq;
using System.Security.Policy;

/* TODO:
- Allow nicknames for accounts
*/
namespace SteamManager
{

    public partial class Form1 : Form
    {


        private string appLocalFolder;
        private string myAppFolder;
        private string fullPath;
        private string apiKey = "Your_API_Key";
        private Dictionary<string, List<string>> userGames = new Dictionary<string, List<string>>();

        struct user
        {
            public user(string user, string pass, bool isPasswordEncrypted)
            {
                username = user;
                password = pass;
                this.isPasswordEncrypted = isPasswordEncrypted;
            }

            public string username { get; set; }
            public string password { get; set; }
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
        }




        private void SaveUserGames()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string selectedUser = comboBox1.SelectedItem.ToString();
                string gamesFilePath = Path.Combine(myAppFolder, selectedUser + "sysga");

                // Get the current list of games from lstGames
                List<string> currentGames = lstGames.Items.Cast<string>().ToList();

                // Serialize the list of games to JSON as an array
                string json = JsonConvert.SerializeObject(currentGames, Formatting.Indented);

                // Write the JSON to the file
                File.WriteAllText(gamesFilePath, json);
            }
        }


        private void LoadUserGames()
        {
            if (comboBox1.SelectedIndex != -1)
            {
                string selectedUser = comboBox1.SelectedItem.ToString();
                string gamesFilePath = Path.Combine(myAppFolder, selectedUser + "sysga");

                if (File.Exists(gamesFilePath))
                {
                    try
                    {
                        // Deserialize the JSON data as a List<string>
                        string json = File.ReadAllText(gamesFilePath);
                        List<string> loadedGames = JsonConvert.DeserializeObject<List<string>>(json);

                        if (loadedGames != null)
                        {
                            // Clear the existing list and add the loaded games to lstGames
                            lstGames.Items.Clear();
                            lstGames.Items.AddRange(loadedGames.ToArray());
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
            if(File.Exists(gamesFilePath))
            {

                try
                {
                    string json = File.ReadAllText(gamesFilePath);
                    List<GameInfo> loadedGames = JsonConvert.DeserializeObject<List<GameInfo>>(json);

                    if (loadedGames != null)
                    {
                        // Clear the existing list and add the loaded games to lstGames
                        listGames.Items.Clear();
                        loadedGames.ForEach(loadedGames => listGames.Items.Add(loadedGames.Name));
                    }
                    else
                    {
                        MessageBox.Show("The games file is empty or contains invalid data.", "Loading Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                    loadedGames.ForEach(loadedGames => listGames.Items.Add(loadedGames.Name));

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
                    var encryptedUser = new user(userlist[i].username, CryptoUtility.EncryptString(userlist[i].password), true);
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



        public Form1()
        {
            InitializeComponent();
            appLocalFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            myAppFolder = Path.Combine(appLocalFolder, "SM");
            fullPath = Path.Combine(myAppFolder, "syspl");


        }


        private void button1_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(textBox1.Text))
            {
                MessageBox.Show("Benutzername ist leer.");
            }
            else if (string.IsNullOrEmpty(textBox2.Text))
            {
                MessageBox.Show("Passwort ist leer.");
            }
            else
            {
                var newUser = new user(textBox1.Text, textBox2.Text, false);
                userlist.Add(newUser);

                SaveUsers(); // This will update the storage with the new user list.

                comboBox1.Items.Clear();
                foreach (user u in userlist)
                {
                    comboBox1.Items.Add(u.username);
                }

                textBox1.Clear();
                textBox2.Clear();
                MessageBox.Show("Benutzer erfolgreich hinzugefügt.");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (!Directory.Exists(myAppFolder))
            {
                Directory.CreateDirectory(myAppFolder);
            }
            showPasswordButton.BackColor = Color.Red;


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

        private void button3_Click(object sender, EventArgs e)
        {

            if (textBox2.PasswordChar == '*')
            {
                // Show the password
                textBox2.PasswordChar = '\0'; // Setting it to '\0' shows the text
                showPasswordButton.BackColor = Color.Green;
            }
            else
            {
                // Mask the password again
                textBox2.PasswordChar = '*'; // Setting it back to '*' masks the text
                showPasswordButton.BackColor = Color.Red;
            }


        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            if (comboBox1.SelectedItem == null)
            {
                MessageBox.Show("Wähle zuerst ein Benutzer aus.");
                return;
            }
            string selectedUser = comboBox1.SelectedItem.ToString();
            string gameName = txtGameName.Text.Trim();

            if (!string.IsNullOrEmpty(gameName) && !lstGames.Items.Contains(gameName))
            {
                if (!userGames.ContainsKey(selectedUser))
                {
                    userGames[selectedUser] = new List<string>();
                }

                userGames[selectedUser].Add(gameName);
                lstGames.Items.Add(gameName);
                SaveUserGames();  // You need to implement this method to save the updated games list.
                txtGameName.Clear();
            }
            else
            {
                MessageBox.Show("Please enter a valid game name.");
            }
        }




        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

            string selectedUser = comboBox1.SelectedItem.ToString();
            lstGames.Items.Clear();
            LoadUserGames();
            if (userGames.ContainsKey(selectedUser))
            {
                lstGames.Items.Clear();
                foreach (string game in userGames[selectedUser])
                {
                    lstGames.Items.Add(game);
                }
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
                    SaveUserGames(); // update the storage
                }

                //remove user from userlist and update storage
                user userToRemove = userlist.First(u => u.username == selectedUser);
                if (userToRemove.username != null)
                {
                    userlist.Remove(userToRemove);
                    SaveUsers();

                }
                lstGames.Items.Clear();

            }


        }

        private void deleteGameButton_Click(object sender, EventArgs e)
        {
            if (lstGames.SelectedIndex != -1)
            {
                //remove the selected game from list
                string selectedGame = lstGames.SelectedItem.ToString();
                lstGames.Items.Remove(selectedGame);
                SaveUserGames();

            }
            else
            {
                MessageBox.Show("Bitte ein Spiel auswählen zum Löschen.", "Spiel löschen", MessageBoxButtons.OK, MessageBoxIcon.Information);

            }
        }

        private void txtGameName_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button3_Click_1(sender, e);
            }
        }

        private void textBox1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                textBox2.Focus();
            }
        }

        private void textBox2_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                button1_Click(sender, e);
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
                    string json = JsonConvert.SerializeObject(games, Formatting.Indented);


                    // Write the JSON to the file
                    File.WriteAllText(gamesFilePath, json);
                }
                else
                {
                    MessageBox.Show("Keine Spiele gefunden.");
                    return null;
                }


                var secondResponse = await client.GetStringAsync(urlAccount);
                var accountJsonData = JObject.Parse(secondResponse);
                string accountFilePath = Path.Combine(myAppFolder, steamid64 + "Ai.json");

                var account = accountJsonData["response"]["players"].Select(account => new
                {
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

            string SteamID64 = SteamData.GetCurrentSteamID64();

            if(SteamID64 != null)
            {
                Clipboard.SetText(SteamID64);
                GetSteamBib(SteamID64);
                LoadUsersGames(SteamID64);
            }
            else
            {
                return;
            }






        }

        private void listGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
//https://cdn.cloudflare.steamstatic.com/steamcommunity/public/images/apps/555160/d537afd8696affb4b2294aed07be5e13bcfc5d87.jpg
//http://api.steampowered.com/IPlayerService/GetOwnedGames/v0001/?key=EDF2C147BDAEAD8453FB0FAA92E657E8&steamid=76561198399121690&format=json&include_appinfo=1
//https://api.steampowered.com/ISteamUser/GetPlayerSummaries/v2/?key=EDF2C147BDAEAD8453FB0FAA92E657E8&format=json&steamids=76561199196109384 