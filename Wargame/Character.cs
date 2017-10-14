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
        internal int Strength { get; }
        internal int Constitution { get; }
        internal int Dexterity { get; }
        internal int Intelligence { get; }
        internal int Wisdom { get; }
        internal int Charisma { get; }

        public Character(string name, int maxHP = 10)
        {
            Name = name;
            MaxHP = maxHP;
            CurrentHP = maxHP;
            var rolls = new Stack<int>(baseStats.OrderBy(x => Guid.NewGuid()));
            Strength = rolls.Pop();
            Constitution = rolls.Pop();
            Dexterity = rolls.Pop();
            Intelligence = rolls.Pop();
            Wisdom = rolls.Pop();
            Charisma = rolls.Pop();
        }

        internal static int Modifier(int stat = 10) => (stat - 10) / 2;

        internal void RollInitiative() => Initiative = GameEngine.RollDice(1, 20, Modifier(Dexterity));

        public override string ToString()
        {
            return $"{(Alive ? " " : "X")} {Name}: \t{CurrentHP}/{MaxHP} HP ({Initiative})";
        }

        internal string PrintStats()
        {
            return $"{Name} [STR: {Strength}({Modifier(Strength)}) CON: {Constitution}({Modifier(Constitution)}) DEX: {Dexterity}({Modifier(Dexterity)}) INT: {Intelligence}({Modifier(Intelligence)}) WIS: {Wisdom}({Modifier(Wisdom)}) CHR: {Charisma}({Modifier(Charisma)})]";
        }
    }
}
