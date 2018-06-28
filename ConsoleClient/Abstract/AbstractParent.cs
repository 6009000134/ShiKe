using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient.Abstract
{
    public abstract class AbstractParent
    {
        public string Parent()
        {
            return "AbstractParent";
        }
        
        public abstract string ParentAbstract();
    }
}
