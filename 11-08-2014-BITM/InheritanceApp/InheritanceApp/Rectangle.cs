using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Rectangle:Value
    {
        public int GetArea()
        {
            int res = GetHeight(5)*GetValue(10);
            return res;
        }
    }
}
