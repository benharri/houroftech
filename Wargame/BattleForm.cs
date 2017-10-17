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
            btnAttack.Enabled = false;
            btnCreateGame.Text = "Pick Players";
            Messages = new StringBuilder();
            Game = (new GameFactory()).CreateNewGame();
            Engine = new GameEngine(Game);
            InitializeVendor();
            InitializeRoster();
        }

        private void InitializeRoster()
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            var grids = new List<DataGridView>() { dataGridViewAvailableCharacter, dataGridViewMyTeam, dataGridViewOpponentTeam };
            foreach (var i in grids)
            {
                i.AutoGenerateColumns = false;
                i.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    CellTemplate = cell,
                    Name = "Name",
                    HeaderText = "Name",
                    DataPropertyName = "Name",
                });
                i.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    CellTemplate = cell,
                    Name = "HP",
                    Width = 30,
                    HeaderText = "HP",
                    DataPropertyName = "MaxHP",
                });
                i.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    CellTemplate = cell,
                    Name = "Strength",
                    Width = 30,
                    HeaderText = "Strength",
                    DataPropertyName = "DieName",
                });
                i.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    CellTemplate = cell,
                    Name = "Class",
                    Width = 70,
                    HeaderText = "Class",
                    DataPropertyName = "Class",
                });
            }

            dataGridViewAvailableCharacter.DataSource = Game.AvailableCharacters;
            dataGridViewMyTeam.DataSource = Game.Team1;
            dataGridViewOpponentTeam.DataSource = Game.Team2;
        }

        private void BtnCreateGame_Click(object sender, EventArgs e)
        {
            if (!Game.TeamsFull)
            {
                tabControlMain.SelectTab(tabControlMain.TabPages["tabPage1"]);
                return;
            }
            Engine.StartRound(firstRound: true);
            Messages.AppendLine($"Next up:\r\n  {Game.RoundOrder.Peek().PrintStats()}");
            RefreshLog();
            btnAttack.Enabled = true;
        }

        private void InitializeVendor()
        {
            var weaponIndex = 0;
            var armorIndex = 0;
            foreach (var item in Game.Vendor)
            {
                if (typeof(Weapon) == item.GetType())
                    clbVendorWeapons.Items.Insert(weaponIndex++, item.ToString());
                else if (typeof(Armor) == item.GetType())
                    clbVendorArmor.Items.Insert(armorIndex++, item.ToString());
            }
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

        private void BtnAttack_Click(object sender, EventArgs e)
        {
            btnAttack.Enabled = false;

            var status = Engine.ProcessAttack();
            Messages.AppendLine($"{status}\r\n");

            if (!Game.RoundOrder.Any()) Engine.StartRound();
            if ((btnAttack.Enabled = !Game.GameOver)) Messages.AppendLine($"Next up:\r\n  {Game.RoundOrder.Peek().PrintStats()}");
            RefreshLog();
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            var checkBoxIndex = 0;
            foreach (object itemChecked in clbVendorWeapons.CheckedItems)
                clbInventory.Items.Insert(checkBoxIndex++, itemChecked.ToString());

            foreach (object itemChecked in clbVendorArmor.CheckedItems)
                clbInventory.Items.Insert(checkBoxIndex++, itemChecked.ToString());
        }

        private void BtnDraft_Click(object sender, EventArgs e)
        {
            if (Game.TeamsFull)
            {
                MessageBox.Show("All set. Teams full. Starting Game!");
                tabControlMain.SelectTab(0);
                btnCreateGame.Text = "Start Game";
                btnCreateGame.PerformClick();
            }
            if (!Game.AvailableCharacters.Any() || Game.TeamsFull) return;

            var selectedCharacter = (Character)dataGridViewAvailableCharacter.CurrentRow.DataBoundItem;
            Game.AvailableCharacters.Remove(selectedCharacter);
            Game.Team1.Add(selectedCharacter);

            var oppCharacter = Game.AvailableCharacters.OrderBy(x => Guid.NewGuid()).First();
            Game.AvailableCharacters.Remove(oppCharacter);
            Game.Team2.Add(oppCharacter);

        }

    }
}
