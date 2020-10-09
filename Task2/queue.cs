using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel.Design;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using Task2;

namespace Queue1
{
    class My_queue
    {

        //static public void Main(string[] args)
        //{
        //    queue Och = new queue();
        //    Qu_Menu(Och);
        //}

        static public void Qu_Menu(queue Och)
        {
            while(true)
            { 
               Console.WriteLine("\n1 Add element\n2 Extract element\n3 See head element\n4 See all queue\n5 Clean queue\n6 end");
               var a = int.Parse(Console.ReadLine());
                switch (a)
                {
                    case 1:
                        {
                            Och.Add_element();
                            Console.Clear();
                        }
                        break;
                    case 2:
                        {
                            var b = Och.Extract_element();
                            Console.Clear();
                            Console.WriteLine(b);
                        }
                        break;
                    case 3:
                        {
                            var b = Och.Chek_element();
                            Console.Clear();
                            Console.WriteLine(b);
                        }
                        break;
                    case 4:
                        {
                            Console.Clear();
                            Och.See_queue();
                        }
                        break;
                    case 5:
                        {
                            Och.Clean_queue();
                            Console.Clear();
                            Console.WriteLine("cleaned successfully");
                        }
                        break;
                    case 6:
                        {
                            Och.Clean_queue();
                            return;
                        }
                }

            }

        }
    }

    class queue
    {
        protected Queue<int> numbers = new Queue<int>();
        public void Add_element()
        {
            var a = int.Parse(Console.ReadLine());
            numbers.Enqueue(a);
            Console.Clear();
        }
        public int Extract_element()
        {
            if (numbers.Count() == 0)
            {
                Console.WriteLine("Queue is empty");
                return 0;
            }
            var b= numbers.Dequeue();
            return (b);
        }
        public int Chek_element()
        {
            if (numbers.Count() == 0)
            {
                Console.WriteLine("Queue is empty");
                return 0 ;
            }
            var b = numbers.Peek();
            return (b);
        }
        public void See_queue()
        {
            if(numbers.Count()==0)
            {
                Console.WriteLine("Queue is empty");
                return;
            }
            foreach (int element in numbers)
                Console.Write($"{element} ");
            Console.WriteLine();
        }
        public void Clean_queue()
        {
            numbers.Clear();
        }
    }
}
