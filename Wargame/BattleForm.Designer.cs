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
            this.btnCreateGame = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.btnAttack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnCreateGame
            // 
            this.btnCreateGame.Location = new System.Drawing.Point(427, 12);
            this.btnCreateGame.Name = "btnCreateGame";
            this.btnCreateGame.Size = new System.Drawing.Size(75, 36);
            this.btnCreateGame.TabIndex = 0;
            this.btnCreateGame.Text = "Create Game";
            this.btnCreateGame.UseVisualStyleBackColor = true;
            this.btnCreateGame.Click += new System.EventHandler(this.btnCreateGame_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.Color.Black;
            this.txtLog.ForeColor = System.Drawing.SystemColors.Window;
            this.txtLog.Location = new System.Drawing.Point(12, 12);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ReadOnly = true;
            this.txtLog.Size = new System.Drawing.Size(276, 314);
            this.txtLog.TabIndex = 1;
            // 
            // btnAttack
            // 
            this.btnAttack.Location = new System.Drawing.Point(295, 302);
            this.btnAttack.Name = "btnAttack";
            this.btnAttack.Size = new System.Drawing.Size(75, 24);
            this.btnAttack.TabIndex = 2;
            this.btnAttack.Text = "Attack";
            this.btnAttack.UseVisualStyleBackColor = true;
            this.btnAttack.Click += new System.EventHandler(this.btnAttack_Click);
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(514, 375);
            this.Controls.Add(this.btnAttack);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.btnCreateGame);
            this.Name = "BattleForm";
            this.Text = "Battle";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnCreateGame;
        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.Button btnAttack;
    }
}

