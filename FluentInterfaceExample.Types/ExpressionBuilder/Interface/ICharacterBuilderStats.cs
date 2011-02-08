using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentInterfaceExample.Types.ExpressionBuilder.Interface
{
    public interface ICharacterBuilderStats
    {
        ICharacterBuilderStats HP(int hp);
        ICharacterBuilderStats Str(int strength);
        ICharacterBuilderStats Agi(int agility);
        ICharacterBuilderStats Int(int intelligence);
        ICharacterBuilderStats Gold(int gold);
    }
}
