using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using System.Xml.Schema;

namespace Q5_StudentObject
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student("s11001", "Dann");
            //https://learn.microsoft.com/zh-tw/dotnet/api/system.collections.generic.list-1?view=net-7.0  利用list方法 用出選得課和學分
            List<Subject> list1 = new List<Subject>();
            //subjectsList1.Add(new Subject() { SubjectName = "微積分", SubjectCredit = 4 });
            list1.Add(new Subject("微積分", 4));   //新增科目和學分
            list1.Add(new Subject("線性代數", 3));
            list1.Add(new Subject("普通物理", 3));
            list1.Add(new Subject("物理實驗", 1));

            ShowStudentDetail(student1);
            int total = 0;
            foreach (Subject Subject1 in list1) //把選課清單中的科目一一拿出來
            {
                Console.WriteLine($"          {Subject1.SubjectName},{Subject1.SubjectCredit}學分");
                total += Subject1.SubjectCredit;
            }
            Console.WriteLine($"總共{total}學分");
            Console.WriteLine("-----------------------------------------");
            Student student2 = new Student("s11002", "Bill");
            List<Subject> list2 = new List<Subject>();
            list2.Add(new Subject("視唱", 3)); //新增科目和學分
            list2.Add(new Subject("和弦", 4));

            ShowStudentDetail(student2);
            int total2 = 0;
            foreach (Subject Subject2 in list2)//把選課清單中的科目一一拿出來
            {
                Console.WriteLine($"          {Subject2.SubjectName},{Subject2.SubjectCredit}學分");
                total2 += Subject2.SubjectCredit;
            }
            Console.WriteLine($"總共{total2}學分");
            Console.WriteLine("-----------------------------------------");
            Console.ReadLine();
        }
        static void ShowStudentDetail(Student student) //利用這個方法呼叫學號 姓名 選課
        {
            Console.WriteLine($"學號:{student.StudentId}");
            Console.WriteLine($"姓名:{student.StudentName}");
            Console.WriteLine("選課:");
        }
    }
    public class Student  //學生類別
    {
        public string StudentId { get; set; } //學生學號
        public string StudentName { get; set; } //學生姓名
        public Student(string studentName, string studentId) //用建構函式()裡有放string studentId, string studentName 所以上面new student後面可以
        {                                                   //直接輸入studentId, studentName 

            StudentId = studentId;
            StudentName = studentName;
            StudentId = studentId;
        }
    }
    public class Subject //科目類別
    {
        public string SubjectName { get; set; } //科目名字
        public int SubjectCredit { get; set; }//科目學分
        public Subject(string subjectName, int subjectCredit)  //用建構函式()裡有放string subjectName, int subjectCredit 所以上面新增list後面可以
        {                                                      //直接輸入subjectName,subjectCredit
            SubjectName = subjectName;
            SubjectCredit = subjectCredit;
        }
    }
}
