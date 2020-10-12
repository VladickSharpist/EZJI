using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuri
{
    class figuri
    {
        public void Fun()
        {

            Console.WriteLine("1 квадрат \n2 треугольник \n3 ромб ");
            int con = int.Parse(Console.ReadLine());

            switch (con)
            {
                case 1:
                    {
                        int a, b;
                        Console.WriteLine("введите длины сторон");
                        a = int.Parse(Console.ReadLine());
                        b = int.Parse(Console.ReadLine());

                        for (int i = 0; i < a; i++)
                        {
                            for (int j = 0; j < b; j++)
                            {
                                Console.Write("0");
                            }

                            Console.WriteLine();
                        }

                    }
                    break;
                case 2:
                    {
                        int a, b = 1;
                        Console.WriteLine("введите длинe высоты ");
                        a = int.Parse(Console.ReadLine());


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
                        int a, b = 1;
                        Console.WriteLine("введите длину высоты");
                        a = int.Parse(Console.ReadLine());
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
                        for (int i = 0; i <= a; i++, b--, c++)
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
            Console.ReadLine();
            return;
        }
    }
}
