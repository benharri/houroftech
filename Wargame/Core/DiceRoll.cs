using System;
using System.Linq;
using System.Text;

namespace Wargame.Core
{
    class DiceRoll
    {
        private int[] _rolls;
        private readonly int _sides;
        private readonly int _modifier;
        private static readonly Random Rng = new Random();
        private int Quantity => _rolls.Count();
        internal int Total => BareRoll + _modifier;
        private int BareRoll => _rolls.Sum();
        internal string DieName => $"{Quantity}d{_sides}";

        public DiceRoll(int qty = 1, int sides = 6, int modifier = 0)
        {
            _rolls = new int[qty];
            _sides = sides;
            _modifier = modifier;
        }

        internal DiceRoll DoRoll()
        {
            _rolls = _rolls.Select(x => Rng.Next(_sides) + 1).ToArray();
            return this;
        }

        public override string ToString()
        {
            var res = new StringBuilder();
            res.AppendLine($"{DieName}: {Total} ({BareRoll} with {_modifier} modifier)");
            for (var n = 0; n < Quantity && 1 < Quantity; n++)
                res.AppendLine($"    {n + 1}: {_rolls[n]}");
            return res.ToString();
        }

        public static DiceRoll operator +(DiceRoll d1, DiceRoll d2)
        {
            return new DiceRoll(
                d1.Quantity + d2.Quantity, 
                Math.Max(d1._sides, d2._sides), 
                Math.Max(d1._modifier, d2._modifier)
            );
        }
    }
}
