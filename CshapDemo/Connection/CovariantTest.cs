using System;
using System.Collections.Generic;

namespace name.heby
{
    /// <summary>
    /// 协变与逆变
    /// </summary>
    public class CovariantTest
    {
        public void test()
        {
            string str = "test";
            object obj = str;
            
            
            IEnumerable<string> strings = new List<string>();
            // 协变
            IEnumerable<object> objects = strings;
            
            // 逆变
            Action<object> actObject = SetObject;
            Action<string> actString = actObject;
        }

        static void SetObject(object o)
        {
                   
        }
    }
}