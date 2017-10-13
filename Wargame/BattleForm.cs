using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wargame
{
    public partial class BattleForm : Form
    {
        private GameData gameData { get; set; }
        private StringBuilder messages { get; set; }
        private GameEngine engine = new GameEngine();


        public BattleForm()
        {
            InitializeComponent();
            messages = new StringBuilder();
            btnAttack.Enabled = false;
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            var gf = new GameFactory();
            gameData = gf.CreateNewGame();
            engine.StartNextRound(gameData);
            btnAttack.Enabled = true;
            RefreshLog();
        }

        private void RefreshLog()
        {
            messages.Append(gameData.ToString());
            txtLog.Text = messages.ToString();
            messages.Clear();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            btnAttack.Enabled = false;

            var win = engine.CheckWin(gameData);
            var gameOver = win == "";
            if (!gameOver) messages.AppendLine(win);

            var atk = engine.ProcessAttack(gameData);
            gameOver = atk == "";
            if (!gameOver) messages.AppendLine(atk);

            if (!gameOver && !gameData.RoundOrder.Any()) engine.StartNextRound(gameData);
            RefreshLog();
            btnAttack.Enabled = !gameOver;
        }

    }
}
