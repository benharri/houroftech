using System;
using System.Collections.Generic;
using System.Linq;
using Wargame.Core;

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
            var roll = attacker.Roll.DoRoll();
            defender.CurrentHP -= roll.Total;

            return $"{attacker.Name} dealt {roll.Total} damage {(defender.Alive ? "to" : "and KILLED")} {defender.Name}\r\n  {roll}\r\nAttacker:\r\n  {attacker.PrintStats()}\r\nDefender:\r\n  {defender.PrintStats()}";
        }

        internal void StartRound(bool firstRound = false)
        {
            if (firstRound)
            {
                gd.RoundNumber = 1;
                foreach (var c in gd.Team1.Concat(gd.Team2))
                {
                    c.CurrentHP = c.MaxHP;
                }
            }
            else
            {
                gd.RoundNumber++;
            }

            gd.RoundOrder?.Clear();
            gd.LivingCharacters.ForEach(c => c.RollInitiative());
            gd.RoundOrder = new Stack<Character>(gd.LivingCharacters);
        }

        internal string ProcessAttack()
        {
            if (!gd.Team1.Any(t1 => t1.Alive)) // no one alive on team1
            {
                return "You lost!\r\nGame Over";
            }
            else if (!gd.Team2.Any(t2 => t2.Alive)) // no one alive on team2
            {
                return "You won!\r\nGame Over";
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
