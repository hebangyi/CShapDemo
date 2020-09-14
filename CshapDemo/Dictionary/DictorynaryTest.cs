using System;
using System.Collections.Generic;
using System.Linq;

namespace name.heby
{
    public class DictorynaryTest
    {
        public void ListTest()
        {
            // 列表初始化
            var names = new List<string> {"<name>" , "Ana", "Felipe"};
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}");
            }
            
            // 列表添加
            Console.WriteLine();
            names.Add("Maria");
            names.Add("Bill");
            names.Remove("Ana");
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            
            // 通过索引进行访问, 不能超过索引长度
            Console.WriteLine($"My name is {names[0]}");
            Console.WriteLine($"I've added {names[2]} and {names[3]} to the list!");
            Console.WriteLine($"The list has {names.Count} people in it");
            
            // 重新设置names
            names[0] = "ABC";
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            
            // 查找names 列表,如果 IndexOf 将返回 -1,则没有找到 
            var index = names.IndexOf("Felipe");
            if (index != -1)
            {
                Console.WriteLine($"The name {names[index]} is at index {index}");
            }

            var notFound = names.IndexOf("Not Found");
            Console.WriteLine($"When an item is not found, IndexOf returns {notFound}");
            
            // 以字符串字母顺序,对列表进行排序
            names.Sort();
            foreach (var name in names)
            {
                Console.WriteLine($"Hello {name.ToUpper()}!");
            }
            
            // 其他类型列表
            var fibonacciNumbers = new List<int>{1,1};
            var previous = fibonacciNumbers[fibonacciNumbers.Count - 1];
            var previous2 = fibonacciNumbers[fibonacciNumbers.Count - 2];
            
            fibonacciNumbers.Add(previous + previous2);
            foreach (var item in fibonacciNumbers)
            {
                Console.WriteLine(item);
            }
        }
    }
}