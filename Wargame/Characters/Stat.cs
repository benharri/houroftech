namespace Wargame
{
    class Stat
    {
        private int Statistic;
        internal int Modifier => (Statistic - 10) / 2;
        internal int Val => Statistic;

        public Stat(int stat)
        {
            Statistic = stat;
        }
        public override string ToString() => $"{Statistic}";

        public static Stat operator +(Stat s1, int s2) => new Stat(s1.Val + s2);
        public static Stat operator -(Stat s1, int s2) => new Stat(s1.Val - s2);
        public static Stat operator *(Stat s1, int s2) => new Stat(s1.Val * s2);
        public static Stat operator /(Stat s1, int s2) => new Stat(s1.Val / s2);
    }
}
