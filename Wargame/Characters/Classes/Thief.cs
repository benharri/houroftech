namespace Wargame.Characters.Classes
{
    class Thief : Character
    {
        public Thief(string name, int maxHP = 20) : base(name, maxHP)
        {
            STR -= 1;
            CON += 3;
            DEX += 5;
            INT -= 1;
            WIS += 1;
            CHR += 3;
            NumDmgDice = 2;
            BaseStrength = 4;
            MeleeStat = DEX;
        }
    }
}
