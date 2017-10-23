using System;
using System.Collections.Generic;
using System.Linq;
using Wargame.Characters;
using Wargame.Vendor.Items;

namespace Wargame.Core
{
    class GameEngine
    {
        private GameData gd;

        public GameEngine(GameData gameData)
        {
            gd = gameData;
        }


        internal string DoAttack(Character attacker, Character defender)
        {
            var roll = attacker.Roll;
            if (attacker.Inventory.Equipped.Any(i => i is Weapon))
            {
                roll += ((Weapon) attacker.Inventory.Weapons.OrderBy(x => Guid.NewGuid()).First()).Strength;
            }
            roll.DoRoll();

            var defensebonus = 0;
            if (defender.Inventory.Equipped.Any(i => i is Weapon))
            {
                defensebonus += defender.Inventory.DefenseBonus;
            }

            defender.CurrentHp -= roll.Total - defensebonus;

            return $"{attacker.Name} dealt {roll.Total} - {defensebonus} DEF bonus ({roll.Total - defensebonus}) damage {(defender.Alive ? "to" : "and KILLED")} {defender.Name}\r\n  {roll}\r\nAttacker:\r\n  {attacker.PrintStats()}\r\nDefender:\r\n  {defender.PrintStats()}";
        }

        internal void StartRound(bool firstRound = false)
        {
            if (firstRound)
            {
                gd.RoundNumber = 1;
                foreach (var c in gd.Team1.Concat(gd.Team2))
                {
                    c.CurrentHp = c.MaxHp;
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
