namespace Wargame.Characters.Classes
{
    class Witcher : Character
    {
        public Witcher(string name) : base(name)
        {
            MaxHp = 30;
            Str += 3;
            Con *= 2;
            Dex += 3;
            Int += 1;
            Wis += 1;
            Chr -= 3;
            BaseStrength = 6;
            MeleeStat = Str;
        }
    }
}
