using System;
using System.Collections.Generic;
using System.Linq;
using Wargame.Core;

namespace Wargame.Characters
{
    public class Character
    {
        public string Name { get; set; }
        public string Class => GetType().Name;
        private int _maxHp;
        public int MaxHp
        {
            get { return _maxHp; }
            set
            {
                _maxHp = value;
                CurrentHp = value;
            }
        }
        internal int CurrentHp { get; set; }
        internal bool Alive => CurrentHp > 0;
        internal int Initiative { get; set; }
        internal int BaseStrength { get; set; }
        internal int NumDmgDice { get; set; }
        internal CharacterInventory Inventory { get; set; }
        internal static int[] BaseStats = { 15, 14, 13, 12, 10, 8 };
        internal Stat Str { get; set; }
        internal Stat Con { get; set; }
        internal Stat Dex { get; set; }
        internal Stat Int { get; set; }
        internal Stat Wis { get; set; }
        internal Stat Chr { get; set; }
        internal Stat MeleeStat { get; set; }
        internal DiceRoll Roll => StatRoll(MeleeStat);
        public string DieName => Roll.DieName;

        public Character(string name)
        {
            Name         = name;
            MaxHp        = 20;
            NumDmgDice   = 1;
            BaseStrength = 4;

            var rolls = new Stack<int>(BaseStats.OrderBy(x => Guid.NewGuid()));
            Str = new Stat(rolls.Pop());
            Con = new Stat(rolls.Pop());
            Dex = new Stat(rolls.Pop());
            Int = new Stat(rolls.Pop());
            Wis = new Stat(rolls.Pop());
            Chr = new Stat(rolls.Pop());

            Inventory = new CharacterInventory();
            MeleeStat = Str;
        }

        internal DiceRoll StatRoll(Stat stat) => new DiceRoll(NumDmgDice, BaseStrength, stat.Modifier);

        public override string ToString() => $"{(Alive ? " " : "X")} {Name}: \t{CurrentHp}/{MaxHp} HP ({Class})";

        internal void RollInitiative() => Initiative = new DiceRoll(sides: 20, modifier: Dex.Modifier).DoRoll().Total;

        internal string PrintStats() => $"{Name} ({Class}) [STR: {Str}({Str.Modifier}) CON: {Con}({Con.Modifier}) DEX: {Dex}({Dex.Modifier}) INT: {Int}({Int.Modifier}) WIS: {Wis}({Wis.Modifier}) CHR: {Chr}({Chr.Modifier})]";
    }
}
