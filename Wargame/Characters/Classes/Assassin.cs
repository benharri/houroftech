namespace Wargame.Characters.Classes
{
    class Assassin : Character
    {
        public Assassin(string name, int maxHP = 20) : base(name, maxHP)
        {
            STR -= 3;
            CON += 2;
            DEX += 6;
            INT += 3;
            WIS += 1;
            CHR -= 2;
            NumDmgDice = 2;
            BaseStrength = 6;
            MeleeStat = DEX;
        }
    }
}
