using System;

namespace ListaEnlazada
{
    class Nodo<T>:IComparable<Nodo<T>> where T : IComparable<T>
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
            return Valor.CompareTo(other.Valor);
        }
    }
}
