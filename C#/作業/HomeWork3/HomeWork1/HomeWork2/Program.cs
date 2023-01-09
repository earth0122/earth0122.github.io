using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入階層(1-9):");
            var input = Console.ReadLine();
            var layer = int.Parse(input);
            var nums = Enumerable.Range(1, layer);
            var repeatNums = nums.Select(num => string.Join(string.Empty, Enumerable.Repeat(layer - num + 1), num));
            var result = string.Join(Environment.NewLine, repeatNums);
            Console.WriteLine(result);

            Console.WriteLine(
                string.Join(Environment.NewLine,
                Enumerable
        }
    }
}
