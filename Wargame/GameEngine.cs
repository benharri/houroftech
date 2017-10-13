﻿using System;
using System.Collections.Generic;
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
            var dmg = RollDice(1, 6);
            defender.CurrentHP -= dmg;
            if (defender.CurrentHP < 1)
                return $"{attacker.Name} killed {defender.Name} (by dealing {dmg} damage)";
            return $"{attacker.Name} dealt {dmg} damage to {defender.Name}";
        }

        internal void StartNextRound(GameData gameData)
        {
            gameData.RoundNumber++;
            gameData.RoundOrder.Clear();
            var initlist = (from c in gameData.Team1.Concat(gameData.Team2)
                            where c.CurrentHP > 0
                            select new
                            {
                                aCharacter = c,
                                InitiativeRoll = RollDice(1, 20)
                            });

            foreach (var i in initlist.OrderBy(l => l.InitiativeRoll))
            {
                gameData.RoundOrder.Push(i.aCharacter);
                i.aCharacter.Initiative = i.InitiativeRoll;
            }
            // todo: add stat modifiers
        }

        public string CheckWin(GameData gameData)
        {
            if (!gameData.Team1.Any(t1 => t1.CurrentHP > 0)) // no one alive on team1
                return "Team 2 won!";
            else if (!gameData.Team2.Any(t2 => t2.CurrentHP > 0)) // no one alive on team2
                return "Team 1 won!";
            else
                return "";
        }

        internal string ProcessAttack(GameData gameData)
        {
            var attacker = gameData.RoundOrder.Pop();
            if (attacker.CurrentHP < 1)
                return $"{attacker.Name} can't attack because they're dead. skipping to next player.";

            var opposingTeam = gameData.Team1.Contains(attacker) ? gameData.Team2 : gameData.Team1;
            // todo: attack someone other than the first living person on the opposingTeam
            var defender = opposingTeam.FirstOrDefault(d => d.CurrentHP > 0);
            if (defender == null)
                return "";
            else
                return DoAttack(attacker, defender);
        }
    }
}
