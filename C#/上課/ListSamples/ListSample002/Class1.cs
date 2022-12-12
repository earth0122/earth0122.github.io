using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample002
{
    internal class Class1
    {
    }
    class MyRectange
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int Area
        {   /*這邊不用set的原因是
            面積的計算跟長和寬有關
            去set很奇怪*/
            get { return Width * Height; }
        }
    }
}
