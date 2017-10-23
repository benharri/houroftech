namespace Wargame.Characters.Classes
{
    class Druid : Character
    {
        public Druid(string name) : base(name)
        {
            MaxHp = 20;
            Str -= 3;
            Con -= 2;
            Dex += 1;
            Int += 5;
            Wis += 4;
            Chr += 2;
            NumDmgDice = 2;
            BaseStrength = 6;
            MeleeStat = Int;
        }
    }
}
