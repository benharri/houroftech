namespace Wargame.Characters.Classes
{
    class Priest : Character
    {
        public Priest(string name, int maxHP = 15) : base(name, maxHP)
        {
            STR -= 3;
            CON -= 2;
            DEX += 3;
            INT += 3;
            WIS += 3;
            CHR -= 3;
            BaseStrength = 4;
            MeleeStat = WIS;
        }
    }
}
