using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExam.Model
{
    class Student
    {
        /// <summary>
        /// 學生姓名
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// 性別
        /// </summary>
        public GenderOption Gender { get; set; }

        /// <summary>
        /// 學號
        /// </summary>
        public string StudentId { get; set; }

        /// <summary>
        /// 選課
        /// </summary>
        public List<string> CourseList { get; set; }
    }

    enum GenderOption
    {
        Male,
        Female
    }
}
