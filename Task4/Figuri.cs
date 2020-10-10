using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task4
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
            
        }
    }

}
