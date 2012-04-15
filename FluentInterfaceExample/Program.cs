using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentInterfaceExample.Types;
using FluentInterfaceExample.Types.ExpressionBuilder;

namespace FluentInterfaceExample
{
    /// <summary>
    /// 
    /// This is an example of using an internal domain specific language (DSL) for providing domain-readable code.
    /// Uses the Expression Builder pattern with method chaining and progressive interfaces to create a simple RPG battle game.
    /// 
    /// By Kory Becker
    /// http://www.primaryobjects.com/articledirectory.aspx
    /// 
    /// </summary>
    class Program
    {
        static void Main(string[] args)
        {
            Random ran = new Random((int)DateTime.Now.Ticks);
            CharacterBuilder builder = new CharacterBuilder();
            
            // Build our Character with the expression builder.
            builder.Create("Valient")
                .As(Character.ClassType.Fighter)
                .WithAge(22)
                .HP(20)
                .Str(18)
                .Agi(14)
                .Int(12);

            // Get our Character.
            Character hero = builder.Value();

            // Put our hero to battle against endless enemies, and see how long he survives!
            while (hero.IsAlive)
            {
                // Build an enemy with the expression builder.
                builder.Create(CommonHelper.GenerateRandomName())
                    .As((Character.ClassType)ran.Next(4))
                    .WithAge(ran.Next(12, 200))
                    .HP(ran.Next(8, 15))
                    .Str(ran.Next(21))
                    .Agi(ran.Next(21))
                    .Int(ran.Next(21))
                    .Gold(ran.Next(50));

                // Get our enemy.
                Character enemy = builder.Value();

                // Display start of battle.
                CommonHelper.DisplayStartOfBattle(hero, enemy);

                // Battle time!
                CommonHelper.Battle(hero, enemy);
            }

            Console.ReadKey();
        }
    }
}
