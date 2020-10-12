using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace flag
{
    class Flag_Menu
    {
        public void flag_menu()
        {
            Console.WriteLine("1 American flag\n2 British flag\n3 Belarusian flag\n4 Best flag");
            var cond = int.Parse(Console.ReadLine());
            switch (cond)
            {
                case 1:
                    {
                        string[] arr = new string[3];
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Enter simble №{i}");
                            arr[i] = Console.ReadLine();
                           
                        }
                        Flag Am = new Flag(arr);
                        Am.American();
                    }
                    break;
                case 2:
                    {
                        string[] arr = new string[3];
                        for (int i = 0; i < 3; i++)
                        {
                            Console.WriteLine($"Enter simble №{i}");
                            arr[i] = Console.ReadLine();
                        }
                        Flag Br = new Flag(arr);
                        Br.British();
                    }
                    break;
                case 3:
                    {
                        string[] arr = new string[2];
                        for (int i = 0; i < 2; i++)
                        {
                            Console.WriteLine($"Enter simble №{i}");
                            arr[i] = Console.ReadLine();
                        }
                        Flag Bel = new Flag(arr);
                        Bel.Belarusian();
                        
                    }
                    break;
                case 4:
                    {
                        string[] arr = new string[6];
                        for (int i = 0; i < 6; i++)
                        {
                            Console.WriteLine($"Enter simble №{i}");
                            arr[i] = Console.ReadLine();
                            
                        }
                        Flag Best = new Flag(arr);
                        Best.Sergeis_flag();
                    }
                    break;

            }
        }
    }

    class Flag
    {
        public string[] arr;
        public Flag(string[] a) { arr = a; } 
    

        
        public void American()
        {
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write($"{arr[0]}");
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{arr[0]}");
                    Console.ResetColor();
                }
                Console.ForegroundColor = ConsoleColor.Red;
                Console.Write(' ');
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr[1]);
                }
                Console.ResetColor();
                Console.WriteLine();
                for (int j = 0; j < 4; j++)
                {
                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.Write($"{arr[0]}");
                    Console.ResetColor();
                    Console.Write($"{arr[0]}");
                }
                Console.Write(' ');
                for (int j = 0; j < 10; j++)
                {
                    Console.Write(arr[2]);
                }
                Console.WriteLine();
            }

            for (int i = 0; i < 3; i++)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                for (int j = 0; j < 19; j++)
                {
                    Console.Write(arr[1]);
                }
                Console.ResetColor();
                Console.WriteLine();
                for (int j = 0; j < 19; j++)
                {
                    Console.Write(arr[2]);
                }
                Console.WriteLine();
            }

        }

        public void British()
        {
            for(int i=0;i<15;i++)
            {
                for(int j=0;j<15;j++)
                {
                    if(i==j||(i+j)==14||j==7||i==7)
                    {
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.Write(arr[0]);
                    }
                    else
                    {
                        if((j-i)==1||(i-j)==1||(i+j)==13||(i+j)==15||i==6||i==8||j==6||j==8)
                        {
                            Console.ForegroundColor = ConsoleColor.White;
                            Console.Write(arr[1]);
                        }
                        else
                        {
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write(arr[2]);

                        }
                    }

                }
                Console.WriteLine();
                
            }
        }
        public void Belarusian()
        {
            for(int i=0;i<5;i++)
            {
                for(int j=0;j<30;j++)
                {
                    Console.Write(arr[0]);
                }
                Console.WriteLine();
            }
            Console.ForegroundColor = ConsoleColor.Red;
            for (int i = 0; i < 5; i++)
            {

                for (int j = 0; j < 30; j++)
                {
                    Console.Write(arr[1]);
                }
                Console.WriteLine();
            }
            Console.ResetColor();
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < 30; j++)
                {
                    Console.Write(arr[0]);
                }
                Console.WriteLine();
            }
        }
        public void Sergeis_flag()
        {
            for (int k = 0; k < 6; k++)
            {
                for (int i = 0; i < 2; i++)
                {
                    for (int j = 0; j < 30; j++)
                    {
                        switch (k)
                        {
                            case 0:
                                Console.ForegroundColor = ConsoleColor.Red;
                                break;
                            case 1:
                                Console.ForegroundColor = ConsoleColor.DarkYellow;
                                break;
                            case 2:
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                break;
                            case 3:
                                Console.ForegroundColor = ConsoleColor.Green;
                                break;
                            case 4:
                                Console.ForegroundColor = ConsoleColor.Blue;
                                break;
                            case 5:
                                Console.ForegroundColor = ConsoleColor.DarkMagenta;
                                break;


                        }

                        Console.Write(arr[k]);
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}