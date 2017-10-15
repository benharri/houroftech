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
            var i = 0;
            var j = 0;
            foreach (var item in Game.Vendor)
            {
                if(typeof(Weapon) == item.GetType())
                {
                    var weapon = (Weapon)item;
                    clbVendorWeapons.Items.Insert(i, ($"{weapon.Name} - Damage: {weapon.MinimumDamage}-{weapon.MaximumDamage} - Price: {weapon.Price}"));
                    i++;
                }
                else if (typeof(Armor) == item.GetType())
                {
                    var armor = (Armor)item;
                    clbVendorArmor.Items.Insert(j, ($"{armor.Name} - Defense: {armor.Defense} Strength+: {armor.StrengthModifer} - Price: {armor.Price}"));
                    j++;
                }
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

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            foreach (object itemChecked in clbVendorWeapons.CheckedItems)
            {
                MessageBox.Show(itemChecked.ToString());
            }

            foreach (object itemChecked in clbVendorArmor.CheckedItems)
            {
                MessageBox.Show(itemChecked.ToString());
            }

        }
    }
}
