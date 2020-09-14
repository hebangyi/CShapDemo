using System;

namespace name.heby
{
    public class StringArrDemo
    {
        public void StrTest()
        {
            string[] words = new string[]
            {
                "The",      // 0                   ^9
                "quick",    // 1                   ^8
                "brown",    // 2                   ^7
                "fox",      // 3                   ^6
                "jumped",   // 4                   ^5
                "over",     // 5                   ^4
                "the",      // 6                   ^3
                "lazy",     // 7                   ^2
                "dog"       // 8                   ^1
            };              // 9 (or words.Length) ^0

            // the last word
            Console.WriteLine($"The last word is {words[^1]}");
            
            // 范围[0..^0] 表示整个范围, 就像[0,words.Length] 表示整个范围
            Console.WriteLine(words[0..^0]);
            Console.WriteLine(words[0..words.Length]);
            
            
            
            
        }
    }
    
}