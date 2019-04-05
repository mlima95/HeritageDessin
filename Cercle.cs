using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp_Heritage_Dessin
{
    class Cercle : FormeGraphique
    {
        int diametre;
        public Cercle(int diametre)
        {
            this.diametre = diametre;
        }

        public override string Dessiner()
        {
            string cercle = "";
            int donnee = diametre / 2 + 1;
            int valeur = -1;
            for (int i = 0; i < diametre; i++)
            {


                if (i != diametre / 2)
                {
                    if (i <= diametre / 2)
                    {
                        donnee = donnee - 1;
                        valeur = valeur + 2;
                    }
                    if (i > diametre / 2)
                    {
                        donnee = donnee + 1;
                        if (i > diametre / 2 + 1)
                        {
                            valeur = valeur - 2;
                        }
                    }

                    for (int x = 0; x < donnee; x++)
                    {
                        cercle += " ";
                    }

                    for (int w = 0; w < valeur; w++)
                    {
                        cercle += "*";
                    }
                    cercle += "\n";
                }
                else
                {
                    for (int z = 0; z < diametre; z++)
                    {
                        cercle += "*";
                    }
                    donnee = 0;
                    cercle += "\n";
                }

            }


            return cercle;
        }

        public string ToString()
        {
            return string.Format("{0}", this);
        }
    }
}
