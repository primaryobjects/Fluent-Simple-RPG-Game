using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentInterfaceExample.Types
{
    /// <summary>
    /// Simple RPG Character class.
    /// </summary>
    public sealed class Character
    {
        /// <summary>
        /// Enum for Character class type.
        /// </summary>
        public enum ClassType
        {
            Fighter,
            Mage,
            Cleric,
            Rouge
        };

        public string Name;
        public ClassType Class;
        public int Age;
        public int Strength;
        public int Agility;
        public int Intelligence;
        public int Gold;
        public int HP;
        public int MaxHP;      
        public bool IsAlive
        {
            get
            {
                return HP > 0;
            }
        }

        public Character()
        {
        }

        public Character(string name)
        {
            Name = name;
        }

        public Character(string name, ClassType classType, int age, int hp, int strength, int agility, int intelligence, int gold)
        {
            Name = name;
            Class = classType;
            Age = age;
            MaxHP = hp;
            HP = hp;
            Strength = strength;
            Agility = agility;
            Intelligence = intelligence;
            Gold = gold;
        }

        public override string ToString()
        {
            string result = "Name: " + Name + "\nClass: " + Class.ToString() + "\nHP: " + HP + "/" + MaxHP + "\nAge: " + Age + "\nStr " + Strength + " / Agi " + Agility + " / Int " + Intelligence + "\nGold: " + Gold;
            return result;
        }

        public string QuickStats()
        {
            string result = Name + " (" + HP + "/" + MaxHP + ")";
            return result;
        }
    }
}
