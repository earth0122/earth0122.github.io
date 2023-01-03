using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace 角色對戰
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyCharacter c_1 = new MyCharacter("Andy", 10, 3);
            MyCharacter c_2 = new MyCharacter("Jimmy", 10, 6);
            //MyCharacter c_1 = new MyCharacter("Andy", 1);
            //MyCharacter c_2 = new MyCharacter("Jimmy", 2);
            //function_1 p134
            AttackBefore(c_1, c_2);
            Battle(c_1, c_2);
            //funtion_1 end

            //function_2 p144
            Console.WriteLine("攻擊前.....");
            c_1.Echo_Character();
            c_2.Echo_Character();
            int r = 0;
            while (c_1.Hp > 0 && c_2.Hp > 0)
            {
                r++;
                Console.WriteLine($"第{r}攻擊後...");
                c_1.Echo_Attach(c_2);
                c_2.Echo_Attach(c_1);
            }
            //funtion_2 end
            Console.ReadLine();

        }
        static void AttackBefore(MyCharacter c_1, MyCharacter c_2)
        {
            Console.WriteLine("攻擊前.....");
            Console.WriteLine($"{c_1.Name} 的血量:{c_1.Hp}點，攻擊力:{c_1.Attack}");
            Console.WriteLine($"{c_2.Name} 的血量:{c_2.Hp}點，攻擊力:{c_2.Attack}");
        }
        static void Battle(MyCharacter c_1, MyCharacter c_2)
        {
            int round = 0;
            while (c_1.Hp > 0 && c_2.Hp > 0)
            {
                round++;
                Console.WriteLine($"第{round}攻擊後...");
                c_1.Hp -= c_2.Attack;//C_1的血量- C_2的攻擊
                c_2.Hp -= c_1.Attack;//
                c_1.Hp = c_1.Hp < 0 ? 0 : c_1.Hp;
                c_2.Hp = c_2.Hp < 0 ? 0 : c_2.Hp;
                Console.WriteLine($"{c_1.Name} 的血量:{c_1.Hp}點，攻擊力:{c_1.Attack}");
                Console.WriteLine($"{c_2.Name} 的血量:{c_2.Hp}點，攻擊力:{c_2.Attack}");
            }
            if (c_1.Hp == 0)
            {
                Console.WriteLine($"{c_1.Name}死亡 {c_2.Name}勝利");
            }
            else if (c_2.Hp == 0)
            {
                Console.WriteLine($"{c_2.Name}死亡 {c_1.Name}勝利");
            }
        }
    }
    public class MyCharacter
    {
        //public MyCharacter()
        //{
        //}
        public MyCharacter(string name, int r_id)
        {
            Name = name;
            Random_Character(r_id);
        }
        public MyCharacter(string name, int hp, int attack)
        {
            Name = name;
            Hp = hp;
            Attack = attack;
        }

        public string Name { get; set; }
        public int Hp { get; set; }
        public int Attack { get; set; }
        public void Echo_Character()
        {
            Console.WriteLine($"{Name} 的血量:{Hp}點，攻擊力:{Attack}");
        }
        public void Echo_Attach(MyCharacter p)
        {
            Hp -= p.Attack;
            Hp = Hp < 0 ? 0 : Hp;
            Console.WriteLine($"{Name} 的血量:{Hp}點，攻擊力:{Attack}");
        }

        public void Random_Character(int r_id)
        {
            Random random = new Random(r_id);
            Hp = random.Next(1, 10);
            Attack = random.Next(1, 10);
        }
    }
}
