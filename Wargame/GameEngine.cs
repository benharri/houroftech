using System;
using System.Linq;

namespace Wargame
{
    class GameEngine
    {
        private Random rng = new Random();


        internal int RollDice(int num = 1, int sides = 6)
        {
            return Enumerable.Range(1, num).Aggregate(0, (acc, _) => acc += rng.Next(1, sides + 1));
        }

        internal string DoAttack(Character attacker, Character defender)
        {
            return $"{attacker.Name} dealt {defender.CurrentHP -= RollDice(1, 6)} damage to {defender.Name}";
            //var dmg = RollDice(1, 6);
            //defender.CurrentHP -= dmg;
            //return $"{attacker.Name} dealt {dmg} damage to {defender.Name}";
        }

        internal void StartNextRound(GameData gameData)
        {
            gameData.RoundOrder.Clear();
            // todo: implement this

            while (gameData.RoundOrder.Count < gameData.Team1.Count + gameData.Team2.Count)
            {
                // todo: randomly choose a character not in RoundOrder and add it to the stack.
            }
        }
    }
}
