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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(BattleForm));
            this.BtnCreateGame = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.BtnAttack = new System.Windows.Forms.Button();
            this.txtTeam1 = new System.Windows.Forms.TextBox();
            this.txtTeam2 = new System.Windows.Forms.TextBox();
            this.toolTip1 = new System.Windows.Forms.ToolTip(this.components);
            this.TabControlMain = new System.Windows.Forms.TabControl();
            this.tabIntro = new System.Windows.Forms.TabPage();
            this.tabGame = new System.Windows.Forms.TabPage();
            this.initiativeLabel = new System.Windows.Forms.Label();
            this.roundLabel = new System.Windows.Forms.Label();
            this.team2Label = new System.Windows.Forms.Label();
            this.team1Label = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtRoundLog = new System.Windows.Forms.TextBox();
            this.tabRosterMgmt = new System.Windows.Forms.TabPage();
            this.DataGridViewAvailableCharacter = new System.Windows.Forms.DataGridView();
            this.DataGridViewOpponentTeam = new System.Windows.Forms.DataGridView();
            this.DataGridViewMyTeam = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.tabShop = new System.Windows.Forms.TabPage();
            this.txtPlayerGold = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.DataGridViewVendor = new System.Windows.Forms.DataGridView();
            this.DataGridViewPlayerInventory = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button3 = new System.Windows.Forms.Button();
            this.TabControlMain.SuspendLayout();
            this.tabIntro.SuspendLayout();
            this.tabGame.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.tabRosterMgmt.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAvailableCharacter)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOpponentTeam)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMyTeam)).BeginInit();
            this.tabShop.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVendor)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlayerInventory)).BeginInit();
            this.SuspendLayout();
            // 
            // btnCreateGame
            // 
            this.BtnCreateGame.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnCreateGame.BackColor = System.Drawing.Color.Olive;
            this.BtnCreateGame.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnCreateGame.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnCreateGame.Location = new System.Drawing.Point(1002, 3);
            this.BtnCreateGame.Name = "BtnCreateGame";
            this.BtnCreateGame.Size = new System.Drawing.Size(176, 36);
            this.BtnCreateGame.TabIndex = 0;
            this.BtnCreateGame.Text = "New Game";
            this.BtnCreateGame.UseVisualStyleBackColor = false;
            this.BtnCreateGame.Click += new System.EventHandler((sender, e) => this.Engine.BtnCreateGame_Click(sender, e, this));
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
            this.txtLog.Size = new System.Drawing.Size(991, 361);
            this.txtLog.TabIndex = 1;
            // 
            // btnAttack
            // 
            this.BtnAttack.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.BtnAttack.AutoSize = true;
            this.BtnAttack.BackColor = System.Drawing.Color.Maroon;
            this.BtnAttack.Cursor = System.Windows.Forms.Cursors.Hand;
            this.BtnAttack.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnAttack.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnAttack.ForeColor = System.Drawing.SystemColors.Control;
            this.BtnAttack.Location = new System.Drawing.Point(1002, 614);
            this.BtnAttack.Name = "BtnAttack";
            this.BtnAttack.Size = new System.Drawing.Size(176, 83);
            this.BtnAttack.TabIndex = 2;
            this.BtnAttack.Text = "Attack";
            this.toolTip1.SetToolTip(this.BtnAttack, "Press \'Attack\' button to inflict damage against enemy team");
            this.BtnAttack.UseVisualStyleBackColor = false;
            this.BtnAttack.Click += new System.EventHandler((sender, e) => this.Engine.BtnAttack_Click(sender, e, this));
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
            this.txtTeam1.Size = new System.Drawing.Size(459, 187);
            this.txtTeam1.TabIndex = 3;
            this.txtTeam1.TabStop = false;
            // 
            // txtTeam2
            // 
            this.txtTeam2.BackColor = System.Drawing.Color.Black;
            this.txtTeam2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtTeam2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeam2.ForeColor = System.Drawing.Color.Lime;
            this.txtTeam2.Location = new System.Drawing.Point(719, 122);
            this.txtTeam2.Multiline = true;
            this.txtTeam2.Name = "txtTeam2";
            this.txtTeam2.Size = new System.Drawing.Size(459, 187);
            this.txtTeam2.TabIndex = 4;
            this.txtTeam2.TabStop = false;
            // 
            // tabControlMain
            // 
            this.TabControlMain.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TabControlMain.Controls.Add(this.tabIntro);
            this.TabControlMain.Controls.Add(this.tabGame);
            this.TabControlMain.Controls.Add(this.tabRosterMgmt);
            this.TabControlMain.Controls.Add(this.tabShop);
            this.TabControlMain.Controls.Add(this.tabPage2);
            this.TabControlMain.Location = new System.Drawing.Point(0, 0);
            this.TabControlMain.Margin = new System.Windows.Forms.Padding(0);
            this.TabControlMain.Name = "TabControlMain";
            this.TabControlMain.Padding = new System.Drawing.Point(0, 0);
            this.TabControlMain.SelectedIndex = 0;
            this.TabControlMain.Size = new System.Drawing.Size(1191, 729);
            this.TabControlMain.TabIndex = 5;
            // 
            // tabIntro
            // 
            this.tabIntro.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabIntro.Controls.Add(this.button3);
            this.tabIntro.Controls.Add(this.textBox1);
            this.tabIntro.Location = new System.Drawing.Point(4, 22);
            this.tabIntro.Name = "tabIntro";
            this.tabIntro.Padding = new System.Windows.Forms.Padding(3);
            this.tabIntro.Size = new System.Drawing.Size(1183, 703);
            this.tabIntro.TabIndex = 3;
            this.tabIntro.Text = "Intro";
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
            this.tabGame.Controls.Add(this.BtnAttack);
            this.tabGame.Controls.Add(this.BtnCreateGame);
            this.tabGame.Controls.Add(this.txtTeam1);
            this.tabGame.Controls.Add(this.txtTeam2);
            this.tabGame.Controls.Add(this.txtLog);
            this.tabGame.Location = new System.Drawing.Point(4, 22);
            this.tabGame.Margin = new System.Windows.Forms.Padding(0);
            this.tabGame.Name = "tabGame";
            this.tabGame.Size = new System.Drawing.Size(1183, 703);
            this.tabGame.TabIndex = 0;
            this.tabGame.Text = "Game";
            // 
            // initiativeLabel
            // 
            this.initiativeLabel.AutoSize = true;
            this.initiativeLabel.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.initiativeLabel.ForeColor = System.Drawing.Color.Lime;
            this.initiativeLabel.Location = new System.Drawing.Point(468, 103);
            this.initiativeLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.initiativeLabel.Name = "initiativeLabel";
            this.initiativeLabel.Size = new System.Drawing.Size(108, 16);
            this.initiativeLabel.TabIndex = 10;
            this.initiativeLabel.Text = "Initiative";
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
            // team2Label
            // 
            this.team2Label.AutoSize = true;
            this.team2Label.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team2Label.ForeColor = System.Drawing.Color.Lime;
            this.team2Label.Location = new System.Drawing.Point(716, 103);
            this.team2Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.team2Label.Name = "team2Label";
            this.team2Label.Size = new System.Drawing.Size(138, 16);
            this.team2Label.TabIndex = 8;
            this.team2Label.Text = "Opposing Team";
            // 
            // team1Label
            // 
            this.team1Label.AutoSize = true;
            this.team1Label.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.team1Label.ForeColor = System.Drawing.Color.Lime;
            this.team1Label.Location = new System.Drawing.Point(5, 103);
            this.team1Label.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.team1Label.Name = "team1Label";
            this.team1Label.Size = new System.Drawing.Size(98, 16);
            this.team1Label.TabIndex = 7;
            this.team1Label.Text = "Your Team";
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
            // txtRoundLog
            // 
            this.txtRoundLog.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtRoundLog.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtRoundLog.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRoundLog.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtRoundLog.Location = new System.Drawing.Point(471, 122);
            this.txtRoundLog.Multiline = true;
            this.txtRoundLog.Name = "txtRoundLog";
            this.txtRoundLog.Size = new System.Drawing.Size(242, 187);
            this.txtRoundLog.TabIndex = 5;
            this.txtRoundLog.TabStop = false;
            // 
            // tabRosterMgmt
            // 
            this.tabRosterMgmt.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabRosterMgmt.Controls.Add(this.DataGridViewAvailableCharacter);
            this.tabRosterMgmt.Controls.Add(this.DataGridViewOpponentTeam);
            this.tabRosterMgmt.Controls.Add(this.DataGridViewMyTeam);
            this.tabRosterMgmt.Controls.Add(this.button2);
            this.tabRosterMgmt.Controls.Add(this.label4);
            this.tabRosterMgmt.Controls.Add(this.label3);
            this.tabRosterMgmt.Controls.Add(this.label2);
            this.tabRosterMgmt.Location = new System.Drawing.Point(4, 22);
            this.tabRosterMgmt.Name = "tabRosterMgmt";
            this.tabRosterMgmt.Padding = new System.Windows.Forms.Padding(3);
            this.tabRosterMgmt.Size = new System.Drawing.Size(1183, 703);
            this.tabRosterMgmt.TabIndex = 2;
            this.tabRosterMgmt.Text = "Roster Management";
            // 
            // dataGridViewAvailableCharacter
            // 
            this.DataGridViewAvailableCharacter.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAvailableCharacter.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.DataGridViewAvailableCharacter.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewAvailableCharacter.DefaultCellStyle = dataGridViewCellStyle2;
            this.DataGridViewAvailableCharacter.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridViewAvailableCharacter.Location = new System.Drawing.Point(398, 33);
            this.DataGridViewAvailableCharacter.Name = "DataGridViewAvailableCharacter";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewAvailableCharacter.RowHeadersDefaultCellStyle = dataGridViewCellStyle3;
            this.DataGridViewAvailableCharacter.Size = new System.Drawing.Size(380, 485);
            this.DataGridViewAvailableCharacter.TabIndex = 10;
            // 
            // dataGridViewOpponentTeam
            // 
            this.DataGridViewOpponentTeam.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewOpponentTeam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle4;
            this.DataGridViewOpponentTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewOpponentTeam.DefaultCellStyle = dataGridViewCellStyle5;
            this.DataGridViewOpponentTeam.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridViewOpponentTeam.Location = new System.Drawing.Point(784, 33);
            this.DataGridViewOpponentTeam.Name = "DataGridViewOpponentTeam";
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewOpponentTeam.RowHeadersDefaultCellStyle = dataGridViewCellStyle6;
            this.DataGridViewOpponentTeam.Size = new System.Drawing.Size(380, 485);
            this.DataGridViewOpponentTeam.TabIndex = 9;
            // 
            // dataGridViewMyTeam
            // 
            this.DataGridViewMyTeam.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewMyTeam.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.DataGridViewMyTeam.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewMyTeam.DefaultCellStyle = dataGridViewCellStyle8;
            this.DataGridViewMyTeam.GridColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.DataGridViewMyTeam.Location = new System.Drawing.Point(6, 33);
            this.DataGridViewMyTeam.Name = "DataGridViewMyTeam";
            this.DataGridViewMyTeam.ReadOnly = true;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewMyTeam.RowHeadersDefaultCellStyle = dataGridViewCellStyle9;
            dataGridViewCellStyle10.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle10.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.LimeGreen;
            this.DataGridViewMyTeam.RowsDefaultCellStyle = dataGridViewCellStyle10;
            this.DataGridViewMyTeam.Size = new System.Drawing.Size(380, 485);
            this.DataGridViewMyTeam.TabIndex = 8;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(529, 524);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(142, 57);
            this.button2.TabIndex = 6;
            this.button2.Text = "Draft Player";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler((sender, e) => this.Engine.BtnDraft_Click(sender, e, this));
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.LightGreen;
            this.label4.Location = new System.Drawing.Point(781, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 16);
            this.label4.TabIndex = 5;
            this.label4.Text = "Opponent\'s Roster";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.LightGreen;
            this.label3.Location = new System.Drawing.Point(395, 14);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(208, 16);
            this.label3.TabIndex = 4;
            this.label3.Text = "Available Characters";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.LightGreen;
            this.label2.Location = new System.Drawing.Point(9, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(148, 16);
            this.label2.TabIndex = 3;
            this.label2.Text = "My Team Roster";
            // 
            // tabShop
            // 
            this.tabShop.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabShop.Controls.Add(this.txtPlayerGold);
            this.tabShop.Controls.Add(this.label5);
            this.tabShop.Controls.Add(this.DataGridViewVendor);
            this.tabShop.Controls.Add(this.DataGridViewPlayerInventory);
            this.tabShop.Controls.Add(this.label1);
            this.tabShop.Controls.Add(this.button1);
            this.tabShop.Location = new System.Drawing.Point(4, 22);
            this.tabShop.Name = "tabShop";
            this.tabShop.Padding = new System.Windows.Forms.Padding(3);
            this.tabShop.Size = new System.Drawing.Size(1183, 703);
            this.tabShop.TabIndex = 1;
            this.tabShop.Text = "Vendor";
            // 
            // txtPlayerGold
            // 
            this.txtPlayerGold.BackColor = System.Drawing.SystemColors.MenuText;
            this.txtPlayerGold.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPlayerGold.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPlayerGold.ForeColor = System.Drawing.Color.LimeGreen;
            this.txtPlayerGold.Location = new System.Drawing.Point(535, 491);
            this.txtPlayerGold.Multiline = true;
            this.txtPlayerGold.Name = "txtPlayerGold";
            this.txtPlayerGold.Size = new System.Drawing.Size(316, 20);
            this.txtPlayerGold.TabIndex = 7;
            this.txtPlayerGold.Text = "Player Gold: ";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.LightGreen;
            this.label5.Location = new System.Drawing.Point(9, 31);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(68, 16);
            this.label5.TabIndex = 6;
            this.label5.Text = "Vendor";
            // 
            // dataGridViewVendor
            // 
            this.DataGridViewVendor.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewVendor.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewVendor.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.DataGridViewVendor.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle12.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle12.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewVendor.DefaultCellStyle = dataGridViewCellStyle12;
            this.DataGridViewVendor.Location = new System.Drawing.Point(6, 48);
            this.DataGridViewVendor.Name = "DataGridViewVendor";
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle13.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle13.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle13.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle13.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewVendor.RowHeadersDefaultCellStyle = dataGridViewCellStyle13;
            this.DataGridViewVendor.Size = new System.Drawing.Size(512, 437);
            this.DataGridViewVendor.TabIndex = 5;
            // 
            // dataGridViewPlayerInventory
            // 
            this.DataGridViewPlayerInventory.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.DataGridViewPlayerInventory.BackgroundColor = System.Drawing.SystemColors.ActiveCaptionText;
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle14.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle14.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle14.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPlayerInventory.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle14;
            this.DataGridViewPlayerInventory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.MenuText;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle15.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle15.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle15.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.DataGridViewPlayerInventory.DefaultCellStyle = dataGridViewCellStyle15;
            this.DataGridViewPlayerInventory.Location = new System.Drawing.Point(535, 48);
            this.DataGridViewPlayerInventory.Name = "DataGridViewPlayerInventory";
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Desktop;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.LimeGreen;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.DataGridViewPlayerInventory.RowHeadersDefaultCellStyle = dataGridViewCellStyle16;
            this.DataGridViewPlayerInventory.Size = new System.Drawing.Size(537, 437);
            this.DataGridViewPlayerInventory.TabIndex = 4;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.LightGreen;
            this.label1.Location = new System.Drawing.Point(532, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(98, 16);
            this.label1.TabIndex = 3;
            this.label1.Text = "Inventory";
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
            this.button1.Click += new System.EventHandler((sender, e) => this.Engine.BtnPurchase_Click(sender, e, this));
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DarkSlateGray;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1183, 703);
            this.tabPage2.TabIndex = 4;
            this.tabPage2.Text = "EquipmentManager";
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.Color.DarkSlateGray;
            this.textBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBox1.Font = new System.Drawing.Font("Lucida Console", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.ForeColor = System.Drawing.Color.LimeGreen;
            this.textBox1.Location = new System.Drawing.Point(371, 212);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(377, 272);
            this.textBox1.TabIndex = 0;
            this.textBox1.Text = resources.GetString("textBox1.Text");
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.SpringGreen;
            this.button3.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.button3.Location = new System.Drawing.Point(454, 531);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(158, 50);
            this.button3.TabIndex = 1;
            this.button3.Text = "Draft My Team >>";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler((sender, e) => this.Engine.BtnDraftTeamIntroScreen_Click(sender, e, this));
            // 
            // BattleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.BackColor = System.Drawing.Color.DarkSlateGray;
            this.ClientSize = new System.Drawing.Size(1190, 726);
            this.Controls.Add(this.TabControlMain);
            this.Name = "BattleForm";
            this.Text = "Wargame";
            this.TabControlMain.ResumeLayout(false);
            this.tabIntro.ResumeLayout(false);
            this.tabIntro.PerformLayout();
            this.tabGame.ResumeLayout(false);
            this.tabGame.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.tabRosterMgmt.ResumeLayout(false);
            this.tabRosterMgmt.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewAvailableCharacter)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewOpponentTeam)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewMyTeam)).EndInit();
            this.tabShop.ResumeLayout(false);
            this.tabShop.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewVendor)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DataGridViewPlayerInventory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox txtLog;
        private System.Windows.Forms.TextBox txtTeam1;
        private System.Windows.Forms.TextBox txtTeam2;
        private System.Windows.Forms.ToolTip toolTip1;
        private System.Windows.Forms.TabPage tabGame;
        private System.Windows.Forms.TabPage tabShop;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtRoundLog;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label team1Label;
        private System.Windows.Forms.Label team2Label;
        private System.Windows.Forms.Label roundLabel;
        private System.Windows.Forms.Label initiativeLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage tabRosterMgmt;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtPlayerGold;
        private System.Windows.Forms.TabPage tabIntro;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button3;
    }
}

