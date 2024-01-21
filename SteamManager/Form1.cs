using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.DirectoryServices;
using System.Threading.Tasks;
using Newtonsoft.Json;

/* TODO:
- encrypt before sending to database
- Allow nicknames for accounts
- check if database is empty, this causes an error on loadup sometimes if the first line is empty (the following lines will also be empty but trying to access and empty object poses a problem)
-logout button(Steam Command: " -logoff ")
-let me add games to files i already own
*/
namespace SteamManager
{

    public partial class Form1 : Form
    {

        private string appLocalFolder;
        private string myAppFolder;
        private string fullPath;
        private Dictionary<string, List<string>> userGames = new Dictionary<string, List<string>>();
     struct user
        {
            public user(string user, string pass)
            {
                username = user;
                password = pass;
            }

            public string username { get; set; }
            public string password { get; set; }


        }

        List<user> userlist = new List<user>();

        private void SaveUserGames()
        {
            //convert the userGames dictionary to a JSON string
            string json = JsonConvert.SerializeObject(userGames, Formatting.Indented);

            //write the json string to a file
            File.WriteAllText(Path.Combine(myAppFolder, "sysga"), json);
        }

        private void LoadUserGames()
        {
            string filePath = Path.Combine(myAppFolder, "sysga");

            //check if the file exists
            if (File.Exists(filePath))
            {
                //read json string from file
                string json = File.ReadAllText(filePath);

                //convert the json string back to a dictornary
                userGames = JsonConvert.DeserializeObject<Dictionary<string, List<string>>>(json);
            }
        }
        private void SaveUsers()
        {
            // You should encrypt or hash the passwords before saving
            string json = JsonConvert.SerializeObject(userlist, Formatting.Indented);
            File.WriteAllText(Path.Combine(myAppFolder, "sysus.json"), json);
        }


        private void LoadUsers()
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
                var newUser = new user(textBox1.Text, textBox2.Text);
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


            // Assuming LoadUserGames is a method you've created to load games for users

            LoadUsers();
            LoadUserGames();




        }

        private void button2_Click(object sender, EventArgs e)
        {
            foreach (var process in Process.GetProcessesByName("steam"))
            {
                process.Kill();
            }

            ProcessStartInfo startInfo = new ProcessStartInfo();

            startInfo.FileName = (string)Registry.GetValue(@"HKEY_CURRENT_USER\SOFTWARE\Valve\Steam", "SteamExe", "null");
            startInfo.Arguments = " -login " + userlist[comboBox1.SelectedIndex].username + " " + userlist[comboBox1.SelectedIndex].password;
            Process.Start(startInfo);



        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            Console.Write("test");
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

        private void lstGames_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedUser = comboBox1.SelectedItem.ToString();
            lstGames.Items.Clear();

            if (userGames.ContainsKey(selectedUser))
            {
                foreach (string game in userGames[selectedUser])
                {
                    lstGames.Items.Add(game);
                }
            }
        }

        private void deleteUser_Click(object sender, EventArgs e)
        {
            if(comboBox1.SelectedIndex < 0)
            {
                MessageBox.Show("Wähle erst einen benutzer aus.");
                return;

            }

            string selectedUser = comboBox1.SelectedItem.ToString();

            //confirmation dialog to make sure the user wants to delete this
            var confirmResult = MessageBox.Show("Sicher das du den Benutzer löschen willst?", "Löschen bestätigen!", MessageBoxButtons.YesNo);

            if(confirmResult == DialogResult.Yes) 
            {
                //remove user from combobox
                comboBox1.Items.Remove(selectedUser);

                //remove user from userGames dictinoary
                if(userGames.ContainsKey(selectedUser))
                {
                    userGames.Remove(selectedUser);
                    SaveUserGames(); // update the storage
                }

                //remove user from userlist and update storage
                user userToRemove = userlist.First(u => u.username == selectedUser);
                if(userToRemove.username != null)
                {
                    userlist.Remove(userToRemove);
                    SaveUsers();

                }
                lstGames.Items.Clear();

            }


        }
    }
}
