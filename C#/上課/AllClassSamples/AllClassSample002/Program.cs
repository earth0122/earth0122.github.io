using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample002
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Class1 o1 = new Class1();
            o1.Execute();
            o1.Begin();
            Class2 o2 = new Class2();
            o2.Execute();
            o2.Begin();

            BaseClass o3 = new BaseClass();
            o3.Execute();
            o3.Begin();

            Console.ReadLine();

            


        }
    }
    public class BaseClass
    {
        public virtual void Execute()
        {
            Console.WriteLine("基底類別 Execute Method");
        }
        public virtual void Begin()
        {
            Console.WriteLine("基底類別 Begin Method");
        }
    }
    public class Class1 : BaseClass
    {
        public override void Execute()
        {
            Console.WriteLine("Class1繼承基底類別 Execute Method");
        }

    }
    public class Class2 : Class1
    {
        public override sealed void Execute()
        {
            Console.WriteLine("繼承Class1 Execute Method");
        }
        public override void Begin()
        {
            Console.WriteLine("繼承Class1 Begin Method");
        }
    }
}
