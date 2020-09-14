using System;
using System.Threading.Tasks;
using name.heby;
using name.heby;
using name.heby._0;
using name.heby.Async;
using name.heby.IFDemo;
using name.heby.ObjectDemo;
using name.heby.Reflection;
using name.heby.Serialization;

namespace name.heby
{
    class Program
    {
        static async Task Main(string[] args)
        {
            // new StringTest().stringTest1();
            // new NumTest().numTest1();
            // new IfTest().IfTest1();
            // new DictorynaryTest().ListTest();Z

            // Person p = new Person("aa", "bb", "cc");
            // p.ConsoleTestNull();
            // new Dictionary().DictionaryTest1();
            // new DataType().test();
            // new StringArrDemo().StrTest();
            // await new ASyncTest().AsyncTest1();
            // ConnectionTest.ShowLINQ();
            // SortTest.ListCars();
            // EnumerableTest.Test();
            // ReflectionTest.Test();
            // XMLSerilizeTest.Test();
            // FunctionTest.Test();
            EqualTest.Test();
        }
    }
}