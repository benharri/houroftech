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
        private List<GridCell> grid = new List<GridCell>();
        private GameData gameData { get; set; }
        private StringBuilder messages { get; set; }
        private GameEngine engine = new GameEngine();


        public BattleForm()
        {
            InitializeComponent();
            messages = new StringBuilder();
            //CreateGrid();
            btnAttack.Enabled = false;
        }


        private void CreateGrid()
        {
            for (var x = 0; x < 10; x++)
            {
                for (var y = 0; y < 10; y++)
                {
                    var pictureBox = new GridCell();
                    grid.Add(pictureBox);
                    Controls.Add(pictureBox);
                    pictureBox.Width = 20;
                    pictureBox.Height = 20;
                    pictureBox.Location = new Point(x * 20, y * 20);
                    pictureBox.BorderStyle = BorderStyle.FixedSingle;
                    pictureBox.GridX = x;
                    pictureBox.GridY = y;
                }
            }
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

            if (!gameData.Team1.Any(t1 => t1.CurrentHP > 0))
            {
                btnAttack.Enabled = false;
                messages.AppendLine("Team 2 won!");
                RefreshLog();
                return;
            }
            else if (!gameData.Team2.Any(t2 => t2.CurrentHP > 0))
            {
                btnAttack.Enabled = false;
                messages.AppendLine("Team 1 won!");
                RefreshLog();
                return;
                // todo: don't just end after the fight
            } 

            var attacker = gameData.RoundOrder.Pop();
            if (attacker.CurrentHP < 1)
            {
                messages.AppendLine($"{attacker.Name} can't attack because they're dead");
                RefreshLog();
                if (!gameData.RoundOrder.Any()) engine.StartNextRound(gameData);
                btnAttack.Enabled = true;
                return;
            }

            var opposingTeam = gameData.Team1.Contains(attacker) ? gameData.Team2 : gameData.Team1;
            // todo: attack someone other than the first living person on the opposingTeam
            var defender = opposingTeam.FirstOrDefault(d => d.CurrentHP > 0);
            if (defender == null)
            {
                messages.AppendLine($"game over");
                RefreshLog();
                return;
            }
            else
            {
                messages.AppendLine(engine.DoAttack(attacker, defender));
            }

            if (!gameData.RoundOrder.Any()) engine.StartNextRound(gameData);

            RefreshLog();
            btnAttack.Enabled = true;
        }

        //todo: display initiative order
    }
}
