namespace Wargame.Characters.Classes
{
    class Assassin : Character
    {
        public Assassin(string name) : base(name)
        {
            Str -= 3;
            Con += 2;
            Dex += 6;
            Int += 3;
            Wis += 1;
            Chr -= 2;
            NumDmgDice = 2;
            BaseStrength = 6;
            MeleeStat = Dex;
        }
    }
}
