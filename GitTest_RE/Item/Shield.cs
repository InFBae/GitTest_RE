using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE.Item
{
    internal class Shield : Item
    {
        private Shield() { }

        public void UseShield()
        {
            UseItem();
            Console.WriteLine("실드를 사용");
        }
    }
}
