namespace Wargame.Characters
{
    class Stat
    {
        internal int Modifier => (Val - 10) / 2;
        private int Val { get; set; }

        public Stat(int stat)
        {
            Val = stat;
        }
        public override string ToString() => $"{Val}";

        

        public static Stat operator +(Stat s1, int s2)
        {
            s1.Val += s2;
            return s1;
        }

        public static Stat operator -(Stat s1, int s2)
        {
            s1.Val -= s2;
            return s1;
        }
        public static Stat operator *(Stat s1, int s2)
        {
            s1.Val *= s2;
            return s1;
        }

        public static Stat operator /(Stat s1, int s2)
        {
            s1.Val /= s2;
            return s1;
        }
    }
}
