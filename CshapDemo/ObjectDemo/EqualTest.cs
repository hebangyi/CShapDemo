namespace name.heby.ObjectDemo
{
    public class EqualTest
    {
        public static void Test()
        {
            EquipmentBean a = new EquipmentBean(){Num = 1,Str = "Hi"};
            EquipmentBean b = new EquipmentBean(){Num = 1,Str = "Hi"};

            bool areEqual = System.Object.ReferenceEquals(a, b);
            // False:
            System.Console.WriteLine("ReferenceEquals(a, b) = {0}", areEqual);
            // Assign b to a.
            b = a;
            // Repeat calls with different results.
            areEqual = System.Object.ReferenceEquals(a, b);
            // True:
            System.Console.WriteLine("ReferenceEquals(a, b) = {0}", areEqual);
            
        }
    }

    public class EquipmentBean
    {
        public int Num { get; set; }
        public string Str { get; set; }
        
        
    }

}