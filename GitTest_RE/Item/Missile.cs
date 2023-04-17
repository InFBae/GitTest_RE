using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE.Item
{
    internal class Missile : Item
    {
        private Missile() { }

        public void UseMissile()
        {
            UseItem();
            Console.WriteLine("미사일 발사");
        }
    }
}
