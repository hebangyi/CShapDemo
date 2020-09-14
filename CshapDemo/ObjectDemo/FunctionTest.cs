using System;

namespace name.heby.ObjectDemo
{
    
    public class FunctionTest
    {
        // 声明匿名函数类型
        delegate void TestDelegate(string s);

        static void M(string s)
        {
            Console.WriteLine(s);
        }

        public static void Test()
        {
            // 
            // Original delegate syntax required
            // initialization with a named method.
            TestDelegate testDelA = new TestDelegate(M);
            
            // C# 2.0: A delegate can be initialized with
            // inline code, called an "anonymous method." This
            // method takes a string as an input parameter.
            TestDelegate testDelB = delegate(string s) { Console.WriteLine(s); };
            
            Func<string, string> testFuncb = delegate(string s) { Console.WriteLine(s);return null;};
            
            // C# 3.0. A delegate can be initialized with
            // a lambda expression. The lambda also takes a string
            // as an input parameter (x). The type of x is inferred by the compiler.
            TestDelegate testDelC = (x) => { Console.WriteLine(x); };
            
            testDelA("Hello. My name is M and I write lines.");
            testDelB("That's nothing. I'm anonymous and ");
            testDelC("I'm a famous author.");
            
        }
        
    }
}