using System;

namespace name.heby.ObjectDemo
{
    public class EunmTest
    {
        /// <summary>
        /// Enum 与值类型转换
        /// 对于任何枚举类型，枚举类型与其基础整型类型之间存在显式转换。 如果将枚举值转换为其基础类型，则结果为枚举成员的关联整数值。
        /// </summary>
        public void EnumCastTest()
        {
            Season a = Season.Autumn;
            Console.WriteLine($"Integral value of {a} is {(int)a}");  // output: Integral value of Autumn is 2

            var b = (Season)1;
            Console.WriteLine(b);  // output: Summer

            var c = (Season)4;
            Console.WriteLine(c);  // output: 4
        }
    }

    /// <summary>
    /// 默认情况下，枚举成员的关联常数值为类型 int；它们从零开始，
    /// 并按定义文本顺序递增 1。 可以显式指定任何其他整数数值类型作为枚举类型的基础类型。
    /// 还可以显式指定关联的常数值，如下面的示例所示：
    /// </summary>
    enum Season
    {
        Spring,
        Summer,
        Autumn,
        Winter,
    }


    enum ErrorCode
    {
        None = 0,
        Unknown = 1,
        ConnectionLost = 2,
        OutlierReading = 3
    }
    
}