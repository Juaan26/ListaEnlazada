using System;

namespace ListaEnlazada
{
   class Program
    {
        static void Main(string[] args)
        {
            Nodo<int> n = null;
            ListaSimple<int> lista = new ListaSimple<int>();
            lista.InsertarAlInicio(1);
            lista.InsertarAlInicio(2);
            lista.InsertarEnPosicion(1, 23);
            lista.InsertarAlInicio(3);
            lista.InsertarEnPosicion(1, 23);
            lista.InsertarAlInicio(4);
            lista.InsertarAlInicio(5);
            lista.EliminarEnPosicion(4);
            Console.WriteLine(lista.Contar() + " sí esto es el numero de nodos ");
            lista.Recorrer();
            Console.WriteLine("invertimos");
            lista.Invertir();
            Console.WriteLine(lista.Contar() + " sí esto es el numero de nodos ");
            lista.Recorrer();


        }
    }
}
