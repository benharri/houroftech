namespace Wargame
{
    public class Item
    {
        internal string Name { get; set; }
        internal int Price { get; set; }

        public override string ToString() => $"{Name} {GetType().Name} {Price}";
    }
}
