using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class Nodo
    {
        public int Valor { get; set; }
        public Nodo NodoIzquierdo { get; set; }
        public Nodo NodoDerecho { get; set; }

        public Nodo(int valor)
        {
            Valor = valor;
            NodoIzquierdo = null;
            NodoDerecho = null;
        }
    }
}
