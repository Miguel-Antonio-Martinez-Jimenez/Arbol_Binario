using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArbolBinario
{
    class ArbolBinario
    {
        private Nodo raiz;

        public ArbolBinario()
        {
            raiz = null;
        }


        //INSERTAR-AL-ARBOL
        public void InsertarNodo(int valor)
        {
            if (raiz == null)
            {
                raiz = new Nodo(valor);
            }
            else
            {
                InsertarNodoEnSubarbol(raiz, valor);
            }
        }
        private void InsertarNodoEnSubarbol(Nodo nodo, int valor)
        {
            if (valor < nodo.Valor)
            {
                if (nodo.NodoIzquierdo == null)
                {
                    nodo.NodoIzquierdo = new Nodo(valor);
                }
                else
                {
                    InsertarNodoEnSubarbol(nodo.NodoIzquierdo, valor);
                }
            }
            else
            {
                if (nodo.NodoDerecho == null)
                {
                    nodo.NodoDerecho = new Nodo(valor);
                }
                else
                {
                    InsertarNodoEnSubarbol(nodo.NodoDerecho, valor);
                }
            }
        }


        //BUSCAR-EN-EL-ARBOL
        public bool BuscarNodo(int valor)
        {
            return BuscarNodoEnSubarbol(raiz, valor);
        }
        private bool BuscarNodoEnSubarbol(Nodo nodo, int valor)
        {
            if (nodo == null)
            {
                return false;
            }
            if (valor == nodo.Valor)
            {
                return true;
            }
            if (valor < nodo.Valor)
            {
                return BuscarNodoEnSubarbol(nodo.NodoIzquierdo, valor);
            }
            else
            {
                return BuscarNodoEnSubarbol(nodo.NodoDerecho, valor);
            }
        }


        //OBTENER-NIVEL-DEL-NODO-DEL-ARBOL
        public int NivelNodo(int valor)
        {
            return NivelNodoEnSubarbol(raiz, valor, 1);
        }
        private int NivelNodoEnSubarbol(Nodo nodo, int valor, int nivelActual)
        {
            if (nodo == null)
            {
                Console.WriteLine("Error");
                return -1;
            }
            if (valor == nodo.Valor)
            {
                return nivelActual;
            }
            if (valor < nodo.Valor)
            {
                return NivelNodoEnSubarbol(nodo.NodoIzquierdo, valor, nivelActual + 1);
            }
            else
            {
                return NivelNodoEnSubarbol(nodo.NodoDerecho, valor, nivelActual + 1);
            }
        }


        //VER-CAMINO-DEL-ARBOL-COMPLETO
        public void RecorrerCaminoGeneral()
        {
            RecorreCaminoCompletoEnSubarbol(raiz, "");
        }
        private void RecorreCaminoCompletoEnSubarbol(Nodo nodo, string caminoActual)
        {
            if (nodo == null)
            {
                return;
            }
            caminoActual += nodo.Valor.ToString() + " ";
            if (nodo.NodoIzquierdo == null && nodo.NodoDerecho == null)
            {
                Console.WriteLine(caminoActual);
            }
            RecorreCaminoCompletoEnSubarbol(nodo.NodoIzquierdo, caminoActual);
            RecorreCaminoCompletoEnSubarbol(nodo.NodoDerecho, caminoActual);
        }


        //VER-CAMINO-DE-UN-NODO-DEL-ARBOL
        public void RecorrerUnCamino(int valor)
        {
            RecorrerUnCaminoEnSubarbol(raiz, "", valor);
        }
        private void RecorrerUnCaminoEnSubarbol(Nodo nodo, string caminoActual, int valorSel)
        {
            if (nodo == null)
            {
                return;
            }
            caminoActual += nodo.Valor.ToString() + " ";
            if (nodo.NodoIzquierdo == null && nodo.NodoDerecho == null && nodo.Valor == valorSel)
            {
                Console.WriteLine(caminoActual);
            }
            RecorrerUnCaminoEnSubarbol(nodo.NodoIzquierdo, caminoActual, valorSel);
            RecorrerUnCaminoEnSubarbol(nodo.NodoDerecho, caminoActual, valorSel);
        }


        //OBTENER-EL-PESO-DEL-ARBOL
        public int PesoTotal()
        {
            return CalcularPesoTotal(raiz);
        }
        private int CalcularPesoTotal(Nodo nodo)
        {
            if (nodo == null)
            {
                return 0;
            }
            int pesoNodoIzquierdo = CalcularPesoTotal(nodo.NodoIzquierdo);
            int pesoNodoDerecho = CalcularPesoTotal(nodo.NodoDerecho);
            return pesoNodoIzquierdo + pesoNodoDerecho + 1;
        }


        //OBTENER-HOJAS-DE-LOS-NODOS
        public int NodosHoja()
        {
            return NodosHojaEnSubarbol(raiz);
        }
        private int NodosHojaEnSubarbol(Nodo nodo)
        {
            if (nodo == null)
            {
                return 0;
            }

            if (nodo.NodoIzquierdo == null && nodo.NodoDerecho == null)
            {
                return 1; // El nodo es una hoja
            }

            int nodosHojaIzquierdos = NodosHojaEnSubarbol(nodo.NodoIzquierdo);
            int nodosHojaDerechos = NodosHojaEnSubarbol(nodo.NodoDerecho);

            return nodosHojaIzquierdos + nodosHojaDerechos;
        }
    }
}
