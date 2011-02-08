using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using FluentInterfaceExample.Types;

namespace FluentInterfaceExample
{
    /// <summary>
    /// Helper class to store our static strings and helper methods.
    /// </summary>
    public static class CommonHelper
    {
        #region String Helpers

        /// <summary>
        /// Words used for enemy first names.
        /// </summary>
        private static readonly string[] _firstNames =
        {
            "Destro",
            "Victo",
            "Mozri",
            "Fang",
            "Ovi",
            "Hell",
            "Syth",
            "End"
        };

        /// <summary>
        /// Words used for enemy last names.
        /// </summary>
        private static readonly string[] _lastNames =
        {
            "math",
            "rin",
            "sith",
            "icous",
            "ravage",
            "wrath",
            "ryn",
            "less"
        };

        /// <summary>
        /// Verbs used for attacking.
        /// </summary>
        private static readonly string[] _attackVerbs =
        {
            "slashes",
            "stabs",
            "smashes",
            "impales",
            "poisons",
            "shoots",
            "incinerates",
            "destroys"
        };

        /// <summary>
        /// Generates a random name from the static string lists.
        /// </summary>
        /// <returns>Random name</returns>
        public static string GenerateRandomName()
        {
            string result = "";

            Random ran = new Random((int)DateTime.Now.Ticks);
            result = _firstNames[ran.Next(_firstNames.Length)] + _lastNames[ran.Next(_lastNames.Length)];

            return result;
        }

        #endregion

        /// <summary>
        /// Simple suspense text.
        /// </summary>
        /// <param name="hero">Character</param>
        /// <param name="enemy">Character</param>
        public static void DisplayStartOfBattle(Character hero, Character enemy)
        {
            // Size up the battle statistics.
            Console.WriteLine("= Starting Battle =");
            Console.WriteLine(hero.ToString());
            Console.WriteLine();
            Console.WriteLine("vs.");
            Console.WriteLine();
            Console.WriteLine(enemy.ToString());
            Console.WriteLine();

            // Add suspense.
            Console.Write("An enemy approaches> ");
            Console.ReadKey();
            Console.WriteLine();
            Console.WriteLine();
        }

        /// <summary>
        /// Simple battle system.
        /// </summary>
        /// <param name="hero">Character</param>
        /// <param name="enemy">Character</param>
        public static void Battle(Character hero, Character enemy)
        {
            // Battle the enemy.
            while (hero.IsAlive && enemy.IsAlive)
            {
                // Print quick stats.
                Console.WriteLine(hero.QuickStats() + " / " + enemy.QuickStats());

                Thread.Sleep(1000);

                // Hero attacks!
                Console.WriteLine(Attack(hero, enemy));

                Thread.Sleep(1000);

                // Enemy attacks!
                Console.WriteLine(Attack(enemy, hero));

                // Prompt for next round of combat.
                if (hero.IsAlive)
                {
                    Console.Write(">");
                    Console.ReadKey();
                }

                Console.WriteLine();
            }

            // Analyze battle results.
            if (hero.IsAlive)
            {
                // Hero won!
                hero.Gold += enemy.Gold;

                Console.WriteLine("Our hero survies to fight another battle! Won " + enemy.Gold + " gold!");

                Console.Write(">");
                Console.ReadKey();
                Console.Clear();
            }
            else
            {
                // Enemy won!
                Console.WriteLine("Our hero has fallen with " + hero.Gold + " gold! The world is covered in darkness once again.");
            }
        }

        /// <summary>
        /// Attacks a Character and returns status message.
        /// </summary>
        /// <param name="attacker">Character initiating attack</param>
        /// <param name="defender">Character to attack</param>
        /// <returns>Status message</returns>
        private static string Attack(Character attacker, Character defender)
        {
            string result = "";

            Random ran = new Random((int)DateTime.Now.Ticks);

            // Calculate damage.
            int damage = ran.Next(10);

            // Deduct damage from defender's HP.
            defender.HP -= damage;

            // Select an attack verb.
            string verb = _attackVerbs[ran.Next(_attackVerbs.Length)];

            // Create status message.
            result = attacker.Name + " " + verb + " " + defender.Name + " for " + damage + " damage!";

            return result;
        }
    }
}
