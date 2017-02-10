using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace appKiss
{
    class Program
    {
        static void Main(string[] args)
        {
            Rectangulo r = new Rectangulo(0, 0, 50, 30);
            Console.WriteLine("El área del rect. de 50x30 es : " + r.area());
            Console.ReadLine();
        }
    }
}
