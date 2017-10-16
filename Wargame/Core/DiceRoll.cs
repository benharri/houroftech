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
            Rolls    = new int[qty];
            Quantity = qty;
            Sides    = sides;
            Modifier = modifier;
        }

        internal DiceRoll DoRoll()
        {
            for (var i = 0; i < Quantity; i++)
            {
                Rolls[i] = RollDice(sides: Sides);
            }
            BareRoll = Rolls.Sum();
            Total = BareRoll + Modifier;
            return this;
        }


        public override string ToString()
        {
            StringBuilder res = new StringBuilder();
            res.AppendLine($"{DieName}: {Total} ({BareRoll} with {Modifier} modifier)");
            if (Quantity > 1)
            {
                for (var n = 0; n < Quantity; n++)
                {
                    res.AppendLine($"    {n + 1}: {Rolls[n]}");
                }
            }

            return res.ToString();
        }

        public static int RollDice(int num = 1, int sides = 6, int modifier = 0)
        {
            return Enumerable.Range(1, num).Aggregate(0, (acc, _) => acc += rng.Next(1, sides + 1)) + modifier;
        }
    }
}
