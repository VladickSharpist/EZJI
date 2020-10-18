using System;
namespace Counter
{
    class obj
    {
        public static int count;
        public obj()
        {
            Console.WriteLine("Object created");
            count++;
        }
    }
    public class Cou
    {
        private static void Fun()
        {
            obj first = new obj();
            obj second = new obj();
            obj third = new obj();
            obj fourth = new obj();
        }
       public static void MyFun()
        {
            Fun();
            Console.WriteLine($"Kol-vo obj: {obj.count}");
        }
    }
}
