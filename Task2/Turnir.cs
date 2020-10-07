using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json;

namespace Turnir
{
    class turnir
    {


        public static void GetTeamsList(Dictionary<string, int> teams)
        {
            Console.Clear();
            int i = 1;
            foreach (var VARIABLE in teams)
            {
                Console.WriteLine($"{i}: {VARIABLE.Key} score: {VARIABLE.Value}");
                i++;
            }

        }
        public static void AddTeam(Dictionary<string, int> teams)
        {
            Console.Clear();
            Console.WriteLine("Enter your team");
            string name = Console.ReadLine();
            Console.WriteLine("Enter points to add");
            string points = Console.ReadLine();
            var k = Convert.ToInt32(points);
            teams.Add(name, k);
        }

        public static void AddScoreOfTeam(Dictionary<string, int> teams)
        {
            Console.Clear();
            Console.WriteLine("Enter team name");
            string name = Console.ReadLine();
            Console.WriteLine("How many points you wanna add\nIf you want to decrease score write like -(points to take)");
            string k = Console.ReadLine();
            var K = Convert.ToInt32(k);
            teams[name] += K;
        }

        public static void DeleteTeam(Dictionary<string, int> teams)
        {
            Console.Clear();
            Console.WriteLine("Enter team name");
            string name = Console.ReadLine();
            teams.Remove(name);
        }

        public void Try()
        {
            Console.WriteLine("Enter name to file");
            string name = Console.ReadLine();

            string path = @"D:\c#\EZJI\Task2\" + name;

            string jsonOut = File.ReadAllText(path);
            Dictionary<string, int> teams = JsonConvert.DeserializeObject<Dictionary<string, int>>(jsonOut);

            while (true)
            {
                Console.WriteLine("Enter code number:\n1: AddTeam\n2: Add or subtract\n3: Delete Team\n4: Get teamlist\n0: Exit");
                string k = Console.ReadLine();
                int K = Convert.ToInt32(k);

                switch (K)
                {
                    case 1:
                        AddTeam(teams);
                        break;
                    case 2:
                        AddScoreOfTeam(teams);
                        break;
                    case 3:
                        DeleteTeam(teams);
                        break;
                    case 4:
                        GetTeamsList(teams);
                        break;
                    case 0:
                        K = 0;
                        break;
                }
                if (K == 0) break;
            }

            string json = JsonConvert.SerializeObject(teams);
            File.WriteAllText(path, json);
            Console.WriteLine("Data has been saved to file");
        }
    }
}
