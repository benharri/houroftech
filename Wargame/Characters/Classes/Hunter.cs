namespace Wargame.Characters.Classes
{
    class Hunter : Character
    {
        public Hunter(string name, int maxHP = 25) : base(name, maxHP)
        {
            STR += 3;
            CON += 4;
            DEX += 1;
            INT -= 1;
            WIS -= 1;
            CHR -= 2;
            NumDmgDice = 1;
            BaseStrength = 6;
        }
    }
}
