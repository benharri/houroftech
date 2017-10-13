using System;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wargame
{
    public partial class BattleForm : Form
    {
        private GameData gd { get; set; }
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
            gd = (new GameFactory()).CreateNewGame();
            engine = new GameEngine(gd);
            engine.StartNextRound();
            btnAttack.Enabled = true;
            RefreshLog();
        }

        private void RefreshLog()
        {
            txtLog.Text = msgs.Append(gd).ToString();
            txtTeam1.Text = gd.TeamRoster(1);
            txtTeam2.Text = gd.TeamRoster(2);
            msgs.Clear();
        }

        private void btnAttack_Click(object sender, EventArgs e)
        {
            btnAttack.Enabled = false;

            var status = engine.ProcessAttack();
            msgs.AppendLine($"{status.Item2}\r\n");

            if (!gd.RoundOrder.Any()) engine.StartNextRound();
            RefreshLog();
            btnAttack.Enabled = !status.Item1;
        }

    }
}
