using System;
using System.Collections.Generic;

namespace name.heby
{
    public class Dictionary
    {
        public void DictionaryTest1()
        {
            var messages = new Dictionary<int, string>
            {
                [404] = "Page not Found",
                [302] = "Page moved, but left a forwarding address.",
                [500] = "The web server can't come out to play today."
            };
            
            Console.WriteLine(messages[302]);
        }
        
    }
}