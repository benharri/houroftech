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
            var dmg = RollDice(1, 6);
            defender.CurrentHP -= dmg;
            return $"{attacker.Name} dealt {dmg} damage to {defender.Name}";
        }

        internal void StartNextRound(GameData gameData)
        {
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
    }
}
