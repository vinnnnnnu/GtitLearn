using System;

namespace TryCal
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Console.WriteLine("please enter 2 ints");
            string x = Console.ReadLine();
            int xx = Convert.ToInt32(x);
            string y = Console.ReadLine();
            int yy = Convert.ToInt32(y);


            Add(xx, yy);
            Sub(xx, yy);
            Mul(xx, yy);
            
            Console.WriteLine("All Done");

            Console.ReadKey();



        }

        private static void Mul(int xx, int yy)
        {
            Console.WriteLine(xx * yy);
        }

        private static void Sub(int xx, int yy)
        {
            Console.WriteLine(xx - yy);
        }

        private static void Add(int xx, int yy)
        {
            Console.WriteLine(xx + yy);
        }
    }
}
