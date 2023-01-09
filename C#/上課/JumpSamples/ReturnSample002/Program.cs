using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ReturnSample002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ReturnTryInt();
            int i = ReturnTryInt();

        }

        static int ReturnTryInt(int i)
        {
            try
            {
                Console.WriteLine("進入Try");
                if (i > 10)
                {
                    throw new Exception("故意發生例外");
                }
                return 99;
            }
            catch (Exception ex)
            {
                Console.WriteLine("進入Catch");
                Console.WriteLine(ex.ToString());
                return 88;

            }
            finally
            {
                Console.WriteLine("進入finally");
            }
        }
    }
}
