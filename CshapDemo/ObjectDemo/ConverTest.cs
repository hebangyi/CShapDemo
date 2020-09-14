using System;

namespace name.heby.ObjectDemo
{
    public class ConverTest
    {
        public void Test()
        {
            byte[] bytes = new byte[4];
            // 转换
            BitConverter.ToInt32(bytes);
            string str = "123";
            int parseInt = Int32.Parse(str);
            Console.WriteLine(parseInt);
            
        }
    }
}