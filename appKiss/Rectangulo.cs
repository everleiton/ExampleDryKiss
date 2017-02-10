using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appKiss
{
    class Rectangulo : Figura
    {
        double b, a;

        public Rectangulo(int m, int n, double s, double t)
        {
            x = m;
            y = n;
            b = s;
            a = t;
        }

        public override double area()
        {
            return b * a;
        }


        public override double perimetro()
        {
            return 2 * (b + a);
        }




    }
}
