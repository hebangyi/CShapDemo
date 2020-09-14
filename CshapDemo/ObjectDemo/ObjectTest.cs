using System;

namespace name.heby.ObjectDemo
{
    /// <summary>
    /// 面向对象化测试
    /// </summary>
    // 简单类型
    public class Simepleclass
    {
        // 构造函数
        public Simepleclass()
        {
        }

        // 属性
        string sampleField;
        
        // 如果有对属性值做特殊处理
        private int _sample;

        // 对Sample值进行修改
        public int Sample
        {
            get => _sample;
            set => _sample = value;
        }

        // 匿名内部类
        public void anonymousType()
        {
            var sampleObject = new
            {
                FirstProperty = "A",
                SecondeProperty = "B"
            };
        }
        
        
        // 元组
        public void TupleTest()
        {
            (double, int) t1 = (4.5, 3);
            Console.WriteLine($"Tuple with elements {t1.Item1} and {t1.Item2}.");
            // Output:
            // Tuple with elements 4.5 and 3.
    
            (double Sum, int Count) t2 = (4.5, 3);
            Console.WriteLine($"Sum of {t2.Count} elements is {t2.Sum}.");
            // Output:
            // Sum of 3 elements is 4.5.
        }
        
    }


    public class ClassA
    {
        
    }

    /// <summary>
    /// 继承
    /// </summary>
    public class ClassB : ClassA
    {
        
    }

    /// <summary>
    /// 接口
    /// </summary>
    interface ISampleInterface
    {
        void DoSomething();
    }

    
    
    // 结构,这个
    public struct SampleStruct : ISampleInterface
    {
        /// <summary>
        /// 继承
        /// </summary>
        public void DoSomething()
        {
        }
    }


    /// <summary>
    /// 泛型
    /// </summary>
    /// <typeparam name="T"></typeparam>
    public class SampleGeneric<T>
    {
        public T Field;
    }
    
}