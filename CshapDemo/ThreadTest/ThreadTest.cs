using System;
using System.Diagnostics;
using System.Threading;
using ThreadState = System.Threading.ThreadState;

namespace name.heby
{
    public class ThreadTest
    {
        public void ThreadTestJoin()
        {
            System.Threading.Thread t = new System.Threading.Thread(WriteY);
            t.Start();
            /// 强制等待t线程结束
            t.Join();
            // 同时在主线程中打印
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }
            // 也有信号量的方式控制子线程阻塞
            
        }


        public void TestThreadParam()
        {
            // 线程初始化的时候使用Lambda表达式传入参数
            Thread t = new Thread(() => WriteY("abc"));
            // 逻辑直接写入Thread中
            t = new Thread(() =>
            {
                Console.WriteLine("abc");
            });
            // 设置前台线程与后台线程
            // t.IsBackground = true;
            // t.IsBackground = false;
            
            
            // 通过Start的方式传递参数
            t = new Thread(WriteY);
            t.Start("abc");
            
            // 提升线程优先级
            using (Process p = Process.GetCurrentProcess())
            {
                p.PriorityClass = ProcessPriorityClass.High;
            }
        }
        
        
        public void ThreadTestBlock()
        {
            // 线程是否阻塞
            bool blocked = (Thread.CurrentThread.ThreadState & ThreadState.WaitSleepJoin) != 0;
        }

        public void ThreadTest3()
        {
            // Thread 名称
            // Thread.CurrentThread.Name
            // Thread.CurrentThread.IsAlive
        }
        
        
        public void ThreadTest1()
        {
            System.Threading.Thread t = new System.Threading.Thread(WriteY);
            t.Start();
            
            // 同时在主线程中打印
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("x");
            }
        }
        
        
        

        void WriteY()
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("y");
            }
        }
        
        void WriteY(string a)
        {
            for (int i = 0; i < 1000; i++)
            {
                Console.Write("y");
            }
        }
        
    }
}