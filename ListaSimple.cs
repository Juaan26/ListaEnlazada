using System;

namespace ListaEnlazada
{
    class ListaSimple<T> where T : IComparable<T>
    {
        public Nodo<T>? Head { set; get; }

        public ListaSimple()
        {
            Head = null;
        }
        public void InsertarAlInicio(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);
            nuevoNodo.Siguiente = Head;
            Head = nuevoNodo;

        }
        public void InsertarAlFinal(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);
            //Primero comprobamos que la lista no esté vacía para que el programa no se rompa
            if (Head == null)
            {
                Head = nuevoNodo;
                return;
            }
            //Creamos una variable para no perder la referencia con todos los nodos anteriores
            //porque mientras tengamos la referencia del primer Head podemos acceder a todos
            Nodo<T> referencia = Head;
            //Recorremos la lista hasta llegar al ultimo Head que es el que no referencia ningun otro (o lo que es lo mismo, no tiene un Siguiente)
            while (referencia.Siguiente != null)
            {
                referencia = referencia.Siguiente;
            }
            referencia.Siguiente = nuevoNodo;
        }
        public void InsertarOrdenado(T valor)
        {
            Nodo<T> nuevoNodo = new Nodo<T>(valor);
            Nodo<T> referencia = Head.Siguiente;
            Nodo<T> referenciaAnterior = Head;
            while (referencia.CompareTo(nuevoNodo) != 1)
            {
                referencia = referencia.Siguiente;
                referenciaAnterior = referenciaAnterior.Siguiente;
            }
            nuevoNodo.Siguiente = referenciaAnterior.Siguiente;
            referenciaAnterior.Siguiente = nuevoNodo;
        }
        public void Eliminar(T indice)
        {
            // Comprobación para que no pete si la lista está vacía y se intenta borrar
            if (Head == null)
            {
                Console.WriteLine("No hay elementos que eliminar");
                return;
            }
            // ------------------------------------------------------------
            //A la hora de iterar el Head referencia es el siguiente Head, es decir de base es el Head 2 y el Head 1 es ref anterior
            Nodo<T> referencia = Head.Siguiente;
            Nodo<T> refAnterior = Head;


            // si nuestra intención es eliminar el Head 1, lo desasignamos de memoria y le pasamos a la lista como nuevo Head inicial el Head 2
            if (EqualityComparer<T>.Default.Equals(refAnterior.Valor, indice))
            {
                //no es necesario ponerlo a null porque el garbage collector de C# lo acabará eliminando pero así es más orientativo
                refAnterior = null;
                Head = referencia;
                return;

            }
            //iteramos en base a nuestras asignaciones para que cuando el Head que queremos eliminar coincida con el Head referencia le pasemos su siguiente a la referencia anterior
            while (referencia != null)
            {
                //si coincide referencia con el Head que queremos eliminar, asignamos el valor y en este caso convertimos el Head a null para que sea mas orientativo en cuanto a que se supone que eliminamos el Head
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
            Nodo<T> referencia = Head;
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
            if (Head == null)
            {
                Console.Write("La lista está vacía");
                return;
            }
            //Creamos variable para no perder las referencias al iterar
            Nodo<T> referencia = Head;
            //Recorremos los nodos devolviendo su valor
            while (referencia != null)
            {
                Console.WriteLine(referencia.Valor);
                referencia = referencia.Siguiente;
            }

        }
        public void InsertarEnPosicion(int posicion, T valor)
        {


            if (posicion == 0 || Head == null || posicion < 0)
            {
                InsertarAlInicio(valor);
                return;
            }

            Nodo<T> referencia = Head;
            Nodo<T> referenciaAnterior = null;
            int contador = 0;

            while (contador != posicion && referencia != null)
            {
                referenciaAnterior = referencia;
                referencia = referencia.Siguiente;
                contador++;

            }
            if (referencia == null)
            {
                Console.WriteLine("fuera de rango");
                return;
            }

            Nodo<T> nuevoNodo = new Nodo<T>(valor);
            nuevoNodo.Siguiente = referencia;
            referenciaAnterior.Siguiente = nuevoNodo;


        }
        public bool EliminarEnPosicion(int posicion)
        {
            Nodo<T> referencia = Head;
            Nodo<T> refAnterior = null;
            int contador = 0;
            if (Head == null)
            {
                Console.WriteLine("La lista está vacía");
                return false;
            }
            if(posicion == 0) 
            {
                Head = Head.Siguiente;
                return true;
            }
            while (posicion != contador && referencia != null)
            {
                refAnterior = referencia;
                referencia = referencia.Siguiente;
                contador++;

                if (referencia == null)
                {
                    Console.WriteLine("Fuera de rango");
                    return false;
                }
            }
            refAnterior.Siguiente = referencia.Siguiente;            
            return true;

        }
        public int Contar()
        {
            int contador = 0;
            Nodo<T> referencia = Head;

            while( referencia != null)
            {
                referencia = referencia.Siguiente;
                contador++;
            }
            return contador ;
        }
    }
}
