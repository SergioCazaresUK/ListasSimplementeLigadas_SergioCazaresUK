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
        public string RecorrerLista()
        {
            string valores = string.Empty;
            nodoActual = nodoInicial;
            while (nodoActual.EnlaceB != null)
            {
                nodoActual = nodoActual.EnlaceB;
                valores += $"{nodoActual.Valor}\n";
            }
            return valores;
        }
        public void AgregarNodo(string valor)
        {
            nodoActual = nodoInicial;
            while (nodoActual.EnlaceA != null && nodoActual.EnlaceB != null)
            {
                nodoActual = nodoActual.EnlaceA;
            }
            Nodo nuevoNodo = new(valor);
            nodoActual.EnlaceB = nuevoNodo;
        }
        public Nodo Buscar(string valor)
        {
            if (ValidaVacio() == false)
            {
                Nodo nodoBusqueda = nodoInicial;
                while (nodoBusqueda.Enlace != null)
                {
                    nodoBusqueda = nodoBusqueda.Enlace;
                    if (nodoBusqueda.Valor == valor)
                    {
                        return nodoBusqueda;
                    }
                }
            }
            return null;
        }
    }
}
