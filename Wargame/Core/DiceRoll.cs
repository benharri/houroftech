using System;
using System.Linq;
using System.Text;

namespace Wargame.Core
{
    class DiceRoll
    {
        internal int[] Rolls;
        internal int Sides;
        internal int Modifier;
        internal int Quantity => Rolls.Count();
        internal int Total => BareRoll + Modifier;
        internal int BareRoll => Rolls.Sum();
        internal string DieName => $"{Quantity}d{Sides}";
        internal static Random Rng = new Random();

        public DiceRoll(int qty = 1, int sides = 6, int modifier = 0)
        {
            Rolls = new int[qty];
            Sides = sides;
            Modifier = modifier;
        }

        internal DiceRoll DoRoll()
        {
            Rolls = Rolls.Select(x => Rng.Next(Sides) + 1).ToArray();
            return this;
        }

        public override string ToString()
        {
            var res = new StringBuilder();
            res.AppendLine($"{DieName}: {Total} ({BareRoll} with {Modifier} modifier)");
            for (var n = 0; n < Quantity && 1 < Quantity; n++)
                res.AppendLine($"    {n + 1}: {Rolls[n]}");
            return res.ToString();
        }

        public static DiceRoll operator +(DiceRoll d1, DiceRoll d2)
        {
            return new DiceRoll(
                d1.Quantity + d2.Quantity, 
                Math.Max(d1.Sides, d2.Sides), 
                Math.Max(d1.Modifier, d2.Modifier)
            );
        }
    }
}
