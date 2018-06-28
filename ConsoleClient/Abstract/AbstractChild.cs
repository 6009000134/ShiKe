using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient.Abstract
{
    class AbstractChild:AbstractParent
    {
        public override string ParentAbstract()
        {
            return "AbstractChild";
        }
        public string Parent()
        {
            return base.Parent();
        }
    }
}
