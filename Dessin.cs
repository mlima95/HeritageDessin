using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Tp_Heritage_Dessin
{
    class Dessin
    {
        private List<FormeGraphique> lesFormes;

        public Dessin()
        {
            this.lesFormes = new List<FormeGraphique>();
        }

        public void Editer()
        {
            foreach (FormeGraphique fg in lesFormes)
            {
                Console.WriteLine(fg.Dessiner());
            }
        }

        public void Add(FormeGraphique forme)
        {
            this.lesFormes.Add(forme);
        }
    }
}
