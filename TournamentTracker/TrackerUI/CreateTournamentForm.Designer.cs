namespace TrackerUI
{
    partial class CreateTournamentForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CreateTournamentForm));
            this.labelCreateTournament = new System.Windows.Forms.Label();
            this.textboxTournamentNameValue = new System.Windows.Forms.TextBox();
            this.labelTournamentName = new System.Windows.Forms.Label();
            this.textboxEntryFee = new System.Windows.Forms.TextBox();
            this.labelEntryFee = new System.Windows.Forms.Label();
            this.selectTeamDropDown = new System.Windows.Forms.ComboBox();
            this.labelSelectTeam = new System.Windows.Forms.Label();
            this.createNewTeamLink = new System.Windows.Forms.LinkLabel();
            this.buttonAddTeam = new System.Windows.Forms.Button();
            this.buttonCreateTournament = new System.Windows.Forms.Button();
            this.lisitboxTournamentPlayers = new System.Windows.Forms.ListBox();
            this.labelTournamentPlayers = new System.Windows.Forms.Label();
            this.buttonDeleteSelectedPlayer = new System.Windows.Forms.Button();
            this.buttonDeleteSelectedPrize = new System.Windows.Forms.Button();
            this.listboxPrizes = new System.Windows.Forms.ListBox();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelCreateTournament
            // 
            this.labelCreateTournament.AutoSize = true;
            this.labelCreateTournament.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelCreateTournament.Location = new System.Drawing.Point(12, 9);
            this.labelCreateTournament.Name = "labelCreateTournament";
            this.labelCreateTournament.Size = new System.Drawing.Size(298, 50);
            this.labelCreateTournament.TabIndex = 1;
            this.labelCreateTournament.Text = "Creat Tournament";
            // 
            // textboxTournamentNameValue
            // 
            this.textboxTournamentNameValue.Location = new System.Drawing.Point(21, 109);
            this.textboxTournamentNameValue.Name = "textboxTournamentNameValue";
            this.textboxTournamentNameValue.Size = new System.Drawing.Size(315, 35);
            this.textboxTournamentNameValue.TabIndex = 7;
            // 
            // labelTournamentName
            // 
            this.labelTournamentName.AutoSize = true;
            this.labelTournamentName.BackColor = System.Drawing.Color.Transparent;
            this.labelTournamentName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournamentName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTournamentName.Location = new System.Drawing.Point(15, 74);
            this.labelTournamentName.Name = "labelTournamentName";
            this.labelTournamentName.Size = new System.Drawing.Size(217, 32);
            this.labelTournamentName.TabIndex = 6;
            this.labelTournamentName.Text = "Tournament Name";
            // 
            // textboxEntryFee
            // 
            this.textboxEntryFee.Location = new System.Drawing.Point(135, 174);
            this.textboxEntryFee.Name = "textboxEntryFee";
            this.textboxEntryFee.Size = new System.Drawing.Size(100, 35);
            this.textboxEntryFee.TabIndex = 9;
            this.textboxEntryFee.Text = "0";
            // 
            // labelEntryFee
            // 
            this.labelEntryFee.AutoSize = true;
            this.labelEntryFee.BackColor = System.Drawing.Color.Transparent;
            this.labelEntryFee.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelEntryFee.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelEntryFee.Location = new System.Drawing.Point(15, 177);
            this.labelEntryFee.Name = "labelEntryFee";
            this.labelEntryFee.Size = new System.Drawing.Size(114, 32);
            this.labelEntryFee.TabIndex = 8;
            this.labelEntryFee.Text = "Entry Fee";
            // 
            // selectTeamDropDown
            // 
            this.selectTeamDropDown.FormattingEnabled = true;
            this.selectTeamDropDown.Location = new System.Drawing.Point(21, 317);
            this.selectTeamDropDown.Name = "selectTeamDropDown";
            this.selectTeamDropDown.Size = new System.Drawing.Size(315, 38);
            this.selectTeamDropDown.TabIndex = 11;
            // 
            // labelSelectTeam
            // 
            this.labelSelectTeam.AutoSize = true;
            this.labelSelectTeam.BackColor = System.Drawing.Color.Transparent;
            this.labelSelectTeam.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelSelectTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelSelectTeam.Location = new System.Drawing.Point(15, 282);
            this.labelSelectTeam.Name = "labelSelectTeam";
            this.labelSelectTeam.Size = new System.Drawing.Size(145, 32);
            this.labelSelectTeam.TabIndex = 10;
            this.labelSelectTeam.Text = "Select Team";
            // 
            // createNewTeamLink
            // 
            this.createNewTeamLink.ActiveLinkColor = System.Drawing.Color.MediumSpringGreen;
            this.createNewTeamLink.AutoSize = true;
            this.createNewTeamLink.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createNewTeamLink.LinkColor = System.Drawing.Color.DarkSlateGray;
            this.createNewTeamLink.Location = new System.Drawing.Point(246, 293);
            this.createNewTeamLink.Name = "createNewTeamLink";
            this.createNewTeamLink.Size = new System.Drawing.Size(90, 21);
            this.createNewTeamLink.TabIndex = 12;
            this.createNewTeamLink.TabStop = true;
            this.createNewTeamLink.Text = "create new";
            // 
            // buttonAddTeam
            // 
            this.buttonAddTeam.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonAddTeam.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonAddTeam.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonAddTeam.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonAddTeam.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonAddTeam.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonAddTeam.Location = new System.Drawing.Point(96, 370);
            this.buttonAddTeam.Name = "buttonAddTeam";
            this.buttonAddTeam.Size = new System.Drawing.Size(157, 40);
            this.buttonAddTeam.TabIndex = 13;
            this.buttonAddTeam.Text = "Add Team";
            this.buttonAddTeam.UseVisualStyleBackColor = true;
            // 
            // buttonCreateTournament
            // 
            this.buttonCreateTournament.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonCreateTournament.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonCreateTournament.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonCreateTournament.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonCreateTournament.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonCreateTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonCreateTournament.Location = new System.Drawing.Point(250, 599);
            this.buttonCreateTournament.Name = "buttonCreateTournament";
            this.buttonCreateTournament.Size = new System.Drawing.Size(245, 56);
            this.buttonCreateTournament.TabIndex = 13;
            this.buttonCreateTournament.Text = "Create Tournament";
            this.buttonCreateTournament.UseVisualStyleBackColor = true;
            // 
            // lisitboxTournamentPlayers
            // 
            this.lisitboxTournamentPlayers.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lisitboxTournamentPlayers.FormattingEnabled = true;
            this.lisitboxTournamentPlayers.ItemHeight = 30;
            this.lisitboxTournamentPlayers.Location = new System.Drawing.Point(411, 112);
            this.lisitboxTournamentPlayers.Name = "lisitboxTournamentPlayers";
            this.lisitboxTournamentPlayers.Size = new System.Drawing.Size(341, 182);
            this.lisitboxTournamentPlayers.TabIndex = 14;
            // 
            // labelTournamentPlayers
            // 
            this.labelTournamentPlayers.AutoSize = true;
            this.labelTournamentPlayers.BackColor = System.Drawing.Color.Transparent;
            this.labelTournamentPlayers.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournamentPlayers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTournamentPlayers.Location = new System.Drawing.Point(405, 74);
            this.labelTournamentPlayers.Name = "labelTournamentPlayers";
            this.labelTournamentPlayers.Size = new System.Drawing.Size(181, 32);
            this.labelTournamentPlayers.TabIndex = 6;
            this.labelTournamentPlayers.Text = "Teams / Players";
            // 
            // buttonDeleteSelectedPlayer
            // 
            this.buttonDeleteSelectedPlayer.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonDeleteSelectedPlayer.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonDeleteSelectedPlayer.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonDeleteSelectedPlayer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSelectedPlayer.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSelectedPlayer.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonDeleteSelectedPlayer.Location = new System.Drawing.Point(770, 174);
            this.buttonDeleteSelectedPlayer.Name = "buttonDeleteSelectedPlayer";
            this.buttonDeleteSelectedPlayer.Size = new System.Drawing.Size(106, 75);
            this.buttonDeleteSelectedPlayer.TabIndex = 15;
            this.buttonDeleteSelectedPlayer.Text = "Delete Selected";
            this.buttonDeleteSelectedPlayer.UseVisualStyleBackColor = true;
            // 
            // buttonDeleteSelectedPrize
            // 
            this.buttonDeleteSelectedPrize.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonDeleteSelectedPrize.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonDeleteSelectedPrize.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonDeleteSelectedPrize.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonDeleteSelectedPrize.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonDeleteSelectedPrize.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonDeleteSelectedPrize.Location = new System.Drawing.Point(770, 411);
            this.buttonDeleteSelectedPrize.Name = "buttonDeleteSelectedPrize";
            this.buttonDeleteSelectedPrize.Size = new System.Drawing.Size(106, 75);
            this.buttonDeleteSelectedPrize.TabIndex = 18;
            this.buttonDeleteSelectedPrize.Text = "Delete Selected";
            this.buttonDeleteSelectedPrize.UseVisualStyleBackColor = true;
            // 
            // listboxPrizes
            // 
            this.listboxPrizes.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.listboxPrizes.FormattingEnabled = true;
            this.listboxPrizes.ItemHeight = 30;
            this.listboxPrizes.Location = new System.Drawing.Point(411, 355);
            this.listboxPrizes.Name = "listboxPrizes";
            this.listboxPrizes.Size = new System.Drawing.Size(341, 182);
            this.listboxPrizes.TabIndex = 17;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.label1.Location = new System.Drawing.Point(405, 316);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(181, 32);
            this.label1.TabIndex = 16;
            this.label1.Text = "Teams / Players";
            // 
            // CreateTournamentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(893, 667);
            this.Controls.Add(this.buttonDeleteSelectedPrize);
            this.Controls.Add(this.listboxPrizes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonDeleteSelectedPlayer);
            this.Controls.Add(this.lisitboxTournamentPlayers);
            this.Controls.Add(this.buttonCreateTournament);
            this.Controls.Add(this.buttonAddTeam);
            this.Controls.Add(this.createNewTeamLink);
            this.Controls.Add(this.selectTeamDropDown);
            this.Controls.Add(this.labelSelectTeam);
            this.Controls.Add(this.textboxEntryFee);
            this.Controls.Add(this.labelEntryFee);
            this.Controls.Add(this.textboxTournamentNameValue);
            this.Controls.Add(this.labelTournamentPlayers);
            this.Controls.Add(this.labelTournamentName);
            this.Controls.Add(this.labelCreateTournament);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "CreateTournamentForm";
            this.Text = "Create Tournament";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelCreateTournament;
        private System.Windows.Forms.TextBox textboxTournamentNameValue;
        private System.Windows.Forms.Label labelTournamentName;
        private System.Windows.Forms.TextBox textboxEntryFee;
        private System.Windows.Forms.Label labelEntryFee;
        private System.Windows.Forms.ComboBox selectTeamDropDown;
        private System.Windows.Forms.Label labelSelectTeam;
        private System.Windows.Forms.LinkLabel createNewTeamLink;
        private System.Windows.Forms.Button buttonAddTeam;
        private System.Windows.Forms.Button buttonCreateTournament;
        private System.Windows.Forms.ListBox lisitboxTournamentPlayers;
        private System.Windows.Forms.Label labelTournamentPlayers;
        private System.Windows.Forms.Button buttonDeleteSelectedPlayer;
        private System.Windows.Forms.Button buttonDeleteSelectedPrize;
        private System.Windows.Forms.ListBox listboxPrizes;
        private System.Windows.Forms.Label label1;
    }
}