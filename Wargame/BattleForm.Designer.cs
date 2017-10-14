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
            this.txtRoundLog = new System.Windows.Forms.TextBox();
            this.tabShop = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.tabControlShop = new System.Windows.Forms.TabControl();
            this.tabWeapons = new System.Windows.Forms.TabPage();
            this.tabArmor = new System.Windows.Forms.TabPage();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tabControlMain.SuspendLayout();
            this.tabGame.SuspendLayout();
            this.tabShop.SuspendLayout();
            this.tabControlShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.BackColor = System.Drawing.Color.Olive;
            this.btnCreateGame.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCreateGame.Location = new System.Drawing.Point(800, 316);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(138, 36);
            this.btnCreateGame.TabIndex = 0;
            this.btnCreateGame.Text = "New Game";
            this.btnCreateGame.UseVisualStyleBackColor = false;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLog.ForeColor = System.Drawing.Color.Lime;
            this.txtLog.Location = new System.Drawing.Point(8, 316);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(742, 292);
            this.txtLog.TabIndex = 1;
            // 
            // btnAttack
            // 
            this.btnAttack.BackColor = System.Drawing.Color.Maroon;
            this.btnAttack.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAttack.ForeColor = System.Drawing.SystemColors.Control;
            this.btnAttack.Location = new System.Drawing.Point(800, 386);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(138, 82);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.toolTip1.SetToolTip(this.btnAttack, "Press \'Attack\' button to inflict damage against enemy team");
            this.btnAttack.UseVisualStyleBackColor = false;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // txtTeam1
            // 
            this.txtTeam1.BackColor = System.Drawing.Color.Black;
            this.txtTeam1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam1.ForeColor = System.Drawing.Color.Lime;
            this.txtTeam1.Location = new System.Drawing.Point(8, 86);
            this.txtTeam1.Multiline = true;
            this.txtTeam1.Name = "txtTeam1";
            this.txtTeam1.Size = new System.Drawing.Size(372, 208);
            this.txtTeam1.TabIndex = 3;
            this.txtTeam1.TabStop = false;
            // 
            // txtTeam2
            // 
            this.txtTeam2.BackColor = System.Drawing.Color.Black;
            this.txtTeam2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam2.ForeColor = System.Drawing.Color.Lime;
            this.txtTeam2.Location = new System.Drawing.Point(386, 86);
            this.txtTeam2.Multiline = true;
            this.txtTeam2.Name = "txtTeam2";
            this.txtTeam2.Size = new System.Drawing.Size(364, 208);
            this.txtTeam2.TabIndex = 4;
            this.txtTeam2.TabStop = false;
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabGame);
            this.tabControlMain.Controls.Add(this.tabShop);
            this.tabControlMain.Location = new System.Drawing.Point(0, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1011, 654);
            this.tabControlMain.TabIndex = 5;
            // 
            // tabGame
            // 
            this.tabGame.BackColor = System.Drawing.Color.SlateGray;
            this.tabGame.Controls.Add(this.pictureBox1);
            this.tabGame.Controls.Add(this.txtRoundLog);
            this.tabGame.Controls.Add(this.btnAttack);
            this.tabGame.Controls.Add(this.btnCreateGame);
            this.tabGame.Controls.Add(this.txtTeam1);
            this.tabGame.Controls.Add(this.txtTeam2);
            this.tabGame.Controls.Add(this.txtLog);
            this.tabGame.Location = new System.Drawing.Point(4, 22);
            this.tabGame.Name = "tabGame";
            this.tabGame.Padding = new System.Windows.Forms.Padding(3);
            this.tabGame.Size = new System.Drawing.Size(1003, 628);
            this.tabGame.TabIndex = 0;
            this.tabGame.Text = "Game";
            // 
            // txtRoundLog
            // 
            this.txtRoundLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtRoundLog.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoundLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtRoundLog.Location = new System.Drawing.Point(756, 86);
            this.txtRoundLog.Multiline = true;
            this.txtRoundLog.Name = "txtRoundLog";
            this.txtRoundLog.Size = new System.Drawing.Size(216, 208);
            this.txtRoundLog.TabIndex = 5;
            this.txtRoundLog.TabStop = false;
            // 
            // tabShop
            // 
            this.tabShop.BackColor = System.Drawing.Color.SlateGray;
            this.tabShop.Controls.Add(this.textBox1);
            this.tabShop.Controls.Add(this.button1);
            this.tabShop.Controls.Add(this.tabControlShop);
            this.tabShop.Location = new System.Drawing.Point(4, 22);
            this.tabShop.Name = "tabShop";
            this.tabShop.Padding = new System.Windows.Forms.Padding(3);
            this.tabShop.Size = new System.Drawing.Size(1003, 628);
            this.tabShop.TabIndex = 1;
            this.tabShop.Text = "Shop";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.MenuText;
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox1.Location = new System.Drawing.Point(591, 136);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(292, 321);
            this.textBox1.TabIndex = 2;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.LightGray;
            this.button1.Location = new System.Drawing.Point(148, 491);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(125, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Purchase";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // tabControlShop
            // 
            this.tabControlShop.Controls.Add(this.tabWeapons);
            this.tabControlShop.Controls.Add(this.tabArmor);
            this.tabControlShop.Location = new System.Drawing.Point(30, 114);
            this.tabControlShop.Name = "tabControlShop";
            this.tabControlShop.SelectedIndex = 0;
            this.tabControlShop.Size = new System.Drawing.Size(412, 343);
            this.tabControlShop.TabIndex = 0;
            // 
            // tabWeapons
            // 
            this.tabWeapons.Location = new System.Drawing.Point(4, 22);
            this.tabWeapons.Name = "tabWeapons";
            this.tabWeapons.Padding = new System.Windows.Forms.Padding(3);
            this.tabWeapons.Size = new System.Drawing.Size(404, 317);
            this.tabWeapons.TabIndex = 0;
            this.tabWeapons.Text = "Weapons";
            this.tabWeapons.UseVisualStyleBackColor = true;
            // 
            // tabArmor
            // 
            this.tabArmor.Location = new System.Drawing.Point(4, 22);
            this.tabArmor.Name = "tabArmor";
            this.tabArmor.Padding = new System.Windows.Forms.Padding(3);
            this.tabArmor.Size = new System.Drawing.Size(404, 317);
            this.tabArmor.TabIndex = 1;
            this.tabArmor.Text = "Armor";
            this.tabArmor.UseVisualStyleBackColor = true;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Wargame.Properties.Resources.wargame;
            this.pictureBox1.Location = new System.Drawing.Point(255, 3);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(275, 77);
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1011, 657);
            this.Controls.Add(this.tabControlMain);
            this.Name = "BattleForm";
            this.Text = "Wargame";
            this.tabControlMain.ResumeLayout(false);
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            this.tabShop.ResumeLayout(false);
            this.tabShop.PerformLayout();
            this.tabControlShop.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
    }
}

