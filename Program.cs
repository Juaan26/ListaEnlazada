using System;

namespace ListaEnlazada
{
    class Program
    {
        static void Main(string[] args)
        {
            ListaSimple<int> lista = new ListaSimple<int>();
            ListaSimple<int> lista2 = new ListaSimple<int>();
            lista.InsertarAlInicio(1);
            lista.InsertarAlInicio(2);
            lista.InsertarAlInicio(3);
            lista2.InsertarAlFinal(1);
            lista2.InsertarAlFinal(2);
            lista2.InsertarAlFinal(3);
            lista2.InsertarAlFinal(4);
            lista2.InsertarAlFinal(5);
            Console.WriteLine("Rotamos: ");
            lista2.Rotar(2);
            lista2.Recorrer();


            //Console.Write(lista.EsIgual(lista2));
            //lista.InsertarRango([1, 2, 3, 4]);
            //lista.Recorrer();
            //Console.WriteLine("sumamos lista 1 y 2 en nueva lista: ");
            //ListaSimple<int> listaSumada = ListaSimple<int>.Unir(lista, lista2);
            //listaSumada.Recorrer();
            //Console.WriteLine("lista3");
            //lista3.Recorrer();
        }
    }
}
