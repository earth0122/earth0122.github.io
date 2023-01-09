using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AllClassSample001
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyShape rect = new MyRectangle() { Width = 10, Height = 10 };
            Console.WriteLine($"方形的面積是{rect.GetArea()}");
            MyShape circle = new MyCircle() { Radius = 3 };
            Console.WriteLine($"圓形的面積是{circle.GetArea()}");
            Console.ReadLine();
        }
    }
    /// <summary>
    /// 宣告一個抽象類別
    /// </summary>
    public abstract class MyShape 
    {
        /// <summary>
        /// 宣告一個抽象方法
        /// </summary>
        /// <returns></returns>
        public abstract double GetArea();
    }
    public class MyRectangle : MyShape
    {
        public double Width { get; set; }
        public double Height { get; set; }        
        public override double GetArea()
        {
            return Width*Height;
        }
    }
    public class MyCircle : MyShape
    {
        public double Radius { get; set; }
        public override double GetArea()
        {
            return Math.PI*Math.Pow(Radius, 2);
        }
    }
}
