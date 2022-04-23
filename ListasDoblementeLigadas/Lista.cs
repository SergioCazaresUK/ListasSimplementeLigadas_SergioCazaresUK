using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    public class Lista
    {
        Nodo nodoAnterior;
        Nodo nodoInicial;
        Nodo nodoSiguiente;
        Nodo nodoActual;

        public Lista()
        {
            nodoInicial = new Nodo();
        }
        public bool ValidaVacio()
        {
            if (nodoInicial.EnlaceB == null)
            {
                return true;
            }
            return false;
        }
    }
}
