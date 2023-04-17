using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE
{
    internal class Character
    {
        protected string name;
        protected string charURL;
        protected virtual void setName(string name)
        {
            this.name = name;
        }
        
        
        public string getName()
        {
            return name;
        }
    }
}
