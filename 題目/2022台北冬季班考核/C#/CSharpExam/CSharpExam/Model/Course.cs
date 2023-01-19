using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CSharpExam.Model
{
    class Course
    {
        /// <summary>
        /// 課程ID
        /// </summary>
        public string CourseId { get; set; }

        /// <summary>
        /// 課程名稱
        /// </summary>
        public string Name { get; set; }
        
        /// <summary>
        /// 指導教師
        /// </summary>
        public string Teacher { get; set; }

        /// <summary>
        /// 課程教室
        /// </summary>
        public string Classroom { get; set; }

        /// <summary>
        /// 學分
        /// </summary>
        public int Credit { get; set; }
    }
}
