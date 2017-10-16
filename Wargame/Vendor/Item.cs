namespace Wargame
{
    public class Item
    {
        public string Name { get; set; }
        public int ID { get; set; }
        public int Price { get; set; }

        public Item(int id, string name, int price)
        {
            ID = id;
            Name = name;
            Price = price;
        }
    }
}