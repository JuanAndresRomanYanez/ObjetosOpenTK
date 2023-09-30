using OpenTK;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proyecto1_01
{
    public class Parte
    {
        private List<Poligono> Lista;
        public Parte()
        {
            Lista = new List<Poligono>();
        }

        public void Adicionar(Poligono poligono)
        {
            Lista.Add(poligono);
        }

        public void Dibujar()
        {
            for (int i = 0; i < Lista.Count; i++)
            {
                Lista.ElementAt(i).Dibujar();
            }
        }

        public void Eliminar(int i)
        {
            Lista.RemoveAt(i);
        }


    }
}
