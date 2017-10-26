namespace Wargame.Characters.Classes
{
    class Monk : Character
    {
        public Monk(string name) : base(name)
        {
            MaxHp = 10;
            Str -= 3;
            Con -= 2;
            Dex += 1;
            Int += 5;
            Wis += 4;
            Chr += 2;
            NumDmgDice = 1;
            BaseStrength = 6;
            MeleeStat = Int;
        }
    }
}
