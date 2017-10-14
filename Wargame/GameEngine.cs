using System;
using System.Collections.Generic;
using System.Linq;

namespace Wargame
{
    class GameEngine
    {
        private static Random rng = new Random();
        private GameData gd;

        public GameEngine(GameData gameData)
        {
            gd = gameData;
        }


        public static int RollDice(int num = 1, int sides = 6, int modifier = 0)
        {
            return Enumerable.Range(1, num).Aggregate(0, (acc, _) => acc += rng.Next(1, sides + 1)) + modifier;
        }

        internal string DoAttack(Character attacker, Character defender)
        {
            var roll = RollDice(1, 4);
            var modi = Character.Modifier(attacker.Strength);
            defender.CurrentHP -= (roll + modi);

            return $"{attacker.Name} dealt {roll + modi} damage {(defender.Alive ? "to" : "and KILLED")} {defender.Name} (melee 1d4 => {roll} and {modi} STR modifier)\r\n\r\nAttacker:\r\n{attacker.PrintStats()}\r\nDefender:\r\n{defender.PrintStats()}";
        }

        internal void StartNextRound()
        {
            gd.RoundNumber++;
            gd.RoundOrder.Clear();

            var livingCharacters = gd.Team1.Concat(gd.Team2).Where(c => c.Alive);
            foreach (var c in livingCharacters)
            {
                c.RollInitiative();
            }
            // todo: add stat modifiers
            gd.RoundOrder = new Stack<Character>(livingCharacters.OrderBy(c => c.Initiative));
        }

        internal Tuple<bool, string> ProcessAttack()
        {
            if (!gd.Team1.Any(t1 => t1.Alive)) // no one alive on team1
            {
                return Tuple.Create(true, "Team 2 won!\r\nGame Over");
            }
            else if (!gd.Team2.Any(t2 => t2.Alive)) // no one alive on team2
            {
                return Tuple.Create(true, "Team 1 won!\r\nGame Over");
            }

            var attacker = gd.RoundOrder.Pop();
            if (!attacker.Alive)
            {
                return Tuple.Create(false, $"{attacker.Name} can't attack because they're dead. next player!");
            }

            var defender = (gd.Team1.Contains(attacker) ? gd.Team2 : gd.Team1)
                .Where(x => x.Alive)
                .ToArray()
                .OrderBy(q => Guid.NewGuid())
                .First();
            return Tuple.Create(false, $"{DoAttack(attacker, defender)}");
        }
    }
}
