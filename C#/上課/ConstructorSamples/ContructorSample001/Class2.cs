using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ContructorSample001
{
   static class FirstOrdefault
    {
        static string FirstOrDefault(List<string> source, Func<string, bool> predicate)
        {
            string result =null;
            
            foreach (var item in source)
            {
                if (predicate.Invoke(item))
                {
                    return item;
                }
            }
            return null;
            return result;
        }

        

    }
    

}
