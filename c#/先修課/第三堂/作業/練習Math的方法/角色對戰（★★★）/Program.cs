using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace 角色對戰_____
{
    internal class Program
    {
        public static void Main(string[] args)
        {
            MyCharacter c1 = new MyCharacter();
            MyCharacter c2 = new MyCharacter();
            Console.WriteLine("攻擊前...");
            c1.ShowInfo();
            c2.ShowInfo();
            Console.WriteLine("攻擊後...");
            Battle(c1, c2);
            c1.ShowInfo();
            c2.ShowInfo();

            Console.ReadLine();
        }

        static void Battle(MyCharacter ch1, MyCharacter ch2)
        {
            ch1.Attack(ch2);
            ch2.Attack(ch1);
        }
    }

    public class MyCharacter
    {
        public MyCharacter()
        {
            Console.WriteLine("請輸入角色名稱：");
            Name = Console.ReadLine();
            Console.WriteLine("請輸入血量：");
            Hp = int.Parse(Console.ReadLine());
            Console.WriteLine("請輸入攻擊力：");
            AttackDamage = int.Parse(Console.ReadLine());
        }
        public string Name { get; set; }
        public int AttackDamage { get; set; }

        public int Hp { get; set; }

        public void ShowInfo()
        {
            Console.WriteLine($"{Name} 的血量：{Hp}，攻擊力：{AttackDamage}點");
        }

        public void Attack(MyCharacter enemy)
        {
            enemy.Hp = enemy.Hp - AttackDamage;
            if (enemy.Hp < 0)
            {
                enemy.Hp = 0;
            }
        }

    }
}
