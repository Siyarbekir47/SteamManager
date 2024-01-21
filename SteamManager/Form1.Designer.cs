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
            button1 = new Button();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            button2 = new Button();
            showPasswordButton = new Button();
            txtGameName = new TextBox();
            btnAddGame = new Button();
            lstGames = new ListBox();
            SuspendLayout();
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 14.25F, FontStyle.Regular, GraphicsUnit.Point, 0);
            button1.Location = new Point(12, 267);
            button1.Name = "button1";
            button1.Size = new Size(187, 61);
            button1.TabIndex = 0;
            button1.Text = "Benutzer hinzufügen";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(12, 131);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(187, 23);
            textBox1.TabIndex = 1;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(12, 174);
            textBox2.Name = "textBox2";
            textBox2.PasswordChar = '*';
            textBox2.Size = new Size(187, 23);
            textBox2.TabIndex = 2;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(310, 47);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(197, 23);
            comboBox1.TabIndex = 3;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button2.Location = new Point(310, 76);
            button2.Name = "button2";
            button2.Size = new Size(197, 61);
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
            showPasswordButton.Location = new Point(205, 173);
            showPasswordButton.Name = "showPasswordButton";
            showPasswordButton.Size = new Size(37, 23);
            showPasswordButton.TabIndex = 5;
            showPasswordButton.UseVisualStyleBackColor = false;
            showPasswordButton.Click += button3_Click;
            // 
            // txtGameName
            // 
            txtGameName.Location = new Point(310, 173);
            txtGameName.Name = "txtGameName";
            txtGameName.Size = new Size(197, 23);
            txtGameName.TabIndex = 6;
            // 
            // btnAddGame
            // 
            btnAddGame.Font = new Font("Segoe UI", 20.25F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnAddGame.Location = new Point(310, 202);
            btnAddGame.Name = "btnAddGame";
            btnAddGame.Size = new Size(197, 61);
            btnAddGame.TabIndex = 7;
            btnAddGame.Text = "Add Game";
            btnAddGame.UseVisualStyleBackColor = true;
            btnAddGame.Click += button3_Click_1;
            // 
            // lstGames
            // 
            lstGames.FormattingEnabled = true;
            lstGames.ItemHeight = 15;
            lstGames.Location = new Point(569, 47);
            lstGames.Name = "lstGames";
            lstGames.Size = new Size(158, 409);
            lstGames.TabIndex = 8;
            lstGames.SelectedIndexChanged += lstGames_SelectedIndexChanged;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImageLayout = ImageLayout.None;
            ClientSize = new Size(773, 477);
            Controls.Add(lstGames);
            Controls.Add(btnAddGame);
            Controls.Add(txtGameName);
            Controls.Add(showPasswordButton);
            Controls.Add(button2);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(button1);
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Name = "Form1";
            Text = "Steam Login Manager";
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
    }
}
