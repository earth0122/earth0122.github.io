using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hackathon4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入年收入:");
            string moneyStr = Console.ReadLine();
            decimal money = decimal.Parse(moneyStr);
            decimal tax = NewMethod(money);

            Console.WriteLine(tax);
            Console.ReadLine();
        }

        private static decimal NewMethod(decimal money)
        {
            decimal tax;
            decimal rate1 = 0.05m;
            decimal rate2 = 0.12m;
            decimal rate3 = 0.2m;
            decimal rate4 = 0.3m;
            decimal rate5 = 0.4m;
            decimal rate6 = 0.5m;         
           
            //累進差值 所得稅率直接成稅率 再把多算的扣回來
            if (money < 540001)
            {
                tax = money * rate1;
            }
            else if (money < 1210001)
            {
                tax = money*rate2-540000*(rate2-rate1);
            }
            else if (money < 2420001)  
            {
                tax = money * rate3 - 540000 * (rate2 - rate1) - 1210000 * (rate3 - rate2);
            }
            else if (money < 4530001)
            {
                tax = money * rate4 - 540000 * (rate2 - rate1) - 1210000 * (rate3 - rate2)- 2420000*(rate4-rate3);
            }
            else if (money < 10310001)
            {
                tax = money *rate5- 540000 * (rate2 - rate1) - 1210000 * (rate3 - rate2) - 2420000 * (rate4 - rate3)-4530000*(rate5-rate4);
            }
            else
            {
                tax = money * rate6 - 540000 * (rate2 - rate1) - 1210000 * (rate3 - rate2) - 2420000 * (rate4 - rate3) - 4530000 * (rate5 - rate4)-10310000*(rate6-rate5);
            }

            return tax;
        }



    }
}
