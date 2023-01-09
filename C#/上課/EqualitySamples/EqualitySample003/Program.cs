using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualitySample003
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int i = 10;
            int j = 10;
            Console.WriteLine($"i.Equals(j) is +{i.Equals(j)}");
            MyRectangle r1 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r2 = new MyRectangle { Width = 5, Height = 5 };
            MyRectangle r3 = r2;
            Console.WriteLine($"r1.Equals(r2) is + {r1.Equals(r2)}");
            Console.WriteLine($"r2.Equals(r3) is + {r2.Equals(r3)}");

            Console.WriteLine("改名呼叫Equals");
            Console.WriteLine(r1.ToString());
            Console.ReadLine();
        }
    }
    class MyRectangle : IEquatable<MyRectangle>
    {
        public int Width { get; set; }
        public int Height { get; set; }

        public override bool Equals(object obj)
        {
            return Equals(obj as MyRectangle);
        }

        public bool Equals(MyRectangle other)
        {
            return !(other is null) &&
                   Width == other.Width &&
                   Height == other.Height;
        }

        public override int GetHashCode()
        {
            int hashCode = 859600377;
            hashCode = hashCode * -1521134295 + Width.GetHashCode();
            hashCode = hashCode * -1521134295 + Height.GetHashCode();
            return hashCode;
        }

        public static bool operator ==(MyRectangle left, MyRectangle right)
        {
            return EqualityComparer<MyRectangle>.Default.Equals(left, right);
        }

        public static bool operator !=(MyRectangle left, MyRectangle right)
        {
            return !(left == right);
        }

        public override string ToString()
        {
            return $"{Width},{Height}";
            //return base.ToString();
        }
    }
}
