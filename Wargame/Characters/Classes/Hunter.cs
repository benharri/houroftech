namespace Wargame.Characters.Classes
{
    class Hunter : Character
    {
        public Hunter(string name) : base(name)
        {
            MaxHp = 25;
            Str += 3;
            Con += 4;
            Dex += 1;
            Int -= 1;
            Wis -= 1;
            Chr -= 2;
            NumDmgDice = 1;
            BaseStrength = 6;
            MeleeStat = Str;
        }
    }
}
