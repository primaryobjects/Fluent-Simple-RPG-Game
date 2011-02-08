using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using FluentInterfaceExample.Types;
using FluentInterfaceExample.Types.ExpressionBuilder.Interface;

namespace FluentInterfaceExample.Types.ExpressionBuilder
{
    /// <summary>
    /// Expression builder class for Character, using method chaining with progressive interfaces.
    /// </summary>
    public class CharacterBuilder : ICharacterBuilderClassType, ICharacterBuilderAge, ICharacterBuilderStats
    {
        private Character _character;

        public ICharacterBuilderClassType Create(string name)
        {
            _character = new Character(name);
            return this;
        }

        public ICharacterBuilderAge As(Character.ClassType classType)
        {
            _character.Class = classType;
            return this;
        }

        public ICharacterBuilderStats WithAge(int age)
        {
            _character.Age = age;
            return this;
        }

        public ICharacterBuilderStats Str(int strength)
        {
            _character.Strength = strength;
            return this;
        }

        public ICharacterBuilderStats Agi(int agility)
        {
            _character.Agility = agility;
            return this;
        }

        public ICharacterBuilderStats Int(int intelligence)
        {
            _character.Intelligence = intelligence;
            return this;
        }

        public ICharacterBuilderStats HP(int hp)
        {
            _character.HP = hp;
            _character.MaxHP = hp;
            return this;
        }

        public ICharacterBuilderStats Gold(int gold)
        {
            _character.Gold = gold;
            return this;
        }

        public Character Value()
        {
            return _character;
        }
    }
}
