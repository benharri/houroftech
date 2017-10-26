namespace Wargame.Vendor.Items
{
    class Armor : Item
    {
        internal int Defense { get; set; }
        internal int StrengthModifer { get; set; }

        public Armor(string name, int defense = 1, int strengthmodifier = 0, int price = 5)
        {
            Name = name;
            Price = price;
            Defense = defense;
            StrengthModifer = strengthmodifier;
        }

        public override string ToString()
        {
            return $"{Name}: [STR: {StrengthModifer} DEF: {Defense}]";
        }
    }
}
