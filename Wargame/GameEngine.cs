﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Wargame
{
    class GameEngine
    {
        private Random rng = new Random();


        internal int RollDice(int num, int sides)
        {
            var total = 0;
            for (var i = 0; i < num; i++)
            {
                total += rng.Next(sides) + 1;
            }
            return total;
        }

        internal string DoAttack(Character attacker, Character defender)
        {
            var dmg = RollDice(1, 6);
            defender.CurrentHP -= dmg;
            return $"{attacker.Name} dealt {dmg} damage to {defender.Name}";
        }

        internal void StartNextRound(GameData gameData)
        {
            gameData.RoundOrder.Clear();

            var lstInitiatives = (from c in gameData.Team1.Concat(gameData.Team2)
                                  select new
                                  {
                                    TheCharacter = c,
                                    InitiativeRoll = RollDice(1, 20)
                                  });

            foreach(var i in lstInitiatives.OrderBy(l => l.InitiativeRoll))
            {
                i.TheCharacter.InitiativeRoll = i.InitiativeRoll;
                gameData.RoundOrder.Push(i.TheCharacter);
            }
            
            //todo: add stat modifier
        }
    }
}
