using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab11_2_Class
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("請輸入姓名:");
            string name = Console.ReadLine();
            Console.Write("請輸入身高(cm):");
            double height = double.Parse(Console.ReadLine());
            Console.Write("請輸入體重:");
            double weight = double.Parse(Console.ReadLine());

            Person p = new Person
            {
                Name = name,
                Height = height,
                Weight = weight
            };

            //  ShowBmi(p);

            p.ShowMyBmi();
           
            Person p2 = new Person();
            p2.ShowMyBmi();
            Console.ReadLine();
        }

        static void ShowBmi(Person person)
        {
            double bmiResult = person.Weight / Math.Pow(person.Height / 100, 2);
            Console.WriteLine($"{person.Name}BMI{bmiResult}");
        }
    }

    public class Person
    {
        public Person()
        {
            Console.WriteLine("new a instance..");
            Name = "Someone";
            Height = 170;
            Weight = 70;

        }
        public string Name { get; set; }
        public double Height { get; set; }
        public double Weight { get; set; }

        public void ShowMyBmi()
        {
            double result =  Weight / Math.Pow(Height/100, 2);
            Console.WriteLine(result);
        }
    }
}
