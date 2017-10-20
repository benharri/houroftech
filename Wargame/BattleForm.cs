using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Wargame.Core;

namespace Wargame
{
    public partial class BattleForm : Form
    {
        public GameData Game { get; set; }
        public StringBuilder Messages { get; set; }
        private GameEngine Engine { get; set; }

        public DataGridView DataGridViewAvailableCharacter { set; get; }

        public DataGridView DataGridViewMyTeam { set; get; }

        public DataGridView DataGridViewOpponentTeam { set; get; }

        public DataGridView DataGridViewVendor { set; get; }

        public DataGridView DataGridViewPlayerInventory { set; get; }

        public Button BtnAttack { set; get; }

        public DataGridView DataGridViewVendor1
        {
            set { DataGridViewVendor = value; }
            get { return DataGridViewVendor; }
        }

        public TabControl TabControlMain { set; get; }

        public Button BtnCreateGame { set; get; }

        public TabControl TabControlMain1
        {
            set { TabControlMain = value; }
            get { return TabControlMain; }
        }

        public TabControl TabControlMain2
        {
            set { TabControlMain = value; }
            get { return TabControlMain; }
        }

        public Button BtnAttack1
        {
            set { BtnAttack = value; }
            get { return BtnAttack; }
        }

        public BattleForm()
        {
            InitializeComponent();
            BtnAttack.Enabled = false;
            BtnCreateGame.Text = "Pick Players";
            Messages = new StringBuilder();
            Game = (new GameFactory()).CreateNewGame();
            Engine = new GameEngine(Game);
            Engine.InitializeVendor(this);
            Engine.InitializeRoster(this);
        }

        public void RefreshLog()
        {
            txtLog.Text = Messages.ToString();
            txtRoundLog.Text = Game.InitiativeList();
            txtTeam1.Text = Game.TeamRoster(1);
            txtTeam2.Text = Game.TeamRoster(2);
            roundLabel.Text = $"Round {Game.RoundNumber}";
            Messages.Clear();
        }

        public void RefreshPlayerGold()
        {
            txtPlayerGold.Text = $"Player Gold: {Game.PlayerGold}";
            Messages.Clear();
        }
    }
}
