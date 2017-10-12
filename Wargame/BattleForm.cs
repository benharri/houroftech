using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            CreateGrid();
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
            OutputCharacterStats();
            OutputInitiativeOrder();
            OutputMessages();
            messages.Clear();
        }

        private void OutputInitiativeOrder()
        {
            messages.AppendLine("Initiative Rolls: ");
            foreach(var character in gameData.RoundOrder)
            {
                messages.AppendLine(character.Name + ": " + character.InitiativeRoll);
            }
        }

        private void OutputMessages()
        {
            txtLog.Text = messages.ToString();
        }

        private void OutputCharacterStats()
        {
            foreach (var c in gameData.Team1)
            {
                OutputCharacter(c);
            }

            foreach (var c in gameData.Team2)
            {
                OutputCharacter(c);
            }
        }


        private void OutputCharacter(Character character)
        {
            messages.AppendLine($"{character.Name}: {character.CurrentHP}/{character.MaxHP} HP");
        }


        private void btnAttack_Click(object sender, EventArgs e)
        {
            //todo: take next attacker from round stack
            //todo: make sure attacker is still alive
            //todo: choose and alive defnder
            //todo: process attack
            //todo: check if round is done and start next round if anyone is still alive
            messages.AppendLine(engine.DoAttack(gameData.Team1.First(), gameData.Team2.First()));
            messages.AppendLine(engine.DoAttack(gameData.Team2.First(), gameData.Team1.First()));
            RefreshLog();
        }

        //todo: display initiative order
    }
}
