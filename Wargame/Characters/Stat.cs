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
    }
}
