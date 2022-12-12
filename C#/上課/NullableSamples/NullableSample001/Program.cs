using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NullableSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int? i = 10;

            if (i.HasValue)
            {
                Console.WriteLine(i);
            }
            i = null;
            if (!i.HasValue)
            {
                Console.WriteLine(i.GetValueOrDefault());
            }
            if (i == null)
            {
                Console.WriteLine("i is null");
            }
            Console.ReadLine();
            
        }
    }
}
