using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargame
{
    class Character
    {
        internal static int[] baseStats = new[] { 15, 14, 13, 12, 10, 8 };
        internal string Name { get; set; }
        internal int MaxHP { get; set; }
        internal int CurrentHP { get; set; }
        internal int Initiative { get; set; }
        internal CharacterInventory Inventory { get; set; }
        internal DiceRoll Roll { get; set; }
        internal bool Alive
        {
            get { return CurrentHP > 0; }
        }
        internal Stat STR { get; }
        internal Stat CON { get; }
        internal Stat DEX { get; }
        internal Stat INT { get; }
        internal Stat WIS { get; }
        internal Stat CHR { get; }

        public Character(string name, int maxHP = 20)
        {
            Name      = name;
            MaxHP     = maxHP;
            CurrentHP = maxHP;
            var rolls = new Stack<int>(baseStats.OrderBy(x => Guid.NewGuid()));
            STR       = new Stat(rolls.Pop());
            CON       = new Stat(rolls.Pop());
            DEX       = new Stat(rolls.Pop());
            INT       = new Stat(rolls.Pop());
            WIS       = new Stat(rolls.Pop());
            CHR       = new Stat(rolls.Pop());

            Inventory = new CharacterInventory();
            Roll = new DiceRoll(1, 4, STR.Modifier);
        }

        public override string ToString() => $"{(Alive ? " " : "X")} {Name}: \t{CurrentHP}/{MaxHP} HP ({Initiative})";

        internal void RollInitiative() => Initiative = new DiceRoll(sides: 20, modifier: DEX.Modifier).DoRoll().Total;

        internal string PrintStats() => $"{Name} [STR: {STR}({STR.Modifier}) CON: {CON}({CON.Modifier}) DEX: {DEX}({DEX.Modifier}) INT: {INT}({INT.Modifier}) WIS: {WIS}({WIS.Modifier}) CHR: {CHR}({CHR.Modifier})]";
    }
}
