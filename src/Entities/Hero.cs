using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace rpg_poo.src.Entities
{
    /// <summary>
    /// Abstract class
    /// </summary>
    public abstract class Hero
    {
        public Hero(string heroType, int life, string name)
        {
            HeroType = heroType;
            Life = life;
            Name = name;
        }

        public string HeroType { get; set; }
        public int Life { get; set; }
        public string Name { get; set; }

        /// <summary>
        ///  Basic hero status
        /// </summary>
        /// <returns>Returns hero status</returns>
        public string HeroStatus()
        {
            string status = $"Name: {Name}, Life: {Life}, Hero type: {HeroType}";

            return status;
        }

        /// <summary>
        /// Attack the opponent
        /// </summary>
        /// <param name="opponent">Requieres a object</param>
        /// <param name="hitDamage">Hit damage</param>
        /// <returns>Returns attack status</returns>
        public virtual string Attack(Hero opponent, int hitDamage)
        {
            string status = $"{Name} attacked, {opponent.Name}.";

            return status;
        }
    }
}