namespace Wargame
{
    class CharacterFactory
    {
        public Character GetCharacter(string name)
        {
            var c = new Character();
            c.Name = name;
            c.MaxHP = 20;
            c.CurrentHP = 20;
            return c;
        }
    }
}
