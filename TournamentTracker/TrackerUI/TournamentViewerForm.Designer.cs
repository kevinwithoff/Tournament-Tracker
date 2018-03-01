namespace TrackerUI
{
    partial class TournamentViewerForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(TournamentViewerForm));
            this.labelTournament = new System.Windows.Forms.Label();
            this.labelNone = new System.Windows.Forms.Label();
            this.labelRound = new System.Windows.Forms.Label();
            this.roundDropDown = new System.Windows.Forms.ComboBox();
            this.checkBoxUnplayedOnly = new System.Windows.Forms.CheckBox();
            this.lisitboxMatchup = new System.Windows.Forms.ListBox();
            this.teamOneName = new System.Windows.Forms.Label();
            this.labelTeamOneScore = new System.Windows.Forms.Label();
            this.textboxTeamOneScore = new System.Windows.Forms.TextBox();
            this.teamTwoName = new System.Windows.Forms.Label();
            this.labelTeamTwoScore = new System.Windows.Forms.Label();
            this.textboxTeamTwoScore = new System.Windows.Forms.TextBox();
            this.labelVersus = new System.Windows.Forms.Label();
            this.buttonScore = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // labelTournament
            // 
            this.labelTournament.AutoSize = true;
            this.labelTournament.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTournament.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTournament.Location = new System.Drawing.Point(12, 9);
            this.labelTournament.Name = "labelTournament";
            this.labelTournament.Size = new System.Drawing.Size(214, 50);
            this.labelTournament.TabIndex = 0;
            this.labelTournament.Text = "Tournament:";
            // 
            // labelNone
            // 
            this.labelNone.AutoSize = true;
            this.labelNone.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelNone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelNone.Location = new System.Drawing.Point(232, 9);
            this.labelNone.Name = "labelNone";
            this.labelNone.Size = new System.Drawing.Size(150, 50);
            this.labelNone.TabIndex = 0;
            this.labelNone.Text = "<none>";
            // 
            // labelRound
            // 
            this.labelRound.AutoSize = true;
            this.labelRound.BackColor = System.Drawing.Color.Transparent;
            this.labelRound.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelRound.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelRound.Location = new System.Drawing.Point(14, 76);
            this.labelRound.Name = "labelRound";
            this.labelRound.Size = new System.Drawing.Size(85, 32);
            this.labelRound.TabIndex = 1;
            this.labelRound.Text = "Round";
            // 
            // roundDropDown
            // 
            this.roundDropDown.FormattingEnabled = true;
            this.roundDropDown.Location = new System.Drawing.Point(115, 75);
            this.roundDropDown.Name = "roundDropDown";
            this.roundDropDown.Size = new System.Drawing.Size(267, 38);
            this.roundDropDown.TabIndex = 2;
            // 
            // checkBoxUnplayedOnly
            // 
            this.checkBoxUnplayedOnly.AutoSize = true;
            this.checkBoxUnplayedOnly.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.checkBoxUnplayedOnly.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxUnplayedOnly.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.checkBoxUnplayedOnly.Location = new System.Drawing.Point(115, 119);
            this.checkBoxUnplayedOnly.Name = "checkBoxUnplayedOnly";
            this.checkBoxUnplayedOnly.Size = new System.Drawing.Size(189, 36);
            this.checkBoxUnplayedOnly.TabIndex = 3;
            this.checkBoxUnplayedOnly.Text = "Unplayed Only";
            this.checkBoxUnplayedOnly.UseVisualStyleBackColor = true;
            // 
            // lisitboxMatchup
            // 
            this.lisitboxMatchup.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lisitboxMatchup.FormattingEnabled = true;
            this.lisitboxMatchup.ItemHeight = 30;
            this.lisitboxMatchup.Location = new System.Drawing.Point(21, 186);
            this.lisitboxMatchup.Name = "lisitboxMatchup";
            this.lisitboxMatchup.Size = new System.Drawing.Size(361, 332);
            this.lisitboxMatchup.TabIndex = 4;
            // 
            // teamOneName
            // 
            this.teamOneName.AutoSize = true;
            this.teamOneName.BackColor = System.Drawing.Color.Transparent;
            this.teamOneName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamOneName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamOneName.Location = new System.Drawing.Point(437, 186);
            this.teamOneName.Name = "teamOneName";
            this.teamOneName.Size = new System.Drawing.Size(149, 32);
            this.teamOneName.TabIndex = 1;
            this.teamOneName.Text = "<team one>";
            // 
            // labelTeamOneScore
            // 
            this.labelTeamOneScore.AutoSize = true;
            this.labelTeamOneScore.BackColor = System.Drawing.Color.Transparent;
            this.labelTeamOneScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamOneScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamOneScore.Location = new System.Drawing.Point(437, 236);
            this.labelTeamOneScore.Name = "labelTeamOneScore";
            this.labelTeamOneScore.Size = new System.Drawing.Size(74, 32);
            this.labelTeamOneScore.TabIndex = 1;
            this.labelTeamOneScore.Text = "Score";
            // 
            // textboxTeamOneScore
            // 
            this.textboxTeamOneScore.Location = new System.Drawing.Point(517, 236);
            this.textboxTeamOneScore.Name = "textboxTeamOneScore";
            this.textboxTeamOneScore.Size = new System.Drawing.Size(100, 35);
            this.textboxTeamOneScore.TabIndex = 5;
            // 
            // teamTwoName
            // 
            this.teamTwoName.AutoSize = true;
            this.teamTwoName.BackColor = System.Drawing.Color.Transparent;
            this.teamTwoName.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.teamTwoName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.teamTwoName.Location = new System.Drawing.Point(437, 405);
            this.teamTwoName.Name = "teamTwoName";
            this.teamTwoName.Size = new System.Drawing.Size(149, 32);
            this.teamTwoName.TabIndex = 1;
            this.teamTwoName.Text = "<team one>";
            // 
            // labelTeamTwoScore
            // 
            this.labelTeamTwoScore.AutoSize = true;
            this.labelTeamTwoScore.BackColor = System.Drawing.Color.Transparent;
            this.labelTeamTwoScore.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTeamTwoScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelTeamTwoScore.Location = new System.Drawing.Point(437, 455);
            this.labelTeamTwoScore.Name = "labelTeamTwoScore";
            this.labelTeamTwoScore.Size = new System.Drawing.Size(74, 32);
            this.labelTeamTwoScore.TabIndex = 1;
            this.labelTeamTwoScore.Text = "Score";
            // 
            // textboxTeamTwoScore
            // 
            this.textboxTeamTwoScore.Location = new System.Drawing.Point(517, 455);
            this.textboxTeamTwoScore.Name = "textboxTeamTwoScore";
            this.textboxTeamTwoScore.Size = new System.Drawing.Size(100, 35);
            this.textboxTeamTwoScore.TabIndex = 5;
            // 
            // labelVersus
            // 
            this.labelVersus.AutoSize = true;
            this.labelVersus.BackColor = System.Drawing.Color.Transparent;
            this.labelVersus.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelVersus.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.labelVersus.Location = new System.Drawing.Point(511, 324);
            this.labelVersus.Name = "labelVersus";
            this.labelVersus.Size = new System.Drawing.Size(63, 32);
            this.labelVersus.TabIndex = 1;
            this.labelVersus.Text = "-VS-";
            // 
            // buttonScore
            // 
            this.buttonScore.FlatAppearance.BorderColor = System.Drawing.Color.Silver;
            this.buttonScore.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(102)))));
            this.buttonScore.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.buttonScore.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonScore.Font = new System.Drawing.Font("Segoe UI Semibold", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonScore.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(153)))), ((int)(((byte)(255)))));
            this.buttonScore.Location = new System.Drawing.Point(672, 315);
            this.buttonScore.Name = "buttonScore";
            this.buttonScore.Size = new System.Drawing.Size(106, 52);
            this.buttonScore.TabIndex = 6;
            this.buttonScore.Text = "Score";
            this.buttonScore.UseVisualStyleBackColor = true;
            // 
            // TournamentViewerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 30F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(802, 534);
            this.Controls.Add(this.buttonScore);
            this.Controls.Add(this.textboxTeamTwoScore);
            this.Controls.Add(this.textboxTeamOneScore);
            this.Controls.Add(this.lisitboxMatchup);
            this.Controls.Add(this.checkBoxUnplayedOnly);
            this.Controls.Add(this.roundDropDown);
            this.Controls.Add(this.labelTeamTwoScore);
            this.Controls.Add(this.labelTeamOneScore);
            this.Controls.Add(this.teamTwoName);
            this.Controls.Add(this.labelVersus);
            this.Controls.Add(this.teamOneName);
            this.Controls.Add(this.labelRound);
            this.Controls.Add(this.labelNone);
            this.Controls.Add(this.labelTournament);
            this.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(6, 7, 6, 7);
            this.Name = "TournamentViewerForm";
            this.Text = "Tournament Viewer";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTournament;
        private System.Windows.Forms.Label labelNone;
        private System.Windows.Forms.Label labelRound;
        private System.Windows.Forms.ComboBox roundDropDown;
        private System.Windows.Forms.CheckBox checkBoxUnplayedOnly;
        private System.Windows.Forms.ListBox lisitboxMatchup;
        private System.Windows.Forms.Label teamOneName;
        private System.Windows.Forms.Label labelTeamOneScore;
        private System.Windows.Forms.TextBox textboxTeamOneScore;
        private System.Windows.Forms.Label teamTwoName;
        private System.Windows.Forms.Label labelTeamTwoScore;
        private System.Windows.Forms.TextBox textboxTeamTwoScore;
        private System.Windows.Forms.Label labelVersus;
        private System.Windows.Forms.Button buttonScore;
    }
}

