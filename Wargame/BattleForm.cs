using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Wargame
{
    public partial class BattleForm : Form
    {
        private GameData Game { get; set; }
        private StringBuilder Messages { get; set; }
        private GameEngine Engine { get; set; }

        public BattleForm()
        {
            InitializeComponent();
            Messages = new StringBuilder();
            btnAttack.Enabled = false;
        }

        private void BtnCreateGame_Click(object sender, EventArgs e)
        {
            Game = (new GameFactory()).CreateNewGame();
            Engine = new GameEngine(Game);
            InitializeVendor();
            Engine.StartNextRound();
            btnAttack.Enabled = true;
            Messages.AppendLine($"Next up:\r\n{Game.RoundOrder.Peek().PrintStats()}");
            RefreshLog();
        }

        private void RefreshLog()
        {
            txtLog.Text = Messages.ToString();
            txtRoundLog.Text = Game.InitiativeList();
            txtTeam1.Text = Game.TeamRoster(1);
            txtTeam2.Text = Game.TeamRoster(2);
            roundLabel.Text = $"Round {Game.RoundNumber}";
            Messages.Clear();
        }

        private void InitializeVendor()
        {
            foreach (var item in Game.WeaponVendor)
            {
                clbVendorWeapons.Items.Insert(0,($"{item.Name} - Damage: {item.MinimumDamage}-{item.MaximumDamage} - Price: {item.Price}"));
            }
        }

        private void BtnAttack_Click(object sender, EventArgs e)
        {
            btnAttack.Enabled = false;

            var status = Engine.ProcessAttack();
            Messages.AppendLine($"{status.Item2}\r\n");

            if (!Game.RoundOrder.Any()) Engine.StartNextRound();
            btnAttack.Enabled = !status.Item1;
            if (!status.Item1) Messages.AppendLine($"Next up:\r\n{Game.RoundOrder.Peek().PrintStats()}");
            RefreshLog();
        }
    }
}
