using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace FluentInterfaceExample.Types.ExpressionBuilder.Interface
{
    public interface ICharacterBuilderClassType
    {
        ICharacterBuilderAge As(Character.ClassType classType);
    }
}
