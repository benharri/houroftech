namespace Wargame.Characters.Classes
{
    class Soldier : Character
    {
        public Soldier(string name, int maxHP = 30) : base(name, maxHP)
        {
            STR += 4;
            CON += 3;
            DEX += 2;
            INT -= 1;
            WIS -= 1;
            CHR /= 2;
            NumDmgDice = 2;
            BaseStrength = 6;
        }
    }
}
