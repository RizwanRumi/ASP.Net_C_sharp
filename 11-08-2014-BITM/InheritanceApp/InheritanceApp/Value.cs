using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceApp
{
    class Value
    {
        public int Height;
        public int Base;

        public int GetHeight(int x)
        {
            Height = x;
            return Height;
        }

        public int GetValue(int y)
        {
            Base = y;
            return Base;
        }
    }
}
