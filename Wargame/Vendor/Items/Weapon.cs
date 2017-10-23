namespace Wargame
{
    class Weapon : Item
    {
        internal DiceRoll Strength { get; set; }

        public Weapon(string name, int numDice = 1, int strength = 4, int price = 5)
        {
            Name = name;
            Price = price;
            Strength = new DiceRoll(numDice, strength);
        }

        public override string ToString() => $"{Name}: [DMG: {Strength.DieName}]";
    }
}
