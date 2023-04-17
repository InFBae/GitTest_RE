using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE.Item
{
    internal class Booster : Item
    {
        private Booster() { }

        public void UseBooster()
        {
            UseItem();
            Console.WriteLine("부스터 사용");
        }
    }
}
