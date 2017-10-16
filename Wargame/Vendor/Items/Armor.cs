namespace Wargame
{
    class Armor : Item
    {
        internal int Defense { get; set; }
        internal int StrengthModifer { get; set; }

        public Armor() {}
        public Armor(int id, string name, int defense, int strengthmodifier, int price)
        {
            ID = id;
            Name = name;
            Price = price;
            Defense = defense;
            StrengthModifer = strengthmodifier;
        }

        public override string ToString()
        {
            return $"{Name}: [STR: {StrengthModifer} DEF: {Defense}] Price: {Price}";
        }
    }
}
