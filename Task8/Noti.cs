using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Task8
{

    public interface IAsyncDisposable
    {
        void Dispose(List<Nota> list)
        {
            foreach(var note in list)
            {
                note.Dispose();
            }
        }
    }
    public class Nota
    {
        int _Time;
        string sound;
        public Nota(int time, string s)
        {
            _Time = time;
            sound = s;
        }
        public void Dispose()
        {
            Thread.Sleep(_Time);
            Console.WriteLine(sound);
        }
    }
}
