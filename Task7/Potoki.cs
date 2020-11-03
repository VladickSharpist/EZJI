using System;
using System.Threading;

namespace Task7_Potoki
{
    class Try
    {
        static void Main(string[] args)
        {
            Thread myThread = new Thread(new ThreadStart(Count));
            myThread.Start();
            for (int i = 1; i < 51; i++)
            {
                Console.WriteLine("3 Kol-vo vivoda: " + i);
                Thread.Sleep(1);
                if (i ==50)
                {
                    Console.WriteLine("3 is a WINNER!!!");
                    Environment.Exit(0);
                }
            }

            Console.ReadLine();
        }

        public static void Count()
        {
            for (int i = 1; i < 51; i++)
            {
                Console.WriteLine("97 Kol-vo vivoda: "+i);
                Thread.Sleep(1);
                if (i == 50)
                {
                    Console.WriteLine("97 is a WINNER!!!");
                    Environment.Exit(0);
                }
            }
        }
    }
}
