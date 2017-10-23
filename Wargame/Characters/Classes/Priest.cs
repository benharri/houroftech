namespace Wargame.Characters.Classes
{
    class Priest : Character
    {
        public Priest(string name) : base(name)
        {
            MaxHp = 15;
            Str -= 3;
            Con -= 2;
            Dex += 3;
            Int += 3;
            Wis += 3;
            Chr -= 3;
            BaseStrength = 4;
            MeleeStat = Wis;
        }
    }
}
