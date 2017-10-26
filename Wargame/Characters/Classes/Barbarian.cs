namespace Wargame.Characters.Classes
{
    class Barbarian : Character
    {
        public Barbarian(string name) : base(name)
        {
            MaxHp = 60;
            Str *= 2;
            Con *= 2;
            Dex -= 1;
            Int -= 5;
            Wis /= 2;
            Chr /= 2;
            MeleeStat = Str;
            NumDmgDice = 1;
            BaseStrength = 10;
        }
    }
}
