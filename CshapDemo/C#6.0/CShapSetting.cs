using System;

namespace name.heby
{
    /// <summary>
    /// C# 6.0 新特性
    /// </summary>
    public class Person
    {
        public string FirstName { get; private set; }
        public string LastName { get; private set; }
        /// <summary>
        /// 初始化属性方法
        /// </summary>
        public string MiddleName { get; } = "";

        public Person(string first, string middle, string last)
        {
            FirstName = first;
            LastName = last;
            MiddleName = middle;
        }
        
        /// <summary>
        /// 复写的相关方法
        /// </summary>
        /// <returns></returns>
        public override  string ToString() => FirstName + "    " + LastName;

        public string AllCaps()
        {
            FirstName = FirstName.ToUpper();
            LastName = LastName.ToUpper();
            return ToString();
        }


        public void ConsoleTest()
        {
            Console.WriteLine($"The acrage word length is : {AllCaps():F2}");
        }

        /// <summary>
        /// 使用非空判断
        /// </summary>
        public void ConsoleTestNull()
        {
            Console.WriteLine(FirstName?.Length);
            String nRef = null;
            Console.WriteLine(nRef?.Length);
            Console.WriteLine(FirstName?.Length);
            Console.WriteLine(nRef);
            Console.WriteLine(FirstName?.Length);
        }
        
    }
}