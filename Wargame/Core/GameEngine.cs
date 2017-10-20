using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace Wargame.Core
{
    class GameEngine
    {
        private static Random _rng = new Random();
        private readonly GameData _gd;

        public GameEngine(GameData gameData)
        {
            _gd = gameData;
        }


        internal string DoAttack(Character attacker, Character defender)
        {
            var roll = attacker.Roll.DoRoll();
            defender.CurrentHP -= roll.Total;

            return $"{attacker.Name} dealt {roll.Total} damage {(defender.Alive ? "to" : "and KILLED")} {defender.Name}\r\n  {roll}\r\nAttacker:\r\n  {attacker.PrintStats()}\r\nDefender:\r\n  {defender.PrintStats()}";
        }

        internal void StartRound(bool firstRound = false)
        {
            if (firstRound) _gd.RoundNumber = 1;
            else _gd.RoundNumber++;
            _gd.RoundOrder?.Clear();
            _gd.LivingCharacters.ForEach(c => c.RollInitiative());
            _gd.RoundOrder = new Stack<Character>(_gd.LivingCharacters);
        }

        internal string ProcessAttack()
        {
            if (!_gd.Team1.Any(c => c.Alive)) // no one alive on team1
            {
                return "You lost!\r\nGame Over";
            }
            else if (!_gd.Team2.Any(c => c.Alive)) // no one alive on team2
            {
                return "You won!\r\nGame Over";
            }

            var attacker = _gd.RoundOrder.Pop();
            if (!attacker.Alive)
            {
                return $"{attacker.Name} can't attack because they're dead. next player!";
            }

            var defender = (_gd.Team1.Contains(attacker) ? _gd.Team2 : _gd.Team1)
                .Where(x => x.Alive)
                .OrderBy(q => Guid.NewGuid())
                .First();
            return DoAttack(attacker, defender);
        }

        public void InitializeRoster(BattleForm battleForm)
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            var grids = new List<DataGridView>() {battleForm.DataGridViewAvailableCharacter, battleForm.DataGridViewMyTeam, battleForm.DataGridViewOpponentTeam };
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
                    Width = 45,
                    HeaderText = "HP",
                    DataPropertyName = "MaxHP",
                });
                i.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    CellTemplate = cell,
                    Name = "Strength",
                    Width = 40,
                    HeaderText = "Strength",
                    DataPropertyName = "DieName",
                });
                i.Columns.Add(new DataGridViewTextBoxColumn()
                {
                    CellTemplate = cell,
                    Name = "Class",
                    Width = 150,
                    HeaderText = "Class",
                    DataPropertyName = "Class",
                });
            }

            battleForm.RefreshPlayerGold();
            battleForm.DataGridViewAvailableCharacter.DataSource = battleForm.Game.AvailableCharacters;
            battleForm.DataGridViewMyTeam.DataSource = battleForm.Game.Team1;
            battleForm.DataGridViewOpponentTeam.DataSource = battleForm.Game.Team2;
        }

        public void InitializeVendor(BattleForm battleForm)
        {
            DataGridViewCell cell = new DataGridViewTextBoxCell();

            var grids = new List<DataGridView>() {battleForm.DataGridViewVendor, battleForm.DataGridViewPlayerInventory };
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
                    Name = "Price",
                    Width = 70,
                    HeaderText = "Price",
                    DataPropertyName = "Price",
                });
                //TODO: show other stats on vendor screen
            }

            battleForm.DataGridViewVendor.DataSource = battleForm.Game.Vendor;
            battleForm.DataGridViewPlayerInventory.DataSource = battleForm.Game.PlayerInventory;
        }

        public void BtnAttack_Click(object sender, EventArgs e, BattleForm battleForm)
        {
            battleForm.BtnAttack.Enabled = false;

            var status = ProcessAttack();
            battleForm.Messages.AppendLine($"{status}\r\n");

            if (!battleForm.Game.RoundOrder.Any()) StartRound();
            if ((battleForm.BtnAttack.Enabled = !battleForm.Game.GameOver)) battleForm.Messages.AppendLine($"Next up:\r\n  {_gd.RoundOrder.Peek().PrintStats()}");
            battleForm.RefreshLog();
        }

        public void BtnPurchase_Click(object sender, EventArgs e, BattleForm battleForm)
        {
            if (!battleForm.Game.Vendor.Any()) return;
            var selectedItem = (Item) battleForm.DataGridViewVendor1.CurrentRow.DataBoundItem;
            if (battleForm.Game.PlayerGold >= selectedItem.Price)
            {
                battleForm.Game.PlayerGold -= selectedItem.Price;
                battleForm.Game.Vendor.Remove(selectedItem);
                battleForm.Game.PlayerInventory.Add(selectedItem);
                battleForm.RefreshPlayerGold();
            }
            else
            {
                MessageBox.Show("Not enough Gold!");
            }
        }

        public void BtnDraft_Click(object sender, EventArgs e, BattleForm battleForm)
        {
            if (battleForm.Game.TeamsFull)
            {
                MessageBox.Show("All set. Teams full. Starting Game!");
                battleForm.TabControlMain.SelectTab(1);
                battleForm.BtnCreateGame.Text = "Start Game";
                battleForm.BtnCreateGame.PerformClick();
            }
            if (!battleForm.Game.AvailableCharacters.Any() || battleForm.Game.TeamsFull) return;

            var selectedCharacter = (Character) battleForm.DataGridViewAvailableCharacter.CurrentRow?.DataBoundItem;
            battleForm.Game.AvailableCharacters.Remove(selectedCharacter);
            battleForm.Game.Team1.Add(selectedCharacter);

            var oppCharacter = battleForm.Game.AvailableCharacters.OrderBy(x => Guid.NewGuid()).First();
            battleForm.Game.AvailableCharacters.Remove(oppCharacter);
            battleForm.Game.Team2.Add(oppCharacter);

        }

        public void BtnDraftTeamIntroScreen_Click(object sender, EventArgs e, BattleForm battleForm)
        {
            battleForm.TabControlMain1.SelectTab(battleForm.TabControlMain1.TabPages["tabRosterMgmt"]);
        }

        public void BtnCreateGame_Click(object sender, EventArgs e, BattleForm battleForm)
        {
            if (!battleForm.Game.TeamsFull)
            {
                battleForm.TabControlMain2.SelectTab(battleForm.TabControlMain2.TabPages["tabRosterMgmt"]);
                return;
            }
            StartRound(firstRound: true);
            battleForm.Messages.AppendLine($"Next up:\r\n  {_gd.RoundOrder.Peek().PrintStats()}");
            battleForm.RefreshLog();
            battleForm.BtnAttack1.Enabled = true;
        }
    }
}
