namespace Wargame
{
    class Stat
    {
        private int _statistic;
        internal int Modifier => (_statistic - 10) / 2;
        internal int Val => _statistic;

        public Stat(int stat)
        {
            _statistic = stat;
        }
        public override string ToString() => $"{_statistic}";

        

        public static Stat operator +(Stat s1, int s2)
        {
            s1._statistic += s2;
            return s1;
        }

        public static Stat operator -(Stat s1, int s2)
        {
            s1._statistic -= s2;
            return s1;
        }
        public static Stat operator *(Stat s1, int s2)
        {
            s1._statistic *= s2;
            return s1;
        }

        public static Stat operator /(Stat s1, int s2)
        {
            s1._statistic /= s2;
            return s1;
        }
    }
}
