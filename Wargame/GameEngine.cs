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


        internal string DoAttack(Character attacker, Character defender)
        {
            var roll = new DiceRoll(sides: 4, modifier: attacker.STR.Modifier);
            defender.CurrentHP -= roll.Total;

            return $"{attacker.Name} dealt {roll.Total} damage {(defender.Alive ? "to" : "and KILLED")} {defender.Name}\r\n  {roll}\r\nAttacker:\r\n  {attacker.PrintStats()}\r\nDefender:\r\n  {defender.PrintStats()}";
        }

        internal void StartNextRound()
        {
            gd.RoundNumber++;
            if (gd.RoundOrder != null) gd.RoundOrder.Clear();

            foreach (var c in gd.LivingCharacters)
            {
                c.RollInitiative();
            }
            gd.RoundOrder = new Stack<Character>(gd.LivingCharacters);
        }

        internal string ProcessAttack()
        {
            if (!gd.Team1.Any(t1 => t1.Alive)) // no one alive on team1
            {
                return "Team 2 won!\r\nGame Over";
            }
            else if (!gd.Team2.Any(t2 => t2.Alive)) // no one alive on team2
            {
                return "Team 1 won!\r\nGame Over";
            }

            var attacker = gd.RoundOrder.Pop();
            if (!attacker.Alive)
            {
                return $"{attacker.Name} can't attack because they're dead. next player!";
            }

            var defender = (gd.Team1.Contains(attacker) ? gd.Team2 : gd.Team1)
                .Where(x => x.Alive)
                .OrderBy(q => Guid.NewGuid())
                .First();
            return $"{DoAttack(attacker, defender)}";
        }
    }
}
