using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace TC_Fig
{
    class Fig_Ex
    {
        public void Menu()
        {

            Console.WriteLine("1 square \n2 triangle \n3 rhombus ");
            int con = int.Parse(Console.ReadLine()), a = 0;
            try
            {

                switch (con)
                {
                    case 1:
                        {

                            Console.WriteLine("enter the lengths of the sides");
                            a = int.Parse(Console.ReadLine());
                            ChekExtension(a);
                            for (int i = 0; i < a; i++)
                            {
                                for (int j = 0; j < a; j++)
                                {
                                    Console.Write("0 ");
                                }

                                Console.WriteLine();
                            }

                        }
                        break;
                    case 2:
                        {
                            int b = 1;
                            Console.WriteLine("enter the length of the height ");
                            a = int.Parse(Console.ReadLine());
                            ChekExtension(a);
                            for (int i = 0; i < a; i++, b++)
                            {
                                for (int j = 0; j < b; j++)
                                {
                                    Console.Write("0");
                                }

                                Console.WriteLine();
                            }

                        }
                        break;
                    case 3:
                        {
                            int b = 1;
                            Console.WriteLine("enter the length of the height");
                            a = int.Parse(Console.ReadLine());
                            ChekExtension(a);
                            int c = a;
                            for (int i = 0; i < a; i++, b++, c--)
                            {
                                for (int j = 0; j < c; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = 0; j < b * 2; j++)
                                {
                                    Console.Write("0");
                                }
                                Console.WriteLine();
                            }
                            for (int i = 0; i < a; i++, b--, c++)
                            {
                                for (int j = 0; j < c; j++)
                                {
                                    Console.Write(" ");
                                }
                                for (int j = 0; j < b * 2; j++)
                                {
                                    Console.Write("0");
                                }
                                Console.WriteLine();
                            }
                        }
                        break;
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine($"{ex.Message} ({a})");

            }
            Console.ReadLine();
            return;
        }

        static public void ChekExtension(int data)
        {
            try
            {
                if (data < 0)
                {
                    throw new Exception("length less than 0");
                }
            }

            finally { };
        }
    }
}
