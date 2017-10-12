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
            //take next attacker from round stack
            var attacker = gameData.RoundOrder.Pop();
            //make sure attacker is still alive
            if(attacker.CurrentHP < 1)
            {
                messages.AppendLine("Attacker is down");
                return;
            }
            //choose and alive defender
            var opposingTeam = gameData.Team1.Contains(attacker) ? gameData.Team2 : gameData.Team1;
            var defender = opposingTeam.FirstOrDefault(d => d.CurrentHP > 0);
            
            if(defender == null)
            {
                messages.AppendLine("No standing defenders");
                return;
            }
            //process attack
            var result = engine.DoAttack(attacker, defender);
            messages.AppendLine(result);
            //todo: check if round is done and start next round if anyone is still alive
            messages.AppendLine(engine.DoAttack(gameData.Team1.First(), gameData.Team2.First()));
            messages.AppendLine(engine.DoAttack(gameData.Team2.First(), gameData.Team1.First()));
            RefreshLog();

            //todo: check if one side has one and end fight if so
            if(!gameData.Team1.Any(t1 => t1.CurrentHP > 0) || !gameData.Team2.Any(t2 => t2.CurrentHP > 0))
            {
                btnAttack.Enabled = false;
                messages.AppendLine("Game Over");
                //todo: start caring about who won
                //todo: don't just end completely after one fight
            }
            //check if round done and start next round if anyone is still alive
            if (!gameData.RoundOrder.Any())
            {
                engine.StartNextRound(gameData);
            }
        }

        //todo: display initiative order
    }
}
