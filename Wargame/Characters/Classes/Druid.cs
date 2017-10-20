namespace Wargame.Characters.Classes
{
    class Druid : Character
    {
        public Druid(string name, int maxHP = 20) : base(name, maxHP)
        {
            STR -= 3;
            CON -= 2;
            DEX += 1;
            INT += 5;
            WIS += 4;
            CHR += 2;
            NumDmgDice = 2;
            BaseStrength = 6;
            MeleeStat = INT;
        }
    }
}
