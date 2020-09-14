using System;

namespace name.heby
{
    public class Path
    {
        public void testExtension()
        {
            this.Add(1,2,3);
        }
    }
    
    public static class Extensions
    {
        /// <summary>
        ///  
        /// </summary>
        /// <param name="path"></param>
        /// <param name="x"></param>
        /// <param name="y"></param>
        /// <param name="z"></param>
        public static void Add(this Path path, double x, double y, double z)
        {
            Console.WriteLine($"x is {x}, y is {y} z is {z}");
        }
    }
}