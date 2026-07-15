# Estructuras de Datos en C# — Lista Enlazada Simple
 
Implementación desde cero de una lista enlazada simple genérica en C#, como parte del módulo de estructuras de datos del Certificado de Profesionalidad IFCD0111 (programación estructurada y bases de datos).
 
## Contenido
 
- `Nodo<T>`: nodo genérico con valor (`Valor`) y referencia al siguiente nodo (`Siguiente`).
- `ListaSimple<T>`: implementación de la lista, con cabeza (`Head`) y las operaciones sobre la cadena de nodos.
## Operaciones implementadas
 
- Inserción (al final y en otras posiciones)
- Eliminación
- Búsqueda
- Recorrido / traversal
- Inversión de la lista
- Clonación
- `Vaciar()` — vacía la lista
- `Unir(a, b)` — combina dos listas en una nueva
- `EsIgual(otra)` — compara dos listas por longitud y valor a valor
- Iteración mediante `IEnumerable<T>` / `IEnumerator<T>` (implementado con `yield return`)
## Detalles técnicos
 
- Genéricos con restricción `IComparable<T>` para poder comparar valores.
- Recorrido con patrón de dos punteros (`referencia` / `referenciaAnterior`) para mantener acceso tanto al nodo actual como al anterior.
- Comparación de listas elemento a elemento usando dos enumeradores avanzando en paralelo, en vez de anidar `foreach`.
## Motivación
 
Además de que las operaciones funcionen, el objetivo del ejercicio ha sido entender qué ocurre por debajo: cómo se gestionan los punteros al insertar o eliminar, cómo `foreach` se traduce en llamadas a `GetEnumerator()`/`MoveNext()`/`Current`, y qué garantiza (o no garantiza) exactamente cada interfaz utilizada.
 
## Próximos pasos
 
Continuar con la secuencia del módulo: lista doblemente enlazada, colas, árboles y algoritmos de ordenación.
 
