using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_poo.src.Entities
{
    public class Knight : Hero
    {
        public Knight(string heroType, int life, string name) : base(heroType, life, name)
        {
            
        }

        /// <summary>
        /// Attack the opponent
        /// </summary>
        /// <param name="opponent">Requieres a object</param>
        /// <param name="hitDamage">Hit damage</param>
        /// <returns>Returns attack status</returns>
        public override string Attack(Hero opponent, int hitDamage)
        {
            int isCriticalDamage = 100;
            int critical = hitDamage + isCriticalDamage;

            if (hitDamage > isCriticalDamage)
            {
                string status = $"{Name} attacked, {opponent.Name}. Dealing {critical} critical damage.";
                opponent.Life -= critical;
                return status;
            }
            else
            {
                string status = $"{Name} attacked, {opponent.Name}. Causing {hitDamage} damage.";
                opponent.Life -= hitDamage;
                return status;
            }
        }
    }
}