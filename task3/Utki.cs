using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Utki
{
    class DuckFun
    {

        static public Utochka RandomDuck()
        {
            Utochka utka = new Utochka("");
            Random rnd = new Random();
            int k = rnd.Next(1, 6);
            switch (k)
            {
                case 1:
                    utka = new GrayDuck("serenkaya");
                    break;
                case 2:
                    utka = new Kruakva("Krua-Krua-Kruakva");
                    break;
                case 3:
                    utka = new MuDuck("SOSO");
                    break;
                case 4:
                    utka = new RubberDuck("Stirka");
                    break;
                case 5:
                    utka = new DuckPetuh("Misha");
                    break;

            }

            return utka;
        }

    }

    class Utochka
    {
        public string Name { get; set; }

        public Utochka(string name)
        {
            Name = name;
        }

        public virtual void Krua()
        {
            Console.WriteLine("???");
        }
    }

    class Kruakva : Utochka
    {

        public Kruakva(string name)
            : base(name)
        {

        }

        public override void Krua()
        {
            Console.WriteLine("Krua Plusi govno,Sharpi - zaebis");
        }
    }

    class GrayDuck : Utochka
    {
        public GrayDuck(string name)
            : base(name)
        {

        }

        public override void Krua()
        {
            Console.WriteLine("AHHAHAHAHAHA");
        }
    }
    class MuDuck : Utochka
    {
        public MuDuck(string name)
            : base(name)
        {

        }

        public override void Krua()
        {
            Console.WriteLine("Ti muden, dorogou moi(ne sega)");
        }
    }
    class RubberDuck : Utochka
    {
        public RubberDuck(string name)
            : base(name)
        {

        }

        public override void Krua()
        {
            Console.WriteLine("MY fav team ofc Ejiki");
        }
    }
    class DuckPetuh : Utochka
    {
        public DuckPetuh(string name)
            : base(name)
        {

        }

        public override void Krua()
        {
            Console.WriteLine("Misha petuh");
        }
    }
}
