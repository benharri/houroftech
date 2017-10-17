namespace Wargame.Characters.Classes
{
    class Monk : Character
    {
        public Monk(string name, int maxHP = 10) : base(name, maxHP)
        {
            STR -= 3;
            CON -= 2;
            DEX += 1;
            INT += 5;
            WIS += 4;
            CHR += 2;
            NumDmgDice = 1;
            BaseStrength = 6;
            MeleeStat = INT;
        }
    }
}
