using System;

namespace ListaEnlazada
{
   class Program
    {
        static void Main(string[] args)
        {
            Nodo<int> n = null;
            ListaSimple<int> lista = new ListaSimple<int>();
            lista.InsertarAlFinal(new Nodo<int>(5));
            n = lista.nodo;

            while (n != null)
            {
                Console.WriteLine(n.Valor);
                n = n.Siguiente;
            }
      
        }
    }
}
