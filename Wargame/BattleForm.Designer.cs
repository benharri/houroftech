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
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.tabShop = new System.Windows.Forms.TabPage();
            this.VendorShop = new System.Windows.Forms.TabControl();
            this.tabArmor = new System.Windows.Forms.TabPage();
            this.clbVendorArmor = new System.Windows.Forms.CheckedListBox();
            this.tabWeapons = new System.Windows.Forms.TabPage();
            this.clbVendorWeapons = new System.Windows.Forms.CheckedListBox();
            this.button1 = new System.Windows.Forms.Button();
            this.clbInventory = new System.Windows.Forms.CheckedListBox();
            this.labelInventory = new System.Windows.Forms.Label();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.txtTeam2 = new System.Windows.Forms.TextBox();
            this.txtTeam1 = new System.Windows.Forms.TextBox();
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.btnAttack = new System.Windows.Forms.Button();
            this.txtRoundLog = new System.Windows.Forms.TextBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.team1Label = new System.Windows.Forms.Label();
            this.team2Label = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.initiativeLabel = new System.Windows.Forms.Label();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabShop.SuspendLayout();
            this.VendorShop.SuspendLayout();
            this.tabArmor.SuspendLayout();
            this.tabWeapons.SuspendLayout();
            this.tabGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabControlMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabShop
            // 
            this.tabShop.BackColor = System.Drawing.Color.SlateGray;
            this.tabShop.Controls.Add(this.labelInventory);
            this.tabShop.Controls.Add(this.clbInventory);
            this.tabShop.Controls.Add(this.button1);
            this.tabShop.Controls.Add(this.VendorShop);
            this.tabShop.Location = new System.Drawing.Point(4, 22);
            this.tabShop.Name = "tabShop";
            this.tabShop.Padding = new System.Windows.Forms.Padding(3);
            this.tabShop.Size = new System.Drawing.Size(1000, 556);
            this.tabShop.TabIndex = 1;
            this.tabShop.Text = "Vendor";
            // 
            // VendorShop
            // 
            this.VendorShop.Controls.Add(this.tabWeapons);
            this.VendorShop.Controls.Add(this.tabArmor);
            this.VendorShop.Location = new System.Drawing.Point(6, 6);
            this.VendorShop.Name = "VendorShop";
            this.VendorShop.SelectedIndex = 0;
            this.VendorShop.Size = new System.Drawing.Size(513, 495);
            this.VendorShop.TabIndex = 0;
            // 
            // tabArmor
            // 
            this.tabArmor.BackColor = System.Drawing.Color.Black;
            this.tabArmor.Controls.Add(this.clbVendorArmor);
            this.tabArmor.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabArmor.ForeColor = System.Drawing.Color.LimeGreen;
            this.tabArmor.Location = new System.Drawing.Point(4, 22);
            this.tabArmor.Name = "tabArmor";
            this.tabArmor.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmor.Size = new System.Drawing.Size(505, 469);
            this.tabArmor.TabIndex = 1;
            this.tabArmor.Text = "Armor";
            // 
            // clbVendorArmor
            // 
            this.clbVendorArmor.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbVendorArmor.BackColor = System.Drawing.SystemColors.MenuText;
            this.clbVendorArmor.ForeColor = System.Drawing.Color.LimeGreen;
            this.clbVendorArmor.FormattingEnabled = true;
            this.clbVendorArmor.Location = new System.Drawing.Point(0, 1);
            this.clbVendorArmor.Name = "clbVendorArmor";
            this.clbVendorArmor.Size = new System.Drawing.Size(509, 472);
            this.clbVendorArmor.TabIndex = 0;
            this.clbVendorArmor.TabStop = false;
            // 
            // tabWeapons
            // 
            this.tabWeapons.Controls.Add(this.clbVendorWeapons);
            this.tabWeapons.Location = new System.Drawing.Point(4, 22);
            this.tabWeapons.Name = "tabWeapons";
            this.tabWeapons.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeapons.Size = new System.Drawing.Size(505, 469);
            this.tabWeapons.TabIndex = 0;
            this.tabWeapons.Text = "Weapons";
            this.tabWeapons.UseVisualStyleBackColor = true;
            // 
            // clbVendorWeapons
            // 
            this.clbVendorWeapons.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clbVendorWeapons.BackColor = System.Drawing.SystemColors.MenuText;
            this.clbVendorWeapons.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbVendorWeapons.ForeColor = System.Drawing.Color.LimeGreen;
            this.clbVendorWeapons.FormattingEnabled = true;
            this.clbVendorWeapons.Location = new System.Drawing.Point(0, 1);
            this.clbVendorWeapons.Name = "clbVendorWeapons";
            this.clbVendorWeapons.Size = new System.Drawing.Size(511, 472);
            this.clbVendorWeapons.TabIndex = 0;
            this.clbVendorWeapons.TabStop = false;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(169, 507);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.BtnPurchase_Click);
            // 
            // clbInventory
            // 
            this.clbInventory.BackColor = System.Drawing.SystemColors.MenuText;
            this.clbInventory.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clbInventory.ForeColor = System.Drawing.Color.LimeGreen;
            this.clbInventory.FormattingEnabled = true;
            this.clbInventory.Location = new System.Drawing.Point(525, 29);
            this.clbInventory.Name = "clbInventory";
            this.clbInventory.Size = new System.Drawing.Size(470, 472);
            this.clbInventory.TabIndex = 2;
            // 
            // labelInventory
            // 
            this.labelInventory.AutoSize = true;
            this.labelInventory.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelInventory.ForeColor = System.Drawing.Color.GreenYellow;
            this.labelInventory.Location = new System.Drawing.Point(525, 10);
            this.labelInventory.Name = "labelInventory";
            this.labelInventory.Size = new System.Drawing.Size(98, 16);
            this.labelInventory.TabIndex = 3;
            this.labelInventory.Text = "Inventory";
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
            this.tabGame.Controls.Add(this.txtTeam1);
            this.tabGame.Controls.Add(this.txtTeam2);
            this.tabGame.Controls.Add(this.txtLog);
            this.tabGame.Controls.Add(this.btnAttack);
            this.tabGame.Controls.Add(this.btnCreateGame);
            this.tabGame.Location = new System.Drawing.Point(4, 22);
            this.tabGame.Margin = new System.Windows.Forms.Padding(0);
            this.tabGame.Name = "tabGame";
            this.tabGame.Size = new System.Drawing.Size(1000, 556);
            this.tabGame.TabIndex = 0;
            this.tabGame.Text = "Game";
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
            this.txtLog.Location = new System.Drawing.Point(6, 337);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(808, 214);
            this.txtLog.TabIndex = 1;
            // 
            // txtTeam2
            // 
            this.txtTeam2.BackColor = System.Drawing.Color.Black;
            this.txtTeam2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeam2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam2.ForeColor = System.Drawing.Color.Lime;
            this.txtTeam2.Location = new System.Drawing.Point(629, 122);
            this.txtTeam2.Multiline = true;
            this.txtTeam2.Name = "txtTeam2";
            this.txtTeam2.Size = new System.Drawing.Size(369, 187);
            this.txtTeam2.TabIndex = 4;
            this.txtTeam2.TabStop = false;
            // 
            // txtTeam1
            // 
            this.txtTeam1.BackColor = System.Drawing.Color.Black;
            this.txtTeam1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeam1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam1.ForeColor = System.Drawing.Color.Lime;
            this.txtTeam1.Location = new System.Drawing.Point(6, 122);
            this.txtTeam1.Multiline = true;
            this.txtTeam1.Name = "txtTeam1";
            this.txtTeam1.Size = new System.Drawing.Size(371, 187);
            this.txtTeam1.TabIndex = 3;
            this.txtTeam1.TabStop = false;
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnCreateGame.BackColor = System.Drawing.Color.Olive;
            this.btnCreateGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCreateGame.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGame.Location = new System.Drawing.Point(890, 3);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(105, 36);
            this.btnCreateGame.TabIndex = 0;
            this.btnCreateGame.Text = "New Game";
            this.btnCreateGame.UseVisualStyleBackColor = false;
            this.btnCreateGame.Click += new System.EventHandler(this.BtnCreateGame_Click);
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
            this.btnAttack.Location = new System.Drawing.Point(819, 467);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(176, 83);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.toolTip1.SetToolTip(this.btnAttack, "Press \'Attack\' button to inflict damage against enemy team");
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.BtnAttack_Click);
            // 
            // txtRoundLog
            // 
            this.txtRoundLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtRoundLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoundLog.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoundLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtRoundLog.Location = new System.Drawing.Point(382, 122);
            this.txtRoundLog.Multiline = true;
            this.txtRoundLog.Name = "txtRoundLog";
            this.txtRoundLog.Size = new System.Drawing.Size(242, 187);
            this.txtRoundLog.TabIndex = 5;
            this.txtRoundLog.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wargame.Properties.Resources.wargame;
            this.pictureBox1.Location = new System.Drawing.Point(6, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(273, 96);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // team1Label
            // 
            this.team1Label.AutoSize = true;
            this.team1Label.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Label.ForeColor = System.Drawing.Color.Lime;
            this.team1Label.Location = new System.Drawing.Point(5, 103);
            this.team1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(68, 16);
            this.team1Label.TabIndex = 7;
            this.team1Label.Text = "Team 1";
            // 
            // team2Label
            // 
            this.team2Label.AutoSize = true;
            this.team2Label.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Label.ForeColor = System.Drawing.Color.Lime;
            this.team2Label.Location = new System.Drawing.Point(627, 103);
            this.team2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.team2Label.Name = "team2Label";
            this.team2Label.Size = new System.Drawing.Size(68, 16);
            this.team2Label.TabIndex = 8;
            this.team2Label.Text = "Team 2";
            // 
            // roundLabel
            // 
            this.roundLabel.AutoSize = true;
            this.roundLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.roundLabel.ForeColor = System.Drawing.Color.Lime;
            this.roundLabel.Location = new System.Drawing.Point(5, 318);
            this.roundLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.roundLabel.Name = "roundLabel";
            this.roundLabel.Size = new System.Drawing.Size(158, 16);
            this.roundLabel.TabIndex = 9;
            this.roundLabel.Text = "No Game Started";
            // 
            // initiativeLabel
            // 
            this.initiativeLabel.AutoSize = true;
            this.initiativeLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initiativeLabel.ForeColor = System.Drawing.Color.Lime;
            this.initiativeLabel.Location = new System.Drawing.Point(379, 103);
            this.initiativeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.initiativeLabel.Name = "initiativeLabel";
            this.initiativeLabel.Size = new System.Drawing.Size(108, 16);
            this.initiativeLabel.TabIndex = 10;
            this.initiativeLabel.Text = "Initiative";
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
            this.tabControlMain.Size = new System.Drawing.Size(1008, 582);
            this.tabControlMain.TabIndex = 5;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1007, 579);
            this.Controls.Add(this.tabControlMain);
            this.Name = "BattleForm";
            this.Text = "Wargame";
            this.tabShop.ResumeLayout(false);
            this.tabShop.PerformLayout();
            this.VendorShop.ResumeLayout(false);
            this.tabArmor.ResumeLayout(false);
            this.tabWeapons.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabControlMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabShop;
        private System.Windows.Forms.Label labelInventory;
        private System.Windows.Forms.CheckedListBox clbInventory;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TabControl VendorShop;
        private System.Windows.Forms.TabPage tabWeapons;
        private System.Windows.Forms.CheckedListBox clbVendorWeapons;
        private System.Windows.Forms.TabPage tabArmor;
        private System.Windows.Forms.CheckedListBox clbVendorArmor;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.Label initiativeLabel;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label team2Label;
        private System.Windows.Forms.Label team1Label;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtRoundLog;
        private System.Windows.Forms.TextBox txtTeam1;
        private System.Windows.Forms.TextBox txtTeam2;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnAttack;
        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.TabControl tabControlMain;
    }
}

