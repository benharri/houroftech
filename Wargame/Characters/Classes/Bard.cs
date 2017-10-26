namespace Wargame.Characters.Classes
{
    class Bard : Character
    {
        public Bard(string name) : base(name)
        {
            MaxHp = 10;
            Str -= 3;
            Con -= 2;
            Dex += 1;
            Int += 5;
            Wis += 4;
            Chr += 2;
            MeleeStat = Str;
        }
    }
}
