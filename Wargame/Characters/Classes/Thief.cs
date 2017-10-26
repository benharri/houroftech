namespace Wargame.Characters.Classes
{
    class Thief : Character
    {
        public Thief(string name) : base(name)
        {
            MaxHp = 15;
            Str -= 1;
            Con += 3;
            Dex += 5;
            Int -= 1;
            Wis += 1;
            Chr += 3;
            NumDmgDice = 2;
            BaseStrength = 4;
            MeleeStat = Dex;
        }
    }
}
