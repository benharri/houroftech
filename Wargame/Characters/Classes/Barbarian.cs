namespace Wargame.Characters.Classes
{
    class Barbarian : Character
    {
        public Barbarian(string name, int maxHP = 60) : base(name, maxHP)
        {
            STR *= 2;
            CON *= 2;
            DEX -= 1;
            INT -= 5;
            WIS /= 2;
            CHR /= 2;
            NumDmgDice = 1;
            BaseStrength = 10;
        }
    }
}
