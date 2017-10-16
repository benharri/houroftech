namespace Wargame
{
    class GameFactory
    {
        public GameData CreateNewGame()
        {
            var data = new GameData();

            data.Team1.Add(new Character("Geralt"));
            data.Team1.Add(new Character("Ciri"));
            data.Team1.Add(new Character("Vesemir"));
            data.Team1.Add(new Character("Lambert"));
            data.Team1.Add(new Character("Eskel"));

            data.Team2.Add(new Character("Eredin"));
            data.Team2.Add(new Character("Imlerith"));
            data.Team2.Add(new Character("Caranthir"));
            data.Team2.Add(new Character("Ge'els"));
            data.Team2.Add(new Character("Avallac'h"));

            //Weapon designer
            data.Vendor.Add(new Weapon(1, "Sword", 1, 4, 4, "Weapon"));
            data.Vendor.Add(new Weapon(2, "Rolling Pin", 0, 1, 1, "Weapon"));

            //Armor designer
            data.Vendor.Add(new Armor(3, "Light Armor", 2, 3, 3, "Armor"));
            data.Vendor.Add(new Armor(4, "Heavy Armor", 4, 3, 4, "Armor"));
            return data;
        }
    }
}
