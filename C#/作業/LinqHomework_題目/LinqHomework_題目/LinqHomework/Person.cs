using System.Collections.Generic;

namespace LinqHomework
{
    /// <summary>
    /// 人
    /// </summary>
    public class Person
    {
        /// <summary>
        /// 姓名
        /// </summary>
        public string Name { get; set; }
        /// <summary>
        /// 媒體偏好國家
        /// </summary>
        public List<string> CountryPrefer { get; set; }
        /// <summary>
        /// 媒體偏好類型
        /// </summary>
        public List<string> TypePrefer { get; set; }
    }
}