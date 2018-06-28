using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient.Virtual
{
    public class Children:ParentVirtual
    {
        public override string FactoryVirtual()
        {
            return base.FactoryVirtual()+"Children"+base.FactoryVirtual();
        }
    }
}
