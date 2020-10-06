using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Seif
{
    class Program
    {
       
    }

    class Saef<T>
    {
        private T id;

        public Saef(T id){ this.id=id; }

        public void Chek_id()
        {
            Console.WriteLine(id);
        }

    }
}
