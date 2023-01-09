using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExLinqSample010
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var teachers = CreateTeachers();
            var students = CreateStudents();
            var result =
                from t in teachers//想成先foreach把老師先抓出來Bill
                join s in students//在foreach出學生
                on t.ClassName equals s.ClassName //把班級一樣的抓出來
                select
                new //ResultInfo 變成匿名型別(只有get)
                { ClassName = t.ClassName, Teacher = t.Teacher, Student = s.Student };
            foreach (var item in result)
            {
                Console.WriteLine($"{item.ClassName}:{item.Teacher}:{item.Student}");
            }
            Console.ReadLine();
        }
        static List<TeacherInfo> CreateTeachers()
        {
            return new List<TeacherInfo>()
            { new TeacherInfo{ClassName="1A",Teacher="Bill" },
              new TeacherInfo{ClassName="1B",Teacher="David" }
            };
        }
        static List<StudentInfo> CreateStudents()
        {
            return new List<StudentInfo>()
            {
                new StudentInfo{ClassName="1A",Student="魯夫" },
                new StudentInfo{ClassName="1A",Student="索隆" },
                new StudentInfo{ClassName="1B",Student="櫻木" },
                new StudentInfo{ClassName="1A",Student="香吉士" },
                new StudentInfo{ClassName="1B",Student="流川楓" }
            };
        }
    }
    class TeacherInfo
    {
        public string ClassName { get; set; }
        public string Teacher { get; set; }
    }
    class StudentInfo
    {
        public string ClassName { get; set; }
        public string Student { get; set; }
    }
    class ResultInfo
    {
        public string ClassName {get; set; }
        public string Teacher { get; set; }
        public string Student { get; set; }
    }
}
