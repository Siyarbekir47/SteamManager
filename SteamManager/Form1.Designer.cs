namespace SteamManager
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            showPasswordButton = new Button();
            lstGames = new ListBox();
            deleteUser = new Button();
            userLabel = new Label();
            passLabel = new Label();
            userListLabel = new Label();
            listGameLabel = new Label();
            btnShowPassword = new Button();
            btnCopyPassword = new Button();
            feetchGamesButton = new Button();
            imgIcons = new ImageList(components);
            SuspendLayout();
            // 
            // button1
            // 
            button1.FlatStyle = FlatStyle.Flat;
            button1.Font = new Font("Algerian", 15.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Location = new Point(22, 117);
            button1.Name = "button1";
            button1.Size = new Size(187, 65);
            button1.TabIndex = 0;
            button1.Text = "Benutzer hinzufügen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(22, 35);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 27);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            textBox1.KeyDown += textBox1_KeyDown;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(22, 84);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(187, 27);
            textBox2.TabIndex = 2;
            textBox2.KeyDown += textBox2_KeyDown;
            // 
            // comboBox1
            // 
            comboBox1.Font = new Font("Yu Gothic", 14.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(503, 27);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 33);
            comboBox1.TabIndex = 3;
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // button2
            // 
            button2.FlatStyle = FlatStyle.Flat;
            button2.Font = new Font("Algerian", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(503, 115);
            button2.Name = "button2";
            button2.Size = new Size(197, 65);
            button2.TabIndex = 4;
            button2.Text = "Login";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // showPasswordButton
            // 
            showPasswordButton.BackColor = SystemColors.ButtonHighlight;
            showPasswordButton.BackgroundImageLayout = ImageLayout.Center;
            showPasswordButton.FlatAppearance.BorderSize = 0;
            showPasswordButton.FlatAppearance.MouseDownBackColor = Color.FromArgb(255, 128, 128);
            showPasswordButton.FlatAppearance.MouseOverBackColor = Color.FromArgb(255, 128, 128);
            showPasswordButton.FlatStyle = FlatStyle.Flat;
            showPasswordButton.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            showPasswordButton.Image = Properties.Resources.auge;
            showPasswordButton.Location = new Point(215, 94);
            showPasswordButton.Name = "showPasswordButton";
            showPasswordButton.Size = new Size(25, 17);
            showPasswordButton.TabIndex = 5;
            showPasswordButton.UseVisualStyleBackColor = false;
            showPasswordButton.Click += button3_Click;
            // 
            // lstGames
            // 
            lstGames.Font = new Font("Segoe UI", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lstGames.FormattingEnabled = true;
            lstGames.ItemHeight = 17;
            lstGames.Location = new Point(810, 29);
            lstGames.Name = "lstGames";
            lstGames.Size = new Size(348, 701);
            lstGames.TabIndex = 8;
            lstGames.SelectedIndexChanged += lstGames_SelectedIndexChanged;
            // 
            // deleteUser
            // 
            deleteUser.FlatStyle = FlatStyle.Flat;
            deleteUser.Font = new Font("Yu Gothic", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            deleteUser.Location = new Point(706, 29);
            deleteUser.Name = "deleteUser";
            deleteUser.Size = new Size(98, 25);
            deleteUser.TabIndex = 9;
            deleteUser.Text = "Löschen";
            deleteUser.UseVisualStyleBackColor = true;
            deleteUser.Click += deleteUser_Click;
            // 
            // userLabel
            // 
            userLabel.AutoSize = true;
            userLabel.Location = new Point(22, 16);
            userLabel.Name = "userLabel";
            userLabel.Size = new Size(91, 16);
            userLabel.TabIndex = 11;
            userLabel.Text = "Benutzername:";
            // 
            // passLabel
            // 
            passLabel.AutoSize = true;
            passLabel.Location = new Point(12, 58);
            passLabel.Name = "passLabel";
            passLabel.Size = new Size(61, 16);
            passLabel.TabIndex = 12;
            passLabel.Text = "Passwort:";
            // 
            // userListLabel
            // 
            userListLabel.AutoSize = true;
            userListLabel.Location = new Point(503, 8);
            userListLabel.Name = "userListLabel";
            userListLabel.Size = new Size(98, 16);
            userListLabel.TabIndex = 13;
            userListLabel.Text = "Account wählen:";
            // 
            // listGameLabel
            // 
            listGameLabel.AutoSize = true;
            listGameLabel.Location = new Point(810, 10);
            listGameLabel.Name = "listGameLabel";
            listGameLabel.Size = new Size(71, 16);
            listGameLabel.TabIndex = 15;
            listGameLabel.Text = "Spieleliste: ";
            // 
            // btnShowPassword
            // 
            btnShowPassword.FlatStyle = FlatStyle.Flat;
            btnShowPassword.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnShowPassword.Location = new Point(602, 64);
            btnShowPassword.Name = "btnShowPassword";
            btnShowPassword.Size = new Size(98, 45);
            btnShowPassword.TabIndex = 16;
            btnShowPassword.Text = "Passwort Anzeigen";
            btnShowPassword.UseVisualStyleBackColor = true;
            btnShowPassword.Click += btnShowPassword_Click;
            // 
            // btnCopyPassword
            // 
            btnCopyPassword.FlatStyle = FlatStyle.Flat;
            btnCopyPassword.Font = new Font("Yu Gothic", 9.75F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCopyPassword.Location = new Point(503, 64);
            btnCopyPassword.Name = "btnCopyPassword";
            btnCopyPassword.Size = new Size(98, 45);
            btnCopyPassword.TabIndex = 17;
            btnCopyPassword.Text = "Passwort Kopieren";
            btnCopyPassword.UseVisualStyleBackColor = true;
            btnCopyPassword.Click += btnCopyPassword_Click;
            // 
            // feetchGamesButton
            // 
            feetchGamesButton.Location = new Point(706, 64);
            feetchGamesButton.Name = "feetchGamesButton";
            feetchGamesButton.Size = new Size(75, 23);
            feetchGamesButton.TabIndex = 18;
            feetchGamesButton.Text = "SteamID";
            feetchGamesButton.UseVisualStyleBackColor = true;
            feetchGamesButton.Click += feetchGamesButton_Click;
            // 
            // imgIcons
            // 
            imgIcons.ColorDepth = ColorDepth.Depth32Bit;
            imgIcons.ImageSize = new Size(16, 16);
            imgIcons.TransparentColor = Color.Transparent;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 16F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(1192, 759);
            Controls.Add(feetchGamesButton);
            Controls.Add(btnCopyPassword);
            Controls.Add(btnShowPassword);
            Controls.Add(listGameLabel);
            Controls.Add(userListLabel);
            Controls.Add(passLabel);
            Controls.Add(userLabel);
            Controls.Add(deleteUser);
            Controls.Add(lstGames);
            Controls.Add(showPasswordButton);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            Font = new Font("Yu Gothic", 9F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.FixedDialog;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "Form1";
            Text = "@Siyarbekir's ACM";
            Load += Form1_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button button1;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private Button button2;
        private Button showPasswordButton;
        private TextBox txtGameName;
        private Button btnAddGame;
        private ListBox lstGames;
        private Button deleteUser;
        private Button deleteGameButton;
        private Label userLabel;
        private Label passLabel;
        private Label userListLabel;
        private Label gameNameLabel;
        private Label listGameLabel;
        private Button btnShowPassword;
        private Button btnCopyPassword;
        private Button feetchGamesButton;
        private ImageList imgIcons;
    }
}
