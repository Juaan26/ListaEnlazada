using System;

namespace ListaEnlazada
{
   class Program
    {
        static void Main(string[] args)
        {
            Nodo<int> n = null;
            ListaSimple<int> lista = new ListaSimple<int>();
            lista.InsertarAlFinal(new Nodo<int>(1));
            lista.InsertarAlFinal(new Nodo<int>(2));
            lista.InsertarAlFinal(new Nodo<int>(3));
            lista.InsertarAlFinal(new Nodo<int>(4));
            lista.InsertarAlFinal(new Nodo<int>(5));
            lista.InsertarOrdenado(new Nodo<int>(3));
            //lista.InsertarAlFinal(new Nodo<int>(4));
            //lista.InsertarAlFinal(new Nodo<int>(5));
            //lista.InsertarAlFinal(new Nodo<int>(6));
            Nodo<int> Resultado = lista.Buscar(2);
            //Console.WriteLine("Resultado de la consulta: " + Resultado + "de valor "+ Resultado.Valor);
            //lista.Recorrer();
            //lista.Eliminar(1);
            //lista.Eliminar(2);
            //lista.Eliminar(4);
            //lista.Eliminar(5);
            //lista.Eliminar(6);
            //lista.Eliminar(1);
            lista.Recorrer();
            n = lista.nodo;

            //while (n != null)
            //{
            //    Console.WriteLine(n.Valor);
            //    n = n.Siguiente;
            //}
      
        }
    }
}
