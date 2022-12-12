using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JsonSample001
{

    //public class Rootobject
    //{
    //    public Class1[] Property1 { get; set; }
    //}

    public class Class1
    {
        public bool success { get; set; }
        public Result result { get; set; }
    }

    public class Result
    {
        public string resource_id { get; set; }
        public Field[] fields { get; set; }
        public Record[] records { get; set; }
        public int limit { get; set; }
        public int offset { get; set; }
        public int total { get; set; }
    }

    public class Field
    {
        public string type { get; set; }
        public string id { get; set; }
    }

    public class Record
    {
        public int Seq { get; set; }
        public string name { get; set; }
        public string AlsoKnownAs { get; set; }
        public string shop { get; set; }
        public string address { get; set; }
        public string telephone { get; set; }
        public string awards { get; set; }
    }


}
