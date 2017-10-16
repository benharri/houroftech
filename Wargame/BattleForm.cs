using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wargame;

namespace Wargame
{
    public partial class BattleForm : Form
    {
        private GameData Game { get; set; }
        private StringBuilder Messages { get; set; }
        private GameEngine Engine { get; set; }
        internal static Random rng = new Random();

        public BattleForm()
        {
            InitializeComponent();
            btnAttack.Enabled = false;
            Messages = new StringBuilder();
            Game = (new GameFactory()).CreateNewGame();
            Engine = new GameEngine(Game);
            InitializeVendor();
            InitializeRosterSelection();
        }

        private void InitializeRosterSelection()
        {
            foreach (var character in Game.AvailableCharacters)
            {
                //todo: add column for both name and hp to pass to character
                dataGridViewAvailableCharacter.Rows.Add(character.Name);
            }
        }

        private void BtnCreateGame_Click(object sender, EventArgs e)
        {
            Game.Team1 = InitializeTeam(1);
            Game.Team2 = InitializeTeam(2);
            Engine.StartNextRound();
            Game.RoundNumber = 1;
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

            if (!Game.RoundOrder.Any()) Engine.StartNextRound();
            if ((btnAttack.Enabled = !Game.GameOver)) Messages.AppendLine($"Next up:\r\n  {Game.RoundOrder.Peek().PrintStats()}");
            RefreshLog();
        }

        private void BtnPurchase_Click(object sender, EventArgs e)
        {
            var checkBoxIndex = 0;
            foreach (object itemChecked in clbVendorWeapons.CheckedItems)
            {
                clbInventory.Items.Insert(checkBoxIndex, itemChecked.ToString());
                checkBoxIndex++;
            }

            foreach (object itemChecked in clbVendorArmor.CheckedItems)
            {
                clbInventory.Items.Insert(checkBoxIndex, itemChecked.ToString());
                checkBoxIndex++;
            }
        }

        private void BtnDraft_Click(object sender, EventArgs e)
        {
            var myTurn = 0;
            var opponentTurn = 0;

            //select my player
            dataGridViewMyTeam.Rows.Add(dataGridViewAvailableCharacter.CurrentCell.Value);
            dataGridViewAvailableCharacter.Rows.Remove(dataGridViewAvailableCharacter.CurrentRow);
            myTurn++;
            //select opponent player
            dataGridViewAvailableCharacter.CurrentCell = dataGridViewAvailableCharacter.Rows[rng.Next(0, dataGridViewAvailableCharacter.Rows.Count - 2)].Cells[0];
            dataGridViewOpponentTeam.Rows.Add(dataGridViewAvailableCharacter.CurrentCell.Value);
            dataGridViewAvailableCharacter.Rows.Remove(dataGridViewAvailableCharacter.CurrentRow);
            opponentTurn++;
        }

        private List<Character> InitializeTeam(int team = 1)
        {
            //todo: add column for both name and hp to pass to character, then use here
            if(team == 1)
            {
                var myTeam = new List<Character>();
                for(var i = 0; i < dataGridViewMyTeam.Rows.Count - 1; i++)
                {
                    Character c = new Character(dataGridViewMyTeam.Rows[i].Cells["ColumnMyTeamName"].Value.ToString(), 20);
                    myTeam.Add(c);
                }
                return myTeam;
            }
            else if(team == 2)
            {
                var opponentTeam = new List<Character>();
                for (var i = 0; i < dataGridViewOpponentTeam.Rows.Count - 1; i++)
                {
                    Character c = new Character(dataGridViewOpponentTeam.Rows[i].Cells["ColumnOpponentName"].Value.ToString(), 20);
                    opponentTeam.Add(c);
                }
                return opponentTeam;
            }

            return null;
        }

        private void BtnSaveTeamRoster_Click(object sender, EventArgs e)
        {
            InitializeTeam(1);
            InitializeTeam(2);
        }
    }
}
