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
        protected string charFileURL;

        protected void setName(string name)
        {
            this.name = name;
        }
        protected void setCharFileURL(string name)
        {
            this.charFileURL = name;
        }

        public string getName()
        {
            return name;
        }
    }
}
