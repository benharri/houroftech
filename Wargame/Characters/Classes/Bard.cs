namespace Wargame.Characters.Classes
{
    class Bard : Character
    {
        public Bard(string name, int maxHP = 10) : base(name, maxHP)
        {
            STR -= 3;
            CON -= 2;
            DEX += 1;
            INT += 5;
            WIS += 4;
            CHR += 2;
        }
    }
}
