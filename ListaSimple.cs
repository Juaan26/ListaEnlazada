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
            //Recorremos la lista hasta llegar al ultimo nodo que es el que no referencia ningun otro (o lo que es lo mismo, no tiene un Siguiente)
            while (referencia.Siguiente != null)
            {
                referencia = referencia.Siguiente;
            }
            referencia.Siguiente = nuevoNodo;
        }
        public void Eliminar(T indice)
        {
            // Comprobación para que no pete si la lista está vacía y se intenta borrar
            if (nodo == null)
            {
                Console.WriteLine("No hay elementos que eliminar");
                return;
            }
            // ------------------------------------------------------------
            //A la hora de iterar el nodo referencia es el siguiente nodo, es decir de base es el nodo 2 y el nodo 1 es ref anterior
            Nodo<T> referencia = nodo.Siguiente;
            Nodo<T> refAnterior = nodo;


            // si nuestra intención es eliminar el nodo 1, lo desasignamos de memoria y le pasamos a la lista como nuevo nodo inicial el nodo 2
            if (EqualityComparer<T>.Default.Equals(refAnterior.Valor, indice))
            {
                //no es necesario ponerlo a null porque el garbage collector de C# lo acabará eliminando pero así es más orientativo
                refAnterior = null;
                nodo = referencia;
                return;

            }
            //iteramos en base a nuestras asignaciones para que cuando el nodo que queremos eliminar coincida con el nodo referencia le pasemos su siguiente a la referencia anterior
            while (referencia != null)
            {
                //si coincide referencia con el nodo que queremos eliminar, asignamos el valor y en este caso convertimos el nodo a null para que sea mas orientativo en cuanto a que se supone que eliminamos el nodo
                if (EqualityComparer<T>.Default.Equals(referencia.Valor, indice))
                {
                    refAnterior.Siguiente = referencia.Siguiente;
                    //no es necesario ponerlo a null porque el garbage collector de C# lo acabará eliminando pero así es más orientativo
                    referencia = null;
                    return;

                }

                referencia = referencia.Siguiente;
                refAnterior = refAnterior.Siguiente;

            }

        }
        public Nodo<T> Buscar(T consulta)
        {
            Nodo<T> referencia = nodo;
            //Que itere todo el bucle 
            while (referencia != null)
            {
                //Si mientras itera el bucle encuentra el resultado, retorna el resultado y finaliza la iteración

                if (EqualityComparer<T>.Default.Equals(referencia.Valor, consulta))
                {
                    return (referencia);
                }
                referencia = referencia.Siguiente;


            }
            //si no encuentra nada retorna null
            return null;
        }
        public void Recorrer()
        {
            //Mensaje por si la lista está vacía
            if (nodo == null)
            {
                Console.Write("La lista está vacía");
                return;
            }
            //Creamos variable para no perder las referencias al iterar
            Nodo<T> referencia = nodo;
            //Recorremos los nodos devolviendo su valor
            while (referencia != null)
            {
                Console.WriteLine(referencia.Valor);
                referencia = referencia.Siguiente;
            }

        }
    }
}
