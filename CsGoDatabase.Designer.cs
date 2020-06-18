namespace CsGoDatabase
{
    partial class CsGoDatabase
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
            this.labelPlayers = new System.Windows.Forms.Label();
            this.labelTeams = new System.Windows.Forms.Label();
            this.labelStats = new System.Windows.Forms.Label();
            this.labelMatches = new System.Windows.Forms.Label();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonDeleteTeam = new System.Windows.Forms.Button();
            this.buttonDeletePlayer = new System.Windows.Forms.Button();
            this.buttonAddPlayer = new System.Windows.Forms.Button();
            this.buttonDeleteStats = new System.Windows.Forms.Button();
            this.buttonAddStats = new System.Windows.Forms.Button();
            this.listViewTeams = new System.Windows.Forms.ListView();
            this.col1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.col2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewPlayers = new System.Windows.Forms.ListView();
            this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewStats = new System.Windows.Forms.ListView();
            this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewMatches = new System.Windows.Forms.ListView();
            this.columnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.buttonDeleteMatch = new System.Windows.Forms.Button();
            this.buttonAddMatch = new System.Windows.Forms.Button();
            this.buttonRaport = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonUpdateMatch = new System.Windows.Forms.Button();
            this.buttonUpdateTeam = new System.Windows.Forms.Button();
            this.buttonUpdatePlayer = new System.Windows.Forms.Button();
            this.buttonUpdateStats = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelPlayers
            // 
            this.labelPlayers.AutoSize = true;
            this.labelPlayers.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelPlayers.Location = new System.Drawing.Point(661, 50);
            this.labelPlayers.Name = "labelPlayers";
            this.labelPlayers.Size = new System.Drawing.Size(161, 26);
            this.labelPlayers.TabIndex = 0;
            this.labelPlayers.Text = "Team\'s Players";
            // 
            // labelTeams
            // 
            this.labelTeams.AutoSize = true;
            this.labelTeams.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelTeams.Location = new System.Drawing.Point(404, 50);
            this.labelTeams.Name = "labelTeams";
            this.labelTeams.Size = new System.Drawing.Size(78, 26);
            this.labelTeams.TabIndex = 2;
            this.labelTeams.Text = "Teams";
            // 
            // labelStats
            // 
            this.labelStats.AutoSize = true;
            this.labelStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelStats.Location = new System.Drawing.Point(901, 50);
            this.labelStats.Name = "labelStats";
            this.labelStats.Size = new System.Drawing.Size(251, 26);
            this.labelStats.TabIndex = 4;
            this.labelStats.Text = "Player\'s Matches History";
            // 
            // labelMatches
            // 
            this.labelMatches.AutoSize = true;
            this.labelMatches.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.labelMatches.Location = new System.Drawing.Point(20, 50);
            this.labelMatches.Name = "labelMatches";
            this.labelMatches.Size = new System.Drawing.Size(168, 26);
            this.labelMatches.TabIndex = 6;
            this.labelMatches.Text = "Matches History";
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddTeam.Location = new System.Drawing.Point(409, 421);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(251, 51);
            this.buttonAddTeam.TabIndex = 8;
            this.buttonAddTeam.Text = "Add Team";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            this.buttonAddTeam.Click += new System.EventHandler(this.buttonAddTeam_Click);
            // 
            // buttonDeleteTeam
            // 
            this.buttonDeleteTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteTeam.Location = new System.Drawing.Point(409, 478);
            this.buttonDeleteTeam.Name = "buttonDeleteTeam";
            this.buttonDeleteTeam.Size = new System.Drawing.Size(251, 51);
            this.buttonDeleteTeam.TabIndex = 9;
            this.buttonDeleteTeam.Text = "Delete Team";
            this.buttonDeleteTeam.UseVisualStyleBackColor = true;
            this.buttonDeleteTeam.Click += new System.EventHandler(this.buttonDeleteTeam_Click);
            // 
            // buttonDeletePlayer
            // 
            this.buttonDeletePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeletePlayer.Location = new System.Drawing.Point(666, 478);
            this.buttonDeletePlayer.Name = "buttonDeletePlayer";
            this.buttonDeletePlayer.Size = new System.Drawing.Size(224, 51);
            this.buttonDeletePlayer.TabIndex = 11;
            this.buttonDeletePlayer.Text = "Delete Player";
            this.buttonDeletePlayer.UseVisualStyleBackColor = true;
            this.buttonDeletePlayer.Click += new System.EventHandler(this.buttonDeletePlayer_Click);
            // 
            // buttonAddPlayer
            // 
            this.buttonAddPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddPlayer.Location = new System.Drawing.Point(666, 421);
            this.buttonAddPlayer.Name = "buttonAddPlayer";
            this.buttonAddPlayer.Size = new System.Drawing.Size(224, 51);
            this.buttonAddPlayer.TabIndex = 10;
            this.buttonAddPlayer.Text = "Add Player To Team";
            this.buttonAddPlayer.UseVisualStyleBackColor = true;
            this.buttonAddPlayer.Click += new System.EventHandler(this.buttonAddPlayer_Click);
            // 
            // buttonDeleteStats
            // 
            this.buttonDeleteStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteStats.Location = new System.Drawing.Point(906, 478);
            this.buttonDeleteStats.Name = "buttonDeleteStats";
            this.buttonDeleteStats.Size = new System.Drawing.Size(296, 51);
            this.buttonDeleteStats.TabIndex = 13;
            this.buttonDeleteStats.Text = "Delete Player\'s Stats";
            this.buttonDeleteStats.UseVisualStyleBackColor = true;
            this.buttonDeleteStats.Click += new System.EventHandler(this.buttonDeleteStats_Click);
            // 
            // buttonAddStats
            // 
            this.buttonAddStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddStats.Location = new System.Drawing.Point(906, 421);
            this.buttonAddStats.Name = "buttonAddStats";
            this.buttonAddStats.Size = new System.Drawing.Size(296, 51);
            this.buttonAddStats.TabIndex = 12;
            this.buttonAddStats.Text = "Add Player\'s Stats";
            this.buttonAddStats.UseVisualStyleBackColor = true;
            this.buttonAddStats.Click += new System.EventHandler(this.buttonAddStats_Click);
            // 
            // listViewTeams
            // 
            this.listViewTeams.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.col1,
            this.col2});
            this.listViewTeams.FullRowSelect = true;
            this.listViewTeams.HideSelection = false;
            this.listViewTeams.Location = new System.Drawing.Point(409, 84);
            this.listViewTeams.MultiSelect = false;
            this.listViewTeams.Name = "listViewTeams";
            this.listViewTeams.Size = new System.Drawing.Size(251, 331);
            this.listViewTeams.TabIndex = 15;
            this.listViewTeams.UseCompatibleStateImageBehavior = false;
            this.listViewTeams.View = System.Windows.Forms.View.Details;
            this.listViewTeams.SelectedIndexChanged += new System.EventHandler(this.listViewTeams_SelectedIndexChanged);
            // 
            // col1
            // 
            this.col1.Text = "Name";
            this.col1.Width = 113;
            // 
            // col2
            // 
            this.col2.Text = "Nation";
            this.col2.Width = 94;
            // 
            // listViewPlayers
            // 
            this.listViewPlayers.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader3});
            this.listViewPlayers.HideSelection = false;
            this.listViewPlayers.Location = new System.Drawing.Point(666, 84);
            this.listViewPlayers.MultiSelect = false;
            this.listViewPlayers.Name = "listViewPlayers";
            this.listViewPlayers.Size = new System.Drawing.Size(224, 331);
            this.listViewPlayers.TabIndex = 16;
            this.listViewPlayers.UseCompatibleStateImageBehavior = false;
            this.listViewPlayers.View = System.Windows.Forms.View.Details;
            this.listViewPlayers.SelectedIndexChanged += new System.EventHandler(this.listViewPlayers_SelectedIndexChanged);
            // 
            // columnHeader3
            // 
            this.columnHeader3.Text = "Name";
            this.columnHeader3.Width = 201;
            // 
            // listViewStats
            // 
            this.listViewStats.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader5,
            this.columnHeader6,
            this.columnHeader7});
            this.listViewStats.FullRowSelect = true;
            this.listViewStats.HideSelection = false;
            this.listViewStats.Location = new System.Drawing.Point(906, 84);
            this.listViewStats.MultiSelect = false;
            this.listViewStats.Name = "listViewStats";
            this.listViewStats.Size = new System.Drawing.Size(296, 331);
            this.listViewStats.TabIndex = 17;
            this.listViewStats.UseCompatibleStateImageBehavior = false;
            this.listViewStats.View = System.Windows.Forms.View.Details;
            // 
            // columnHeader4
            // 
            this.columnHeader4.Text = "Opponent";
            this.columnHeader4.Width = 111;
            // 
            // columnHeader5
            // 
            this.columnHeader5.Text = "Kills";
            // 
            // columnHeader6
            // 
            this.columnHeader6.Text = "Deaths";
            // 
            // columnHeader7
            // 
            this.columnHeader7.Text = "Points";
            // 
            // listViewMatches
            // 
            this.listViewMatches.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader8,
            this.columnHeader9,
            this.columnHeader10,
            this.columnHeader1});
            this.listViewMatches.FullRowSelect = true;
            this.listViewMatches.HideSelection = false;
            this.listViewMatches.Location = new System.Drawing.Point(25, 84);
            this.listViewMatches.MultiSelect = false;
            this.listViewMatches.Name = "listViewMatches";
            this.listViewMatches.Size = new System.Drawing.Size(378, 331);
            this.listViewMatches.TabIndex = 18;
            this.listViewMatches.UseCompatibleStateImageBehavior = false;
            this.listViewMatches.View = System.Windows.Forms.View.Details;
            this.listViewMatches.DoubleClick += new System.EventHandler(this.listViewMatches_DoubleClick);
            // 
            // columnHeader8
            // 
            this.columnHeader8.Text = "Team1";
            this.columnHeader8.Width = 95;
            // 
            // columnHeader9
            // 
            this.columnHeader9.Text = "Score";
            this.columnHeader9.Width = 43;
            // 
            // columnHeader10
            // 
            this.columnHeader10.Text = "Team2";
            this.columnHeader10.Width = 78;
            // 
            // columnHeader1
            // 
            this.columnHeader1.Text = "Date";
            this.columnHeader1.Width = 158;
            // 
            // buttonDeleteMatch
            // 
            this.buttonDeleteMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonDeleteMatch.Location = new System.Drawing.Point(25, 478);
            this.buttonDeleteMatch.Name = "buttonDeleteMatch";
            this.buttonDeleteMatch.Size = new System.Drawing.Size(378, 51);
            this.buttonDeleteMatch.TabIndex = 20;
            this.buttonDeleteMatch.Text = "Delete Match";
            this.buttonDeleteMatch.UseVisualStyleBackColor = true;
            this.buttonDeleteMatch.Click += new System.EventHandler(this.buttonDeleteMatch_Click);
            // 
            // buttonAddMatch
            // 
            this.buttonAddMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonAddMatch.Location = new System.Drawing.Point(25, 421);
            this.buttonAddMatch.Name = "buttonAddMatch";
            this.buttonAddMatch.Size = new System.Drawing.Size(378, 51);
            this.buttonAddMatch.TabIndex = 19;
            this.buttonAddMatch.Text = "Add Match";
            this.buttonAddMatch.UseVisualStyleBackColor = true;
            this.buttonAddMatch.Click += new System.EventHandler(this.buttonAddMatch_Click);
            // 
            // buttonRaport
            // 
            this.buttonRaport.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonRaport.Location = new System.Drawing.Point(324, 684);
            this.buttonRaport.Name = "buttonRaport";
            this.buttonRaport.Size = new System.Drawing.Size(612, 84);
            this.buttonRaport.TabIndex = 21;
            this.buttonRaport.Text = "Create Raport";
            this.buttonRaport.UseVisualStyleBackColor = true;
            this.buttonRaport.Click += new System.EventHandler(this.buttonRaport_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(194, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(134, 13);
            this.label1.TabIndex = 22;
            this.label1.Text = "Double Click to view Table";
            // 
            // buttonUpdateMatch
            // 
            this.buttonUpdateMatch.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdateMatch.Location = new System.Drawing.Point(25, 535);
            this.buttonUpdateMatch.Name = "buttonUpdateMatch";
            this.buttonUpdateMatch.Size = new System.Drawing.Size(378, 51);
            this.buttonUpdateMatch.TabIndex = 23;
            this.buttonUpdateMatch.Text = "Update Match";
            this.buttonUpdateMatch.UseVisualStyleBackColor = true;
            this.buttonUpdateMatch.Click += new System.EventHandler(this.buttonUpdateMatch_Click);
            // 
            // buttonUpdateTeam
            // 
            this.buttonUpdateTeam.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdateTeam.Location = new System.Drawing.Point(409, 535);
            this.buttonUpdateTeam.Name = "buttonUpdateTeam";
            this.buttonUpdateTeam.Size = new System.Drawing.Size(251, 51);
            this.buttonUpdateTeam.TabIndex = 24;
            this.buttonUpdateTeam.Text = "Update Team";
            this.buttonUpdateTeam.UseVisualStyleBackColor = true;
            this.buttonUpdateTeam.Click += new System.EventHandler(this.buttonUpdateTeam_Click);
            // 
            // buttonUpdatePlayer
            // 
            this.buttonUpdatePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdatePlayer.Location = new System.Drawing.Point(666, 535);
            this.buttonUpdatePlayer.Name = "buttonUpdatePlayer";
            this.buttonUpdatePlayer.Size = new System.Drawing.Size(224, 51);
            this.buttonUpdatePlayer.TabIndex = 25;
            this.buttonUpdatePlayer.Text = "Update Player";
            this.buttonUpdatePlayer.UseVisualStyleBackColor = true;
            this.buttonUpdatePlayer.Click += new System.EventHandler(this.buttonUpdatePlayer_Click);
            // 
            // buttonUpdateStats
            // 
            this.buttonUpdateStats.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.buttonUpdateStats.Location = new System.Drawing.Point(906, 535);
            this.buttonUpdateStats.Name = "buttonUpdateStats";
            this.buttonUpdateStats.Size = new System.Drawing.Size(296, 51);
            this.buttonUpdateStats.TabIndex = 26;
            this.buttonUpdateStats.Text = "Update Stats";
            this.buttonUpdateStats.UseVisualStyleBackColor = true;
            this.buttonUpdateStats.Click += new System.EventHandler(this.buttonUpdateStats_Click);
            // 
            // CsGoDatabase
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1229, 798);
            this.Controls.Add(this.buttonUpdateStats);
            this.Controls.Add(this.buttonUpdatePlayer);
            this.Controls.Add(this.buttonUpdateTeam);
            this.Controls.Add(this.buttonUpdateMatch);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonRaport);
            this.Controls.Add(this.buttonDeleteMatch);
            this.Controls.Add(this.buttonAddMatch);
            this.Controls.Add(this.listViewMatches);
            this.Controls.Add(this.listViewStats);
            this.Controls.Add(this.listViewPlayers);
            this.Controls.Add(this.listViewTeams);
            this.Controls.Add(this.buttonDeleteStats);
            this.Controls.Add(this.buttonAddStats);
            this.Controls.Add(this.buttonDeletePlayer);
            this.Controls.Add(this.buttonAddPlayer);
            this.Controls.Add(this.buttonDeleteTeam);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.labelMatches);
            this.Controls.Add(this.labelStats);
            this.Controls.Add(this.labelTeams);
            this.Controls.Add(this.labelPlayers);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(3000, 3000);
            this.Name = "CsGoDatabase";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
            this.Text = "CS:GO Database";
            this.Load += new System.EventHandler(this.CsGoDatabase_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelPlayers;
        private System.Windows.Forms.Label labelTeams;
        private System.Windows.Forms.Label labelStats;
        private System.Windows.Forms.Label labelMatches;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonDeleteTeam;
        private System.Windows.Forms.Button buttonDeletePlayer;
        private System.Windows.Forms.Button buttonAddPlayer;
        private System.Windows.Forms.Button buttonDeleteStats;
        private System.Windows.Forms.Button buttonAddStats;
        private System.Windows.Forms.ListView listViewTeams;
        private System.Windows.Forms.ColumnHeader col1;
        private System.Windows.Forms.ColumnHeader col2;
        private System.Windows.Forms.ListView listViewPlayers;
        private System.Windows.Forms.ColumnHeader columnHeader3;
        private System.Windows.Forms.ListView listViewStats;
        private System.Windows.Forms.ColumnHeader columnHeader4;
        private System.Windows.Forms.ColumnHeader columnHeader5;
        private System.Windows.Forms.ColumnHeader columnHeader6;
        private System.Windows.Forms.ColumnHeader columnHeader7;
        private System.Windows.Forms.ListView listViewMatches;
        private System.Windows.Forms.ColumnHeader columnHeader8;
        private System.Windows.Forms.ColumnHeader columnHeader9;
        private System.Windows.Forms.ColumnHeader columnHeader10;
        private System.Windows.Forms.Button buttonDeleteMatch;
        private System.Windows.Forms.Button buttonAddMatch;
        private System.Windows.Forms.ColumnHeader columnHeader1;
        private System.Windows.Forms.Button buttonRaport;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonUpdateMatch;
        private System.Windows.Forms.Button buttonUpdateTeam;
        private System.Windows.Forms.Button buttonUpdatePlayer;
        private System.Windows.Forms.Button buttonUpdateStats;
    }
}

