﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GitTest_RE.Item
{
    internal class Item
    {
        // 아이템 생성
        string name;
        protected Item()
        { 
            this
        }
        protected void UseItem(string name)
        {
            Console.WriteLine($"{name}을 사용했습니다.");
        }
    }
}
