using System;

namespace name.heby
{
    public class StringTest
    {
        public void StringTest1()
        {
            string greenting = "       Hello World!    ";
            // $ 中可以包含变量
            // {} 中包含变量信息
            Console.WriteLine($"[{greenting}]");

            // 去除前空格
            string trimmed = greenting.TrimStart();
            Console.WriteLine($"[{trimmed}]");

            // 去除后空格
            trimmed = greenting.TrimEnd();
            Console.WriteLine($"[{trimmed}]");

            // 去除所有空格
            trimmed = greenting.Trim();
            Console.WriteLine($"[{trimmed}]");

            // 替换字符串
            string sayHello = "Hello World!";
            Console.WriteLine(sayHello);
            sayHello = sayHello.Replace("Hello", "Greetings");
            Console.WriteLine(sayHello);

            // 搜索字符串
            string songLyrics = "You say goodbye, and I say hello";
            Console.WriteLine(songLyrics.Contains("goodbye"));
            Console.WriteLine(songLyrics.Contains("greetings"));

            // 是否以某个字符串开始或结束Console.WriteLine(songLyrics.StartsWith("You"));Console.WriteLine(songLyrics.StartsWith("goodbye"));

            Console.WriteLine(songLyrics.EndsWith("hello"));
            Console.WriteLine(songLyrics.EndsWith("goodbye"));

            // sysout
            //            [       Hello World!    ]
            //                [Hello World!    ]
            //                [       Hello World!]
            //                [Hello World!]
            //            Hello World!
            //                Greetings World!
            //            True
            //                False
            //            True
            //                False
            //            True
            //                False
        }
    }
}