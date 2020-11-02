using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IndividualWord
{
    class Try
    {
       public static void main()
        {
            string Word;
            int Counter = 0;
            Console.WriteLine("Enter the word:");
            Word = Console.ReadLine();
            var Value = Word.Split(' ');
            Dictionary<string, int> IndividualWord = new Dictionary<string, int>();
            for (int i = 0; i < Value.Length; i++) 
            {
                if (IndividualWord.ContainsKey(Value[i]))
                {
                    int value = IndividualWord[Value[i]];
                    IndividualWord[Value[i]] = value + 1;
                }

                else
                {
                    IndividualWord.Add(Value[i], 1);
                }
            }
            Console.WriteLine("Individual words:");
            foreach (KeyValuePair<string, int> kvp in IndividualWord)
            {
                if (kvp.Value == 1)
                {
                    Console.WriteLine(kvp.Key);
                    Counter++;
                }
            }
            Console.WriteLine("Number of individual words: " + Counter);
            Console.ReadKey();
        }
    }
}