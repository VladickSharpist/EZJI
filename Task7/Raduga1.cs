using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task7
{
    class Raduga:IEnumerable
    {
        string r = "red";
        string o = "orange";
        string y = "yellow";
        string g = "green";
        string lb = "light blue";
        string b = "blue";
        string p = "purple";

        public IEnumerator GetEnumerator()
        {
            return new RadugaEnumerator(r,o,y,g,lb,b,p);
        }

    }

    public class Try
    {
        public static void Fun()
        {
            Raduga raduga = new Raduga();
            foreach (var a in raduga)
            {
                Console.WriteLine(a);
            }
        }
    }


    class RadugaEnumerator : IEnumerator
    {
        int MasSize = 0;
        int pos = -1;
        string[] Args;
        public RadugaEnumerator(params string[] args)
        {
            MasSize = args.Length;
            Args = args;
        }
        public object Current
        {
            get
            {
                switch(pos)
                {
                    case 0:return Args[0];
                    case 1:return Args[1];
                    case 2:return Args[2];
                    case 3:return Args[3];
                    case 4:return Args[4];
                    case 5:return Args[5];
                    case 6:return Args[6];
                    default: return 0;
                }

            }
        }
        public bool MoveNext()
        {

            if (pos < MasSize-1)
            {
                pos++;
                return true;
            }
            else
                return false;
        }
        public void Reset()
        {
            pos = -1;
        }

    }

}
