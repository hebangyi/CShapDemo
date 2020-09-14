using System;
using System.Reflection;

namespace name.heby.Reflection
{
    /// <summary>
    /// 反射测试
    /// </summary>
    public class ReflectionTest
    {
        public static void Test()
        {
            // 反射
            int i = 42;
            Type type = i.GetType();
            // 反射int 类
            Console.WriteLine(type);
            
            // Using Reflection to get informcation of Ansembly
            // 反射加载程序集
            Assembly info = typeof(int).Assembly;
            Console.WriteLine(info);
            
        }
    }
}