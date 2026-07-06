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
       public void InsertarAlFinal(Nodo<T> nuevoNodo)
       {
            //Primero comprobamos que la lista no esté vacía para que el programa no se rompa
            if (nodo == null)
            {
                nodo = nuevoNodo;
                return;
            }
            //Creamos una variable para no perder la referencia con todos los nodos anteriores
            //porque mientras tengamos la referencia del primer nodo podemos acceder a todos
            Nodo<T> referencia = nodo;
            //Recorremos la lista hasta llegar al ultimo nodo que es el que no referencia ningun otro
            while(nodo.Siguiente != null)
            {
                nodo = nodo.Siguiente;
            }
            //Cuando llegamos al ultimo nodo le asignamos el nuevo nodo como siguiente
            nodo.Siguiente = nuevoNodo;
            nodo = referencia;
       }

    }
}
