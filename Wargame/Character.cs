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
        internal bool Alive
        {
            get { return CurrentHP > 0; }
        }
        internal Stat Strength { get; }
        internal Stat Constitution { get; }
        internal Stat Dexterity { get; }
        internal Stat Intelligence { get; }
        internal Stat Wisdom { get; }
        internal Stat Charisma { get; }

        public Character(string name, int maxHP = 10)
        {
            Name = name;
            MaxHP = maxHP;
            CurrentHP = maxHP;
            var rolls = new Stack<int>(baseStats.OrderBy(x => Guid.NewGuid()));
            Strength = new Stat(rolls.Pop());
            Constitution = new Stat(rolls.Pop());
            Dexterity = new Stat(rolls.Pop());
            Intelligence = new Stat(rolls.Pop());
            Wisdom = new Stat(rolls.Pop());
            Charisma = new Stat(rolls.Pop());
        }

        internal static int Modifier(int stat = 10) => (stat - 10) / 2;

        internal void RollInitiative() => Initiative = GameEngine.RollDice(1, 20, Dexterity.Modifier);

        public override string ToString()
        {
            return $"{(Alive ? " " : "X")} {Name}: \t{CurrentHP}/{MaxHP} HP ({Initiative})";
        }

        internal string PrintStats()
        {
            return $"{Name} [STR: {Strength}({Strength.Modifier}) CON: {Constitution}({Constitution.Modifier}) DEX: {Dexterity}({Dexterity.Modifier}) INT: {Intelligence}({Intelligence.Modifier}) WIS: {Wisdom}({Wisdom.Modifier}) CHR: {Charisma}({Charisma.Modifier})]";
        }
    }
}
