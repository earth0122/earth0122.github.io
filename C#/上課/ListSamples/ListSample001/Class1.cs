using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListSample001
{
    internal class Class1
    {
    }
    class MyRectangle
    {
        public string Name { get; set; }
        public int Width { get; set; }
        public int Height { get; set; }

        public int GetArea()
        {
            return Width*Height;
        }
    }
}
