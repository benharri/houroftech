namespace Wargame
{
    class Character
    {
        public string Name { get; set; }
        public int MaxHP { get; set; }
        public int CurrentHP { get; set; }
        public int Initiative { get; set; }

        public override string ToString()
        {
            return $"{(CurrentHP < 1 ? "X" : " ")} {Name}: \t{CurrentHP}/{MaxHP} HP ({Initiative})";
        }
    }
}
