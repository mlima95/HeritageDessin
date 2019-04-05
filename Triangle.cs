using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp_Heritage_Dessin
{
    class Triangle : FormeGraphique
    {
        int hauteur;

        public Triangle(int hauteur)
        {
            this.hauteur = hauteur;
        }

        public override string Dessiner()
        {
            string triangle = "";

            for (int i = 0; i < hauteur; i++)
            {
                
                triangle += "*";
                
                for (int y = 0; y < i; y++)
                {
                    triangle += " *";
                }
                triangle += "\n";
            }
           
            return triangle;

        }

        public string ToString()
        {
            return string.Format("{0}", this);
        }
    }
}
