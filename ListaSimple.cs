using System;

namespace ListaEnlazada
{
    class ListaSimple<T>
    {
        public Nodo<T> nodo { set; get; }

       public ListaSimple()
       {
            nodo = null;
       }
       public void InsertarAlInicio(Nodo<T> nuevoNodo)
       {
            nuevoNodo.Siguiente = nodo;
            nodo = nuevoNodo;
               
        }
    }
}
