using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("輸入一個有意義的英文敘述字串:");
            var senteseStr=Console.ReadLine().ToLower();
            var sentese = senteseStr.Split(' ');
            var result = sentese.GroupBy(x => x).Select(y => $"{y.Key}:{y.Count()}");
            Console.WriteLine(string.Join(Environment.NewLine, result));
            
            
            
            Console.ReadLine();
        }
    }
}
