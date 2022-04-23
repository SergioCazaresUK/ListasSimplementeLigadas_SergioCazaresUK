using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ListasDoblementeLigadas
{
    public class Nodo
    {
        public string Valor { get; set; }
        public Nodo EnlaceA { get; set; }
        public Nodo EnlaceB { get; set; }

        public Nodo(Nodo enlaceA = null, string valor = "", Nodo enlaceB = null)
        {
            Valor = valor;
            EnlaceA = enlaceA; 
            EnlaceB = enlaceB;
        }
    }
}
