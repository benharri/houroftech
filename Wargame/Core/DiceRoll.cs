using System;
using System.Linq;
using System.Text;

namespace Wargame
{
    class DiceRoll
    {
        internal int Total;
        internal int[] Rolls;
        internal int Sides;
        internal int BareRoll;
        internal int Quantity;
        internal int Modifier;
        internal string DieName => $"{Quantity}d{Sides}";
        internal static Random rng = new Random();

        public DiceRoll(int qty = 1, int sides = 6, int modifier = 0)
        {
            Rolls = new int[qty];
            Quantity = qty;
            Sides = sides;
            Modifier = modifier;
        }

        internal DiceRoll DoRoll()
        {
            //TODO: add parameter and rng chance of attack type. 
            Rolls = Rolls.Select(x => rng.Next(Sides) + 1).ToArray();
            BareRoll = Rolls.Sum();
            Total = BareRoll + Modifier;
            return this;
        }

        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.AppendLine($"{DieName}: {Total} ({BareRoll} with {Modifier} modifier)");
            for (var n = 0; n < Quantity && 1 < Quantity; n++)
                res.AppendLine($"    {n + 1}: {Rolls[n]}");
            return res.ToString();
        }
    }
}
