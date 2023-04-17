using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GitTest_RE.Item
{
    internal class Missile : Item
    {
        string name = "미사일";


        public void UesMissile()
        {
            UseItem(name);
            Console.WriteLine("미사일 던지기");
        }

    }
}
