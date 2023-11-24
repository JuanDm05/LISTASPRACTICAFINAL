using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListaPeople
{
    public class Nodo
    {
        public Personas DatosPersonas;
        public Nodo Siguiente;

        public Nodo(Personas personas)
        {
            DatosPersonas = personas;
            Siguiente = null;
        }


    }
}
