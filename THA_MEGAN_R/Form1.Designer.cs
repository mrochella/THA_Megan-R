namespace THA_MEGAN_R
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_soccerTeamList = new System.Windows.Forms.Label();
            this.label_chooseCountry = new System.Windows.Forms.Label();
            this.label_chooseTeam = new System.Windows.Forms.Label();
            this.label_addingTeam = new System.Windows.Forms.Label();
            this.label_teamName = new System.Windows.Forms.Label();
            this.label_teamCountry = new System.Windows.Forms.Label();
            this.label_teamCity = new System.Windows.Forms.Label();
            this.label_addingPlayers = new System.Windows.Forms.Label();
            this.label_playerName = new System.Windows.Forms.Label();
            this.label_playerNumber = new System.Windows.Forms.Label();
            this.label_playerPos = new System.Windows.Forms.Label();
            this.comboBox_country = new System.Windows.Forms.ComboBox();
            this.comboBox_team = new System.Windows.Forms.ComboBox();
            this.textBox_nameTeam = new System.Windows.Forms.TextBox();
            this.textBox_countryTeam = new System.Windows.Forms.TextBox();
            this.textBox_cityTeam = new System.Windows.Forms.TextBox();
            this.textBox_playersName = new System.Windows.Forms.TextBox();
            this.textBox_playersNumber = new System.Windows.Forms.TextBox();
            this.butt_addPlayers = new System.Windows.Forms.Button();
            this.butt_addTeam = new System.Windows.Forms.Button();
            this.butt_Remove = new System.Windows.Forms.Button();
            this.listBox_data = new System.Windows.Forms.ListBox();
            this.comboBox_playerPosition = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // label_soccerTeamList
            // 
            this.label_soccerTeamList.AutoSize = true;
            this.label_soccerTeamList.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_soccerTeamList.Location = new System.Drawing.Point(56, 22);
            this.label_soccerTeamList.Name = "label_soccerTeamList";
            this.label_soccerTeamList.Size = new System.Drawing.Size(142, 15);
            this.label_soccerTeamList.TabIndex = 0;
            this.label_soccerTeamList.Text = "~ Soccer Team List ~";
            // 
            // label_chooseCountry
            // 
            this.label_chooseCountry.AutoSize = true;
            this.label_chooseCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chooseCountry.Location = new System.Drawing.Point(12, 65);
            this.label_chooseCountry.Name = "label_chooseCountry";
            this.label_chooseCountry.Size = new System.Drawing.Size(111, 15);
            this.label_chooseCountry.TabIndex = 1;
            this.label_chooseCountry.Text = "Choose Country:";
            // 
            // label_chooseTeam
            // 
            this.label_chooseTeam.AutoSize = true;
            this.label_chooseTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_chooseTeam.Location = new System.Drawing.Point(12, 109);
            this.label_chooseTeam.Name = "label_chooseTeam";
            this.label_chooseTeam.Size = new System.Drawing.Size(99, 15);
            this.label_chooseTeam.TabIndex = 2;
            this.label_chooseTeam.Text = "Choose Team:";
            // 
            // label_addingTeam
            // 
            this.label_addingTeam.AutoSize = true;
            this.label_addingTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addingTeam.Location = new System.Drawing.Point(344, 22);
            this.label_addingTeam.Name = "label_addingTeam";
            this.label_addingTeam.Size = new System.Drawing.Size(91, 15);
            this.label_addingTeam.TabIndex = 3;
            this.label_addingTeam.Text = "Adding Team";
            // 
            // label_teamName
            // 
            this.label_teamName.AutoSize = true;
            this.label_teamName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teamName.Location = new System.Drawing.Point(280, 65);
            this.label_teamName.Name = "label_teamName";
            this.label_teamName.Size = new System.Drawing.Size(89, 15);
            this.label_teamName.TabIndex = 4;
            this.label_teamName.Text = "Team Name:";
            // 
            // label_teamCountry
            // 
            this.label_teamCountry.AutoSize = true;
            this.label_teamCountry.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teamCountry.Location = new System.Drawing.Point(280, 109);
            this.label_teamCountry.Name = "label_teamCountry";
            this.label_teamCountry.Size = new System.Drawing.Size(99, 15);
            this.label_teamCountry.TabIndex = 5;
            this.label_teamCountry.Text = "Team Country:";
            // 
            // label_teamCity
            // 
            this.label_teamCity.AutoSize = true;
            this.label_teamCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_teamCity.Location = new System.Drawing.Point(280, 154);
            this.label_teamCity.Name = "label_teamCity";
            this.label_teamCity.Size = new System.Drawing.Size(74, 15);
            this.label_teamCity.TabIndex = 6;
            this.label_teamCity.Text = "Team City:";
            // 
            // label_addingPlayers
            // 
            this.label_addingPlayers.AutoSize = true;
            this.label_addingPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_addingPlayers.Location = new System.Drawing.Point(611, 22);
            this.label_addingPlayers.Name = "label_addingPlayers";
            this.label_addingPlayers.Size = new System.Drawing.Size(102, 15);
            this.label_addingPlayers.TabIndex = 7;
            this.label_addingPlayers.Text = "Adding Players";
            // 
            // label_playerName
            // 
            this.label_playerName.AutoSize = true;
            this.label_playerName.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playerName.Location = new System.Drawing.Point(555, 65);
            this.label_playerName.Name = "label_playerName";
            this.label_playerName.Size = new System.Drawing.Size(93, 15);
            this.label_playerName.TabIndex = 8;
            this.label_playerName.Text = "Player Name:";
            // 
            // label_playerNumber
            // 
            this.label_playerNumber.AutoSize = true;
            this.label_playerNumber.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playerNumber.Location = new System.Drawing.Point(555, 109);
            this.label_playerNumber.Name = "label_playerNumber";
            this.label_playerNumber.Size = new System.Drawing.Size(106, 15);
            this.label_playerNumber.TabIndex = 9;
            this.label_playerNumber.Text = "Player Number:";
            // 
            // label_playerPos
            // 
            this.label_playerPos.AutoSize = true;
            this.label_playerPos.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_playerPos.Location = new System.Drawing.Point(555, 154);
            this.label_playerPos.Name = "label_playerPos";
            this.label_playerPos.Size = new System.Drawing.Size(107, 15);
            this.label_playerPos.TabIndex = 10;
            this.label_playerPos.Text = "Player Position:";
            // 
            // comboBox_country
            // 
            this.comboBox_country.FormattingEnabled = true;
            this.comboBox_country.Location = new System.Drawing.Point(139, 65);
            this.comboBox_country.Name = "comboBox_country";
            this.comboBox_country.Size = new System.Drawing.Size(121, 21);
            this.comboBox_country.TabIndex = 11;
            this.comboBox_country.SelectionChangeCommitted += new System.EventHandler(this.comboBox_country_SelectionChangeCommitted);
            // 
            // comboBox_team
            // 
            this.comboBox_team.FormattingEnabled = true;
            this.comboBox_team.Location = new System.Drawing.Point(139, 109);
            this.comboBox_team.Name = "comboBox_team";
            this.comboBox_team.Size = new System.Drawing.Size(121, 21);
            this.comboBox_team.TabIndex = 12;
            this.comboBox_team.SelectionChangeCommitted += new System.EventHandler(this.comboBox_team_SelectionChangeCommitted);
            // 
            // textBox_nameTeam
            // 
            this.textBox_nameTeam.Location = new System.Drawing.Point(400, 64);
            this.textBox_nameTeam.Name = "textBox_nameTeam";
            this.textBox_nameTeam.Size = new System.Drawing.Size(100, 20);
            this.textBox_nameTeam.TabIndex = 13;
            // 
            // textBox_countryTeam
            // 
            this.textBox_countryTeam.Location = new System.Drawing.Point(400, 108);
            this.textBox_countryTeam.Name = "textBox_countryTeam";
            this.textBox_countryTeam.Size = new System.Drawing.Size(100, 20);
            this.textBox_countryTeam.TabIndex = 14;
            // 
            // textBox_cityTeam
            // 
            this.textBox_cityTeam.Location = new System.Drawing.Point(400, 153);
            this.textBox_cityTeam.Name = "textBox_cityTeam";
            this.textBox_cityTeam.Size = new System.Drawing.Size(100, 20);
            this.textBox_cityTeam.TabIndex = 15;
            // 
            // textBox_playersName
            // 
            this.textBox_playersName.Location = new System.Drawing.Point(671, 64);
            this.textBox_playersName.Name = "textBox_playersName";
            this.textBox_playersName.Size = new System.Drawing.Size(100, 20);
            this.textBox_playersName.TabIndex = 16;
            // 
            // textBox_playersNumber
            // 
            this.textBox_playersNumber.Location = new System.Drawing.Point(671, 108);
            this.textBox_playersNumber.Name = "textBox_playersNumber";
            this.textBox_playersNumber.Size = new System.Drawing.Size(100, 20);
            this.textBox_playersNumber.TabIndex = 17;
            // 
            // butt_addPlayers
            // 
            this.butt_addPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_addPlayers.Location = new System.Drawing.Point(671, 202);
            this.butt_addPlayers.Name = "butt_addPlayers";
            this.butt_addPlayers.Size = new System.Drawing.Size(75, 23);
            this.butt_addPlayers.TabIndex = 19;
            this.butt_addPlayers.Text = "Add";
            this.butt_addPlayers.UseVisualStyleBackColor = true;
            this.butt_addPlayers.Click += new System.EventHandler(this.butt_addPlayers_Click);
            // 
            // butt_addTeam
            // 
            this.butt_addTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_addTeam.Location = new System.Drawing.Point(400, 202);
            this.butt_addTeam.Name = "butt_addTeam";
            this.butt_addTeam.Size = new System.Drawing.Size(75, 23);
            this.butt_addTeam.TabIndex = 20;
            this.butt_addTeam.Text = "Add";
            this.butt_addTeam.UseVisualStyleBackColor = true;
            this.butt_addTeam.Click += new System.EventHandler(this.butt_addTeam_Click);
            // 
            // butt_Remove
            // 
            this.butt_Remove.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butt_Remove.Location = new System.Drawing.Point(36, 342);
            this.butt_Remove.Name = "butt_Remove";
            this.butt_Remove.Size = new System.Drawing.Size(75, 23);
            this.butt_Remove.TabIndex = 21;
            this.butt_Remove.Text = "Remove";
            this.butt_Remove.UseVisualStyleBackColor = true;
            this.butt_Remove.Click += new System.EventHandler(this.butt_Remove_Click);
            // 
            // listBox_data
            // 
            this.listBox_data.FormattingEnabled = true;
            this.listBox_data.Location = new System.Drawing.Point(36, 202);
            this.listBox_data.Name = "listBox_data";
            this.listBox_data.Size = new System.Drawing.Size(210, 121);
            this.listBox_data.TabIndex = 22;
            // 
            // comboBox_playerPosition
            // 
            this.comboBox_playerPosition.FormattingEnabled = true;
            this.comboBox_playerPosition.Items.AddRange(new object[] {
            "GK",
            "DF",
            "MF",
            "FW"});
            this.comboBox_playerPosition.Location = new System.Drawing.Point(671, 151);
            this.comboBox_playerPosition.Name = "comboBox_playerPosition";
            this.comboBox_playerPosition.Size = new System.Drawing.Size(121, 21);
            this.comboBox_playerPosition.TabIndex = 23;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.comboBox_playerPosition);
            this.Controls.Add(this.listBox_data);
            this.Controls.Add(this.butt_Remove);
            this.Controls.Add(this.butt_addTeam);
            this.Controls.Add(this.butt_addPlayers);
            this.Controls.Add(this.textBox_playersNumber);
            this.Controls.Add(this.textBox_playersName);
            this.Controls.Add(this.textBox_cityTeam);
            this.Controls.Add(this.textBox_countryTeam);
            this.Controls.Add(this.textBox_nameTeam);
            this.Controls.Add(this.comboBox_team);
            this.Controls.Add(this.comboBox_country);
            this.Controls.Add(this.label_playerPos);
            this.Controls.Add(this.label_playerNumber);
            this.Controls.Add(this.label_playerName);
            this.Controls.Add(this.label_addingPlayers);
            this.Controls.Add(this.label_teamCity);
            this.Controls.Add(this.label_teamCountry);
            this.Controls.Add(this.label_teamName);
            this.Controls.Add(this.label_addingTeam);
            this.Controls.Add(this.label_chooseTeam);
            this.Controls.Add(this.label_chooseCountry);
            this.Controls.Add(this.label_soccerTeamList);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_soccerTeamList;
        private System.Windows.Forms.Label label_chooseCountry;
        private System.Windows.Forms.Label label_chooseTeam;
        private System.Windows.Forms.Label label_addingTeam;
        private System.Windows.Forms.Label label_teamName;
        private System.Windows.Forms.Label label_teamCountry;
        private System.Windows.Forms.Label label_teamCity;
        private System.Windows.Forms.Label label_addingPlayers;
        private System.Windows.Forms.Label label_playerName;
        private System.Windows.Forms.Label label_playerNumber;
        private System.Windows.Forms.Label label_playerPos;
        private System.Windows.Forms.ComboBox comboBox_country;
        private System.Windows.Forms.ComboBox comboBox_team;
        private System.Windows.Forms.TextBox textBox_nameTeam;
        private System.Windows.Forms.TextBox textBox_countryTeam;
        private System.Windows.Forms.TextBox textBox_cityTeam;
        private System.Windows.Forms.TextBox textBox_playersName;
        private System.Windows.Forms.TextBox textBox_playersNumber;
        private System.Windows.Forms.Button butt_addPlayers;
        private System.Windows.Forms.Button butt_addTeam;
        private System.Windows.Forms.Button butt_Remove;
        private System.Windows.Forms.ListBox listBox_data;
        private System.Windows.Forms.ComboBox comboBox_playerPosition;
    }
}

