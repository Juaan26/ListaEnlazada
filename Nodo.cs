using System;

namespace ListaEnlazada
{
    class Nodo<T>:IComparable<Nodo<T>> 
    {
        public T Valor { get; set; }
        public Nodo<T>? Siguiente {  get; set; }

        public Nodo(T valor)
        {
            Valor = valor;
            Siguiente = null;

        }

        public int CompareTo(Nodo<T>? other)
        {
            if (Comparer<T>.Default.Compare(Valor, other.Valor) >= 0) return 1;
            if (Comparer<T>.Default.Compare(Valor, other.Valor) < 0) return -1;
            return 0;
        }
    }
}
