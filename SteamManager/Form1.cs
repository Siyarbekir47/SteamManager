using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.Win32;
using System.Diagnostics;
using System.DirectoryServices;
using System.Threading.Tasks;


/* TODO:
-mask password entry & encrypt before sending to database
- Allow nicknames for accounts
- check if database is empty, this causes an error on loadup sometimes if the first line is empty (the following lines will also be empty but trying to access and empty object poses a problem)
- Check if new user textbox entires are null before adding them to database (will also prevent the previous error from becoming an issue)
- Clear textbox text when creating a new database entry
-logout button(Steam Command: " -logoff ")
*/
namespace SteamManager
{
    public partial class Form1 : Form
    {

        private string appLocalFolder;
        private string myAppFolder;
        private string fullPath;

        struct user
        {
            public user(string user, string pass)
            {
                username = user;
                password = pass;
            }

            public string username { get; }
            public string password { get; }





        }

        List<user> userlist = new List<user>();
        public Form1()
        {
            InitializeComponent();
            appLocalFolder = Environment.GetFolderPath(Environment.SpecialFolder.LocalApplicationData);
            myAppFolder = Path.Combine(appLocalFolder, "SM");
            fullPath = Path.Combine(myAppFolder, "syspl");
        }

        private void button1_Click(object sender, EventArgs e)
        {
            List<string> lines = File.ReadAllLines(fullPath).ToList();
            var User = new user(textBox1.Text, textBox2.Text);
            userlist.Add(User);
            lines.Add(User.username + "," + User.password);
            File.WriteAllLines(fullPath, lines);

            comboBox1.Items.Clear();
            foreach (user v in userlist)
            {
                comboBox1.Items.Add(v.username);
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CheckForIllegalCrossThreadCalls = false;

            if (!Directory.Exists(myAppFolder))
            {
                Directory.CreateDirectory(myAppFolder);
            }


            if (!File.Exists(fullPath))
            {
                StreamWriter sw = File.CreateText(fullPath);
                sw.Flush();
                sw.Dispose();
            }
            List<string> lines = File.ReadAllLines(fullPath).ToList();
            foreach (var line in lines)
            {
                //user,pass
                string[] entries = line.Split(',');
                user newuser = new user(entries[0], entries[1]);
                comboBox1.Items.Add(entries[0]);
                userlist.Add(newuser);
            }






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
    }
}
