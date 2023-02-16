using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_poo.src.Entities
{
    /// <summary>
    /// Class to start the game
    /// </summary>
    public class Gameplay
    {
        public Gameplay(Hero hero1, Hero hero2, Hero hero3)
        {
            heroes.Add(hero1);
            heroes.Add(hero2);
            heroes.Add(hero3);
        }

        List<Hero> heroes = new List<Hero>();
        List<Hero> deadHeroes = new List<Hero>();
        List<int> listHitDamage = new List<int>{0, 25, 50, 60, 75, 100, 150};


        public void StartGame()
        {
            var random = new Random();
            int round = 0;

            while (heroes.Count > 1)
            {
                int heroAttack = random.Next(heroes.Count);
                int heroWhoDefends = random.Next(heroes.Count);
                int hitDamage = random.Next(listHitDamage.Count);

                if (heroes[heroAttack] != heroes[heroWhoDefends])
                {
                    round++;
                    Console.WriteLine($" =========== ROUND {round} ===========");
                    
                    Attacking(heroAttack, heroWhoDefends, hitDamage);
                }
            }

            Console.WriteLine("");
            Console.WriteLine($"{heroes[0].Name} IS THE WINNWER!");

            Console.WriteLine("");
            HeroesStatus();

        }

        /// <summary>
        /// Method that initiates the attack
        /// </summary>
        /// <param name="heroAttack">Hero who attacks</param>
        /// <param name="heroWhoDefends">Hero who defends</param>
        /// <param name="hitDamage">Hit damage</param>
        private void Attacking(int heroAttack, int heroWhoDefends, int hitDamage)
        {
            if (heroes[heroWhoDefends].Life > 0)
            {
                Console.WriteLine(heroes[heroAttack].Attack(heroes[heroWhoDefends], listHitDamage[hitDamage]));
                HeroDied(heroWhoDefends);
            }
        }

        /// <summary>
        /// Dead hero search method
        /// </summary>
        /// <param name="heroWhoDefends"> Hero who defends</param>
        private void HeroDied(int heroWhoDefends)
        {
            if (heroes[heroWhoDefends].Life <= 0)
            {
                Console.WriteLine($"{heroes[heroWhoDefends].Name} IS DEAD!");

                deadHeroes.Add(heroes[heroWhoDefends]);
                heroes.Remove(heroes[heroWhoDefends]);
            }
        }

        private void HeroesStatus()
        {
            Console.WriteLine("========= HEROES STATUS =========");

            for (int counter = 0; counter < deadHeroes.Count; counter++)
            {
                Console.WriteLine($"{counter + 1}° {deadHeroes[counter].Name} - DEAD!");
            }

            Console.WriteLine($"\nWinner: {heroes[0].Name} - Remanining life: {heroes[0].Life}");
        }
    }
}