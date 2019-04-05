using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp_Heritage_Dessin
{
    class Program
    {
        static void Main(string[] args)
        {
            Dessin d1 = new Dessin();
            FormeGraphique f1 = new Rectangle(4, 6);
            d1.Add(f1);
            d1.Editer();

            Dessin d2 = new Dessin();
            FormeGraphique f2 = new Triangle(4);
            d2.Add(f2);
            d2.Editer();

            Dessin d3 = new Dessin();
            FormeGraphique f3 = new Cercle(7);
            d3.Add(f3);
            d3.Editer();

            Console.ReadLine();
        }
    }
}
