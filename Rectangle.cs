using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp_Heritage_Dessin
{
    class Rectangle : FormeGraphique
    {
        private int hauteur, longueur;

        public Rectangle(int hauteur,int longueur)
        {
            this.hauteur = hauteur;
            this.longueur = longueur;
        }

        public override string Dessiner()
        {
            string rectangle = "";

            for (int i = 0; i < hauteur; i++)
            {
                for (int y = 0; y < longueur; y++)
                {
                    rectangle += "*";
                }
                rectangle += "\n";
            }
            return rectangle;
        }

        public string ToString()
        {
            return string.Format("{0}", this);
        }
    }
}
