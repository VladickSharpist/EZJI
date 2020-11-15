using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Reflection;

namespace Last_Task
{
    class Ermoshina
    {
        public static int Counter=0;
        public Ermoshina()
        {
            Counter++;
        }

        public string Me()
        {
            return("I am Lair");
        }
        public void Say(string position,string Who)
        {
            Console.WriteLine($"Nigga {position} {Who}");
        }

        public string Name()
        {
            return "Lair";
        }
    }

    class Fair
    {
        public static int Counter = 0;
        public Fair()
        {
            Counter++;
        }
        public string Me()
        {
            return("I am Fair");
        }
        public void Say(string position,string Who)
        {
            Console.WriteLine($"Nigga {position} {Who}");
        }

        public string Name()
        {
            return "Fair";
        }
    }
    class Game
    {
        Random rnd = new Random();
        public dynamic RandEl()
        {
            var k=rnd.Next(0,100);
            if (k>=0 && k<50)
            {
                return (new Fair());
            }
            else
            {
                return (new Ermoshina());
            }
        }

        public dynamic[] CreateList()
        {
            Console.WriteLine("How many els is in your List\nMore than 5 is brrr(dificult)");
            var k = Convert.ToInt32(Console.ReadLine());
            dynamic[] list= new dynamic[k];
            for (int i=0;i<k;i++)
            {
                list[i]=RandEl();
            }
            Console.Clear();
            Console.WriteLine($"Fair:{Fair.Counter}\nLair:{Ermoshina.Counter}\nGood luck boiz");
            //foreach(var x in list)
            //{
            //    Console.WriteLine(x.Name());
            //}

            return list;
        }

        public dynamic[] CreateGame()
        {
            dynamic[] list = CreateList();
            for(int k=0; k<list.Length; k++)
            {
                var el = list[k];
                if (el.GetType() == typeof(Fair))
                {
                    if (k == 0)
                    {
                        var next = list[k + 1];
                        el.Say("next to me", $"is a  {next.Name()}");
                        Console.WriteLine();
                    }
                    else if (k == list.Length - 1)
                    {
                        var prev = list[k - 1];
                        el.Say("in front of me", $"is a  {prev.Name()}");
                        Console.WriteLine();
                    }
                    else
                    {
                        var prev = list[k - 1];
                        var next = list[k + 1];
                        el.Say("in front of me", $"is a  {prev.Name()}");
                        el.Say("next to me", $"is a  {next.Name()}");
                        Console.WriteLine();
                    }
                }
                else
                {
                    if (k == 0)
                    {
                        var next = list[k + 1];
                        if (next.GetType() == typeof(Fair))
                        {
                            el.Say("next to me", $"is a Lair");
                        }
                        else
                        {
                            el.Say("next to me", $"is a Fair");
                        }
                        Console.WriteLine();
                    }
                    else if (k == list.Length - 1)
                    {
                        var prev = list[k - 1];
                        if (prev.GetType() == typeof(Fair))
                        {
                            el.Say("in front of me", $"is a Lair");
                        }
                        else
                        {
                            el.Say("in front of me", $"is a Fair");
                        }
                    }
                    else
                    {
                        var prev = list[k - 1];
                        if (prev.GetType() == typeof(Fair))
                        {
                            el.Say("in front of me", $"is a Lair");
                        }
                        else
                        {
                            el.Say("in front of me", $"is a Fair");
                        }
                        var next = list[k + 1];
                        if (next.GetType() == typeof(Fair))
                        {
                            el.Say("next to me", $"is a Lair");
                        }
                        else
                        {
                            el.Say("next to me", $"is a Fair");
                        }
                       
                        Console.WriteLine();
                    }
                }
            }
            return list;
        }
         public void StartGame()
         {
            dynamic[] list = CreateGame();
            var k = list.Length;
            int[] mas=new int[k];
            for(int i=0;i<k;i++)
            {
                if (list[i].GetType() == typeof(Fair))
                {
                    mas[i] = 1;
                }
                else
                {
                    mas[i] = 2;
                }
                //Console.WriteLine(mas[i]);
            }
            Console.WriteLine();
            Console.WriteLine("Enter 1 for Fair and 2 for Lair\nUse enter after every digit( pls:) )");
            int[] UserMas = new int[k];
            for (int i = 0; i < k; i++)
            {
                UserMas[i]=Convert.ToInt32(Console.ReadLine());
            }

            var counter = 0;
            for(int i=0;i<k;i++)
            {
                if (UserMas[i] != mas[i])
                    counter++;
            }
            if(counter==0)
            {
                Console.WriteLine("You won");
            }
            else
            {
                Console.WriteLine("You lost");
                foreach(var x in list)
                {
                    Console.WriteLine(x.Name());
                }
            }
        }
    }
}
