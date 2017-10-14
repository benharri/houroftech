namespace Wargame
{
    partial class BattleForm
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
            this.components = new System.ComponentModel.Container();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.txtTeam1 = new System.Windows.Forms.TextBox();
            this.txtTeam2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.initiativeLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.team2Label = new System.Windows.Forms.Label();
            this.team1Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRoundLog = new System.Windows.Forms.TextBox();
            this.tabShop = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlShop = new System.Windows.Forms.TabControl();
            this.tabWeapons = new System.Windows.Forms.TabPage();
            this.tabArmor = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabShop.SuspendLayout();
            this.tabControlShop.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateGame.BackColor = System.Drawing.Color.Olive;
            this.btnCreateGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGame.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGame.Location = new System.Drawing.Point(1335, 5);
            this.btnCreateGame.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(158, 55);
            this.btnCreateGame.TabIndex = 0;
            this.btnCreateGame.Text = "New Game";
            this.btnCreateGame.UseVisualStyleBackColor = false;
            this.btnCreateGame.Click += new System.EventHandler(this.BtnCreateGame_Click);
            // 
            // txtLog
            // 
            this.txtLog.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtLog.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.Lime;
            this.txtLog.Location = new System.Drawing.Point(9, 518);
            this.txtLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(1212, 329);
            this.txtLog.TabIndex = 1;
            // 
            // btnAttack
            // 
            this.btnAttack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAttack.AutoSize = true;
            this.btnAttack.BackColor = System.Drawing.Color.Maroon;
            this.btnAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAttack.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAttack.Location = new System.Drawing.Point(1229, 719);
            this.btnAttack.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(264, 128);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.toolTip1.SetToolTip(this.btnAttack, "Press \'Attack\' button to inflict damage against enemy team");
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.BtnAttack_Click);
            // 
            // txtTeam1
            // 
            this.txtTeam1.BackColor = System.Drawing.Color.Black;
            this.txtTeam1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeam1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam1.ForeColor = System.Drawing.Color.Lime;
            this.txtTeam1.Location = new System.Drawing.Point(9, 188);
            this.txtTeam1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTeam1.Multiline = true;
            this.txtTeam1.Name = "txtTeam1";
            this.txtTeam1.Size = new System.Drawing.Size(556, 288);
            this.txtTeam1.TabIndex = 3;
            this.txtTeam1.TabStop = false;
            // 
            // txtTeam2
            // 
            this.txtTeam2.BackColor = System.Drawing.Color.Black;
            this.txtTeam2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeam2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam2.ForeColor = System.Drawing.Color.Lime;
            this.txtTeam2.Location = new System.Drawing.Point(944, 188);
            this.txtTeam2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtTeam2.Multiline = true;
            this.txtTeam2.Name = "txtTeam2";
            this.txtTeam2.Size = new System.Drawing.Size(553, 288);
            this.txtTeam2.TabIndex = 4;
            this.txtTeam2.TabStop = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tabControlMain.Controls.Add(this.tabGame);
            this.tabControlMain.Controls.Add(this.tabShop);
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.Padding = new System.Drawing.Point(0, 0);
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1512, 896);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabGame
            // 
            this.tabGame.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabGame.Controls.Add(this.initiativeLabel);
            this.tabGame.Controls.Add(this.roundLabel);
            this.tabGame.Controls.Add(this.team2Label);
            this.tabGame.Controls.Add(this.team1Label);
            this.tabGame.Controls.Add(this.pictureBox1);
            this.tabGame.Controls.Add(this.txtRoundLog);
            this.tabGame.Controls.Add(this.btnAttack);
            this.tabGame.Controls.Add(this.btnCreateGame);
            this.tabGame.Controls.Add(this.txtTeam1);
            this.tabGame.Controls.Add(this.txtTeam2);
            this.tabGame.Controls.Add(this.txtLog);
            this.tabGame.Location = new System.Drawing.Point(4, 29);
            this.tabGame.Margin = new System.Windows.Forms.Padding(0);
            this.tabGame.Name = "tabGame";
            this.tabGame.Size = new System.Drawing.Size(1504, 863);
            this.tabGame.TabIndex = 0;
            this.tabGame.Text = "Game";
            // 
            // initiativeLabel
            // 
            this.initiativeLabel.AutoSize = true;
            this.initiativeLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initiativeLabel.ForeColor = System.Drawing.Color.Lime;
            this.initiativeLabel.Location = new System.Drawing.Point(569, 158);
            this.initiativeLabel.Name = "initiativeLabel";
            this.initiativeLabel.Size = new System.Drawing.Size(150, 24);
            this.initiativeLabel.TabIndex = 10;
            this.initiativeLabel.Text = "Initiative";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.Lime;
            this.roundLabel.Location = new System.Drawing.Point(8, 489);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(220, 24);
            this.roundLabel.TabIndex = 9;
            this.roundLabel.Text = "No Game Started";
            // 
            // team2Label
            // 
            this.team2Label.AutoSize = true;
            this.team2Label.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Label.ForeColor = System.Drawing.Color.Lime;
            this.team2Label.Location = new System.Drawing.Point(940, 158);
            this.team2Label.Name = "team2Label";
            this.team2Label.Size = new System.Drawing.Size(94, 24);
            this.team2Label.TabIndex = 8;
            this.team2Label.Text = "Team 2";
            // 
            // team1Label
            // 
            this.team1Label.AutoSize = true;
            this.team1Label.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Label.ForeColor = System.Drawing.Color.Lime;
            this.team1Label.Location = new System.Drawing.Point(8, 158);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(94, 24);
            this.team1Label.TabIndex = 7;
            this.team1Label.Text = "Team 1";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wargame.Properties.Resources.wargame;
            this.pictureBox1.Location = new System.Drawing.Point(9, 5);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // txtRoundLog
            // 
            this.txtRoundLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtRoundLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoundLog.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoundLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtRoundLog.Location = new System.Drawing.Point(573, 188);
            this.txtRoundLog.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtRoundLog.Multiline = true;
            this.txtRoundLog.Name = "txtRoundLog";
            this.txtRoundLog.Size = new System.Drawing.Size(363, 288);
            this.txtRoundLog.TabIndex = 5;
            this.txtRoundLog.TabStop = false;
            // 
            // tabShop
            // 
            this.tabShop.BackColor = System.Drawing.Color.SlateGray;
            this.tabShop.Controls.Add(this.textBox1);
            this.tabShop.Controls.Add(this.button1);
            this.tabShop.Controls.Add(this.tabControlShop);
            this.tabShop.Location = new System.Drawing.Point(4, 29);
            this.tabShop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabShop.Name = "tabShop";
            this.tabShop.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabShop.Size = new System.Drawing.Size(1508, 760);
            this.tabShop.TabIndex = 1;
            this.tabShop.Text = "Shop";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox1.Location = new System.Drawing.Point(886, 209);
            this.textBox1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(436, 492);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(222, 755);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 71);
            this.button1.TabIndex = 1;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabControlShop
            // 
            this.tabControlShop.Controls.Add(this.tabWeapons);
            this.tabControlShop.Controls.Add(this.tabArmor);
            this.tabControlShop.Location = new System.Drawing.Point(45, 175);
            this.tabControlShop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabControlShop.Name = "tabControlShop";
            this.tabControlShop.SelectedIndex = 0;
            this.tabControlShop.Size = new System.Drawing.Size(618, 528);
            this.tabControlShop.TabIndex = 0;
            // 
            // tabWeapons
            // 
            this.tabWeapons.Location = new System.Drawing.Point(4, 29);
            this.tabWeapons.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabWeapons.Name = "tabWeapons";
            this.tabWeapons.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabWeapons.Size = new System.Drawing.Size(610, 495);
            this.tabWeapons.TabIndex = 0;
            this.tabWeapons.Text = "Weapons";
            this.tabWeapons.UseVisualStyleBackColor = true;
            // 
            // tabArmor
            // 
            this.tabArmor.Location = new System.Drawing.Point(4, 29);
            this.tabArmor.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabArmor.Name = "tabArmor";
            this.tabArmor.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.tabArmor.Size = new System.Drawing.Size(610, 495);
            this.tabArmor.TabIndex = 1;
            this.tabArmor.Text = "Armor";
            this.tabArmor.UseVisualStyleBackColor = true;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1510, 891);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "BattleForm";
            this.Text = "Wargame";
            this.tabControlMain.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabShop.ResumeLayout(false);
            this.tabShop.PerformLayout();
            this.tabControlShop.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.TextBox txtTeam1;
        private System.Windows.Forms.TextBox txtTeam2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.TabPage tabShop;
        private System.Windows.Forms.TabControl tabControlShop;
        private System.Windows.Forms.TabPage tabWeapons;
        private System.Windows.Forms.TabPage tabArmor;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRoundLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label team1Label;
        private System.Windows.Forms.Label team2Label;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label initiativeLabel;
    }
}

