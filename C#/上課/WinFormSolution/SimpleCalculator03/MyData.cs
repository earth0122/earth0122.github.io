using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SimpleCalculator03
{
    internal class MyData
    {
        private int _x;
        private int _y;
        
        public int X
        {
            get { return _x; }
            set { _x = value; }
        }
        public int Y
        {
            get { return _y; }
            set { _y = value; }
        }
        public int Add()
        {
            return X + Y;
        }
        public int Less()
        { 
            return X - Y;
        }
    }
}
