using System;
using System.Threading;

namespace name.heby
{
    public class SynchronizationContextTest
    {
        SynchronizationContext _uiSyncContext;

        private string message;
        
        public SynchronizationContextTest()
        {
           message = "Before";
           Console.WriteLine(message);
           _uiSyncContext = SynchronizationContext.Current;
           new Thread(Work).Start();
        }


        void Work()
        {
            Thread.Sleep(5000);
            UpdateMessage("After");
        }

        void UpdateMessage(string messageTxt)
        {
            // 把委托 Marshal 给 UI 线程
            _uiSyncContext.Post(
                _ => message = messageTxt,null);
            
            // 调用 Post 就相当于调用 Dispatcher 或 Control 上面的 BeginInvoke 方法
        }
    }
}