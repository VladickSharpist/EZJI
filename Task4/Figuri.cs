using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figuri
{
    abstract class Shape
    {
        public abstract void Draw();
    }

    class Triangle: Shape
    {
        private int m_side;

        public Triangle(int side)
        {
            m_side = side;
        }

        public override void Draw()
        {
            var b = 1;
            for (int i = 0; i < m_side; i++, b++)
            {
                for (int j = 0; j < b; j++)
                {
                    Console.Write("0");
                }

                Console.WriteLine();
            }
        }
    }

    class Square : Shape
    {
        private int m_length;
        private int m_width;

        public Square(int lenght,int width)
        {
            m_length = lenght;
            m_width = width;
        }

        public Square(int side)
        {
            m_length = m_width = side;
        }

        public override void Draw()
        {
            
            for (int i = 0; i < m_length; i++)
            {
                for (int j = 0; j < m_width; j++)
                {
                    Console.Write("0");
                }

                Console.WriteLine();
            }
        }
    }

    class Romb : Shape
    {
        private int m_height;

        public Romb(int height)
        {
            m_height = height;
        }

        public override void Draw()
        {
            int b = 1,c=m_height;
            for (int i = 0; i < m_height; i++, b++, c--)
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
            for (int i = 0; i <= m_height; i++, b--, c++)
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
    }
}
