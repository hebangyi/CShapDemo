using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace name.heby.Async
{
    public class ASyncTest
    {
        public async Task AsyncTest1()
        {
            Task taskA = DoSometionA();
            Task taskB = DoSometionB();

            await Task.WhenAll(taskA, taskB);
            
            Console.WriteLine("AsyncTest1 Finished!");
        }

        public async Task DoSometionA()
        {
            Console.WriteLine("DoSomething A Begin!");
            // 任务等待停留 3s
            await Task.Delay(3000);
            Console.WriteLine("DoSomething A End!");
        }

        public async Task DoSometionB()
        {
            Console.WriteLine("DoSomething B Begin!");
            // 任务等待停留 3s
            await Task.Delay(5000);
            Console.WriteLine("DoSomething B End!");
        }
    }
}