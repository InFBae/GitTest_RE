using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE.Item
{
    internal class Booster : Item
    {
        string name = "부스터";

        public void UseBooster()
        {
            UseItem(name);
            Console.WriteLine("부스터 사용");
        }
    }
}
