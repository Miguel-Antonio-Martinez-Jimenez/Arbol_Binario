using System;

namespace ArbolBinario
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ArbolBinario arbol = new ArbolBinario();
            // - - - - - - - -
            arbol.InsertarNodo(20);
            arbol.InsertarNodo(10);
            arbol.InsertarNodo(32);
            arbol.InsertarNodo(4);
            arbol.InsertarNodo(15);
            arbol.InsertarNodo(31);
            arbol.InsertarNodo(45);
            arbol.InsertarNodo(1);
            arbol.InsertarNodo(6);
            // - - - - - - - -
            Console.WriteLine("6: " + arbol.BuscarNodo(6));
            Console.WriteLine("7: " + arbol.BuscarNodo(7));
            // - - - - - - - -
            Console.WriteLine("Nivel: " + arbol.NivelNodo(6));
            // - - - - - - - -
            Console.WriteLine("Camino General:");
            arbol.RecorrerCaminoGeneral();
            // - - - - - - - -
            Console.Write("Un Camino: ");
            arbol.RecorrerUnCamino(6);
            // - - - - - - - -
            Console.WriteLine("Peso: "+arbol.PesoTotal());
            // - - - - - - - -
            Console.WriteLine("Hojas: "+arbol.NodosHoja());
        }
    }
}
