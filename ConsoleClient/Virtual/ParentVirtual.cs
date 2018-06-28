using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleClient.Virtual
{
    public  class ParentVirtual
    {
        public string s = "";
        public string Factory()
        {
            return "Parent";
        }
        public virtual string FactoryVirtual()
        {
            return "ParentVirtual";
        }
    }
}
