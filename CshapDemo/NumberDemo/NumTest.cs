using System;

namespace name.heby
{
    public class NumTest
    {
        public void NumTest1()
        {
            int a = 18;
            int b = 6;
            
            // 加法
            int c = a + b;
            Console.WriteLine(c);
            // 乘法
            c = a * b;
            Console.WriteLine(c);
            // 除法
            c = a / b;
            Console.WriteLine(c);

            int max = int.MaxValue;
            int min = int.MinValue;
            
            Console.WriteLine($"int min {min}, max {max}");
            int what = max + 3;
            Console.WriteLine($"An example of overflow : {what}");

            double doubleA = 5;
            double doubleB = 4;
            double doubleC = 2;
            double doubleD = (doubleA + doubleB) / doubleC;
            Console.WriteLine($"double D {doubleD}");

            double doubleMax = double.MaxValue;
            double doubleMin = double.MinValue;
            Console.WriteLine($"The range of double is {min} to {max}");

            decimal cDecimal = 1.0M;
            decimal dDecimal = 3.0M;
            Console.WriteLine(cDecimal / dDecimal);

            double radius = 2.50;
            double area = Math.PI * radius * radius;
            
            Console.WriteLine(area);
        }
        
    }
}