using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE
{
    public abstract class Cart : IHitable
    {
        protected int drift;
        protected int acceleration;
        protected int cornering;
        protected int boosterTime;
        protected int boosterCharge;
        protected string name;

        public void HitCart(Cart cart)
        {
            Console.WriteLine("{0} 과 {1}이 부딫혔습니다.", name, cart.name);
        }
    }
}
