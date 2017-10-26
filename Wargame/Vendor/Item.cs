namespace Wargame.Vendor
{
    class Item
    {
        public string Name { get; set; }
        public int Price { get; set; }
        public string Description => ToString();

        public override string ToString() => $"{Name} {GetType().Name} {Price}";
    }
}
