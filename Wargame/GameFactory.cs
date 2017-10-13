namespace Wargame
{
    class GameFactory
    {
        public GameData CreateNewGame()
        {
            var data = new GameData();
            var cf = new CharacterFactory();
            data.Team1.Add(cf.GetCharacter("Geralt"));
            data.Team1.Add(cf.GetCharacter("Ciri"));
            data.Team1.Add(cf.GetCharacter("Vesemir"));
            data.Team2.Add(cf.GetCharacter("Eredin"));
            data.Team2.Add(cf.GetCharacter("Imlerith"));
            data.Team2.Add(cf.GetCharacter("Caranthir"));
            return data;
        }
    }
}
