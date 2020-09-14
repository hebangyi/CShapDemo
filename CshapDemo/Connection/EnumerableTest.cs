using System;

namespace name.heby
{
    /// <summary>
    /// 迭代器测试
    /// </summary>
    public class EnumerableTest
    {
        public static void Test()
        {
            foreach (var number in SomeNumbers())
            {
                Console.WriteLine(number.ToString() + "    ");
            }

            // Console.ReadKey();
        }

        public static System.Collections.IEnumerable SomeNumbers()
        {
            yield return 3;
            yield return 5;
            yield return 6;
        }
    }
}