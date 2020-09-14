using System;

namespace name.heby
{
    public class DataType
    {
        public void test()
        {
            var item = (Name : "eggplant", Price : 1.99m, perPackage : 3);
            var date = DateTime.Now;
            // 格式化
            // https://docs.microsoft.com/zh-cn/dotnet/standard/base-types/formatting-types#format-strings-and-net-types
            Console.WriteLine($"On {date:d}, the price of {item.Name} was {item.Price:C2} per {item.perPackage} items.");
        }
        
    }
}