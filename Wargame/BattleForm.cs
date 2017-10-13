using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wargame
{
    public partial class BattleForm : Form
    {
        private GameData gameData { get; set; }
        private StringBuilder msgs { get; set; }
        private GameEngine engine { get; set; }


        public BattleForm()
        {
            InitializeComponent();
            msgs = new StringBuilder();
            btnAttack.Enabled = false;
        }

        private void btnCreateGame_Click(object sender, EventArgs e)
        {
            gameData = (new GameFactory()).CreateNewGame();
            engine = new GameEngine(gameData);
            engine.StartNextRound();
            btnAttack.Enabled = true;
            RefreshLog();
        }

        private void RefreshLog()
        {
            msgs.Append(gameData.ToString());
            txtLog.Text = msgs.ToString();
            txtTeam1.Text = gameData.teamRoster(1);
            txtTeam2.Text = gameData.teamRoster(2);
            msgs.Clear();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            btnAttack.Enabled = false;

            var atk = engine.ProcessAttack();
            var gameOver = atk == "";
            if (!gameOver) msgs.AppendLine(atk);

            if (!gameOver && !gameData.RoundOrder.Any()) engine.StartNextRound();
            RefreshLog();
            btnAttack.Enabled = !gameOver;
        }

    }
}
