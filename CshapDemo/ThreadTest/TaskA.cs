using System;
using System.Linq;
using System.Threading;
using System.Threading.Tasks;

namespace name.heby
{
    public class ThreadPoolTest
    {
        /// <summary>
        /// 线程池测试
        /// Task 类在 System.Threading.Tasks 命名空间下
        /// 始一个Task最简单的办法就是使用 Task.Run方法传入一个Action委托即可
        /// Task默认使用的线程池是后台线程
        /// Task.Run 返回一个对象,可以用来监控其执行过程
        /// Task.Run 之后,我们没有调用Start , 因为该方法创建的是 热任务, 也可以创建冷任务,但是很少这样做
        /// Task有一个Status属性,可以获得Task的执行状态
        /// 调用task的Wait方法会阻塞直到Wait完成,相当于thread上的join方法
        /// 
        /// </summary>
        public void TaskTest1()
        {
            // 最简单的线程测试
            Task task = Task.Run(() => { Console.WriteLine("Hello from the thread pool"); });
            Console.WriteLine(task.IsCompleted); // false
            task.Wait(); // 阻塞,直到任务完成
            Console.WriteLine(task.IsCompleted); // true
            // Console.ReadLine();
        }


        public void TaskTest2()
        {
            Task<int> task = Task.Run(() =>
            {
                Console.WriteLine("Foo");
                return 3;
            });

            int result = task.Result; // 如果task 没完成,那么就阻塞
            Console.WriteLine(result); // 3
        }

        /// <summary>
        /// Task 可以传播异常
        /// 
        /// </summary>
        /// <exception cref="Exception"></exception>
        public void TaskTest3()
        {
            Task task = Task.Run(() => { throw null; });
            try
            {
                task.Wait(); // 在获得异常处理的时候,在Wait方法和调用Result阻塞的时候,可以通过try cache 捕获异常
            }
            catch (AggregateException aex)
            {
                if (aex.InnerException is NullReferenceException)
                {
                    Console.WriteLine("Null");
                }
                else
                {
                    throw;
                }
            }
        }

        /// <summary>
        /// Continuation 会对Task说,当你结束的时候,继续再做点其它的事
        /// Continuation 通常通过回调的方式实现
        ///     当操作结束就开始执行
        /// </summary>
        public void TaskTest4()
        {
            Task<int> PrimeNumberTask = Task.Run(() =>
                Enumerable.Range(2, 3000000).Count(n =>
                    Enumerable.Range(2, (int) Math.Sqrt(n) - 1).All(i => n % i > 0)
                ));

            var awaiter = PrimeNumberTask.GetAwaiter();
            // 触发完成后的函数
            // 任何可以暴露下列两个方法和一个属性的对象就是awaiter
            // OnCompleted() 是INotifyCompletion接口的一部分
            // GetResult()
            // 一个叫做IsCompleted 的 bool 属性
            awaiter.OnCompleted(() =>
            {
                // 获得任务的执行结果
                int result = awaiter.GetResult(); // 如果使用GetResult ,则会抛出原异常
                Console.WriteLine(result);
            });
            Console.ReadLine();
        }

        /// <summary>
        /// 避免同步上下文的行为
        /// </summary>
        public void TaskTest5()
        {
            Task<int> PrimeNumberTask = Task.Run(() =>
                Enumerable.Range(2, 3000000).Count(n =>
                    Enumerable.Range(2, (int) Math.Sqrt(n) - 1).All(i => n % i > 0)
                ));

            // 关闭同步上下文
            var awaiter = PrimeNumberTask.ConfigureAwait(false).GetAwaiter();
            // 触发完成后的函数
            // 任何可以暴露下列两个方法和一个属性的对象就是awaiter
            // OnCompleted() 是INotifyCompletion接口的一部分
            // GetResult()
            // 一个叫做IsCompleted 的 bool 属性
            awaiter.OnCompleted(() =>
            {
                // 获得任务的执行结果
                int result = awaiter.GetResult(); // 如果使用GetResult ,则会抛出原异常
                Console.WriteLine(result);
            });
            Console.ReadLine();
        }

        /// <summary>
        /// ContinueWith 的方式挂载执行方法
        /// </summary>
        public void TaskTest6()
        {
            Task<int> PrimeNumberTask = Task.Run(() =>
                Enumerable.Range(2, 3000000).Count(n =>
                    Enumerable.Range(2, (int) Math.Sqrt(n) - 1).All(i => n % i > 0)
                ));
            // 
            PrimeNumberTask.ContinueWith(t => System.Console.WriteLine("AAA"))
                .ContinueWith(t => System.Console.WriteLine("BBB"));
            Console.ReadLine();
        }

        /// <summary>
        /// 使用TaskComplete
        /// 可以提供一个可手动执行的从属Task(节约资源)
        /// 并且可以指示在操作时设置结果或者完成或者抛出异常(可以调用Set* Try*)
        /// 更加灵活
        /// </summary>
        public void TaskTest7()
        {
            var tcs = new TaskCompletionSource<int>();

            new Thread(() =>
            {
                try
                {
                    Thread.Sleep(5000);
                    tcs.SetResult(42);
                }
                catch (Exception e)
                {
                    // Console.WriteLine(e);
                    // throw;
                    tcs.SetException(e);
                }
            }).Start();

            Task<int> task = tcs.Task;
            Console.WriteLine(task.Result);
        }

        /// <summary>
        /// Task Delay 使用异步事件的方式执行
        /// </summary>
        public void TaskTest8()
        {
            Task.Delay(5000).GetAwaiter().OnCompleted(() => { Console.WriteLine("Delay Completed"); });
            Console.ReadKey();
        }


        /// <summary>
        /// 使用Await简化异步调用流程
        /// </summary>
        public async void TaskTest9()
        {
            // 相当于执行 Task Complete 任务回调
            // 如果发生故障或异常,那么异常会被重新抛出
            // 如果一切正常,那么它的返回值会赋值给await表达式
            // ? 你可以 await什么
            // await 的对象有GetAwaiter 方法
            // 返回适当类型的GetResult方法
            // 一个bool类型的IsCompleted属性
            // ? await之后在哪个线程上执行
            // 如果在富客户端应用的UI线程上,同步上下文会保证后续是在原线程上执行
            // 否则,就会在task结束的线程上继续执行
            await GetPrimesCountAsync();
            Console.WriteLine("abc");
        }

        static Task<int> GetPrimesCountAsync()
        {
            Task<int> PrimeNumberTask = Task.Run(() =>
                Enumerable.Range(2, 3000000).Count(n =>
                    Enumerable.Range(2, (int) Math.Sqrt(n) - 1).All(i => n % i > 0)
                ));
            return PrimeNumberTask;
        }
    }

}