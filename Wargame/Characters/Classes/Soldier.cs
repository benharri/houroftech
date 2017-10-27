namespace Wargame.Characters.Classes
{
    class Soldier : Character
    {
        public Soldier(string name) : base(name)
        {
            MaxHp = 30;
            Str += 4;
            Con += 3;
            Dex += 2;
            Int -= 1;
            Wis -= 1;
            Chr /= 2;
            NumDmgDice = 2;
        }
    }
}
