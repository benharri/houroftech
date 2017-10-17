namespace Wargame.Characters.Classes
{
    class Witcher : Character
    {
        public Witcher(string name, int maxHP = 30) : base(name, maxHP)
        {
            STR += 3;
            CON *= 2;
            DEX += 3;
            INT += 1;
            WIS += 1;
            CHR -= 3;
            BaseStrength = 6;
        }
    }
}
