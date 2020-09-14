using System;
using System.Collections.Generic;

namespace name.heby._0
{
    public class CShap8Test
    {
        public void nullTest()
        {
            // 空值合并
            // 当左操作数计算为 null 时，才能使用运算符 ??= 将其右操作数的值分配给左操作数。
            List<int> numbers = null;
            int? i = null;
            
            numbers ??= new List<int>();
            numbers.Add(i ??= 17);
            numbers.Add(i ??= 20);
            
            Console.WriteLine(string.Join(" ", numbers));  // output: 17 17
            Console.WriteLine(i);  // output: 17
        }
    }
}