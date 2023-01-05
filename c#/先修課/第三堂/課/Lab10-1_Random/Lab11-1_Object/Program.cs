using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_1_Object
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入姓名:");
            string name = Console.ReadLine();
            Console.Write("請輸入身高(cm):");
            double height =double.Parse(Console.ReadLine());           
            Console.Write("請輸入體重:");
            double weight =double.Parse(Console.ReadLine());

            //double bmiResult = weight / Math.Pow((height/100),2);
            //Console.WriteLine($"{name}的Bmi為{bmiResult}");
            ShowBmi(name, height, weight);

            Console.ReadLine();
        }  
        static void ShowBmi(string name, double height, double weight)
        {
            double bmiResult = weight / Math.Pow((height / 100), 2);
            Console.WriteLine($"{name}的Bmi為{bmiResult}");
        }
        
    }
}
