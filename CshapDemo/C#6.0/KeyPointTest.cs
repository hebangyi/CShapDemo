using System;
using System.Collections.Generic;

namespace name.heby
{
    public class NameOf
    {
        /// <summary>
        /// 方便获取类型、成员和变量的简单字符串名称
        /// </summary>
        public void NameOfTest1()
        {
            Console.WriteLine(nameof(System.String));
            int j = 5;
            Console.WriteLine(nameof(j));
            List<string> names = new List<string>();
            Console.WriteLine(nameof(names));
        }

        /// <summary>
        /// 算符返回公共语言运行时将在托管内存中分配的字节数。 
        /// </summary>
        public void SizeOfTest()
        {
            ///sizeof(sbyte)	1
            //            sizeof(byte)	1
            //            sizeof(short)	2
            //            sizeof(ushort)	2
            //            sizeof(int)	4
            //            sizeof(uint)	4
            //            sizeof(long)	8
            //            sizeof(ulong)	8
            //            sizeof(char)	2
            //            sizeof(float)	4
            //            sizeof(double)	8
            //            sizeof(decimal)	16
            //            sizeof(bool)	1
        }
        
    }
}