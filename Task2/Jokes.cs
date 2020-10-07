using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Jokes;
using Task2;

namespace Jokes
{
    static class RandJoke
    {
        public static string path;

        [STAThread]
        public static void AdAnekdot(string path)
        {
            using (StreamWriter sw = File.AppendText(path))
            {
                Console.WriteLine("Vevdite anekdot");
                string anek = Console.ReadLine();
                sw.WriteLine();
                sw.WriteLine(anek);
            }
        }

        public static  void OpenFile(string path)
        {
            using (StreamReader sr = File.OpenText(path))
            {
                Random rand = new Random();
                string[] str = File.ReadAllLines(path);
                string Anek = str[rand.Next(str.Length)];
                char[] mas = { '.' };
                string[] names = Anek.Split(mas);
                foreach (var s in names)
                {
                    Console.WriteLine(s);
                }
            }
        }



         public static void Try()
        {
            Console.WriteLine("Enter name for jokes file");
            string name = Console.ReadLine();
            path = @"D:\c#\EZJI\Task2\" + name;
            //В свойствах стоит тип выходных данных консоль 
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}