using System;

namespace Wargame
{
    class Character
    {
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int Initiative { get; set; }
        public bool Alive
        {
            get { return CurrentHP > 0; }
        }

        public Character(string name, int maxHP = 10)
        {
            Name = name ?? throw new ArgumentNullException(nameof(name));
            MaxHP = maxHP;
            CurrentHP = maxHP;
        }

        internal void RollInitiative()
        {
            Initiative = GameEngine.RollDice(1, 20);
        }

        public override string ToString()
        {
            return $"{(Alive ? " " : "X")} {Name}: \t{CurrentHP}/{MaxHP} HP ({Initiative})";
        }
    }
}
