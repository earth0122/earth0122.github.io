using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 設計圓形類別___
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入圓形半徑");
            double radius = double.Parse(Console.ReadLine());
            MyCircle c = new MyCircle
            {
                Radius = radius,
            };
            //利用方法 ShowCircle(c) 來把下面需要運算的東西全部算完 藉此來讓main方法裡 更簡潔
            ShowCircle(c);
            Console.ReadLine();
        }
        //設一個方法ShowCircle 從下面類別MyCirle把需要用到的東西丟進來 讓以後需要運算這個東西 呼叫方法就可以算
        static void ShowCircle(MyCircle circle)
        {
            Console.WriteLine($"周長:{circle.GetPerimeter()},面積:{circle.GetArea()}");
        }
    }
    //限定在圓形類別MyCircle 在類別裡面設定物件半徑 周長 和面積 公式運算直接寫裡面 最後要補return回傳
    public class MyCircle
    {        
        public double Radius { get; set; } //半徑Radiu
        
        public double GetPerimeter() //周長Perimeter
        {
            double per = Math.Round(Radius*2*3.14, 2);
            return per;
        }
        
        public double GetArea() //面積Area
        {
            double area = Math.Round(Radius* Radius*3.14, 2);
            return area;
        }
    }
}
