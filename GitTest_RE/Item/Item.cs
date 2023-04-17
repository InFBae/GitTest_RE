using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE.Item
{
    internal class Item
    {
        // 아이템 생성
        protected Item()
        {

        }
        protected void UseItem()
        {
            Console.WriteLine("아이템을 사용했습니다.");
        }
    }
}
