using ListasDoblementeLigadas;

Lista lista = new Lista();

Console.WriteLine("Agregar una Lista");
Console.WriteLine(lista.RecorrerLista());
lista.AgregarNodo("Uno");
Console.WriteLine(lista.RecorrerLista());
lista.AgregarNodo("Dos");
Console.WriteLine(lista.RecorrerLista());
lista.AgregarNodo("Tres");
Console.WriteLine(lista.RecorrerLista());
lista.AgregarNodo("Cuatro");
Console.WriteLine(lista.RecorrerLista());



Nodo nodoBusqueda = lista.Buscar("Dos");
if (nodoBusqueda != null)
{
    Console.WriteLine(nodoBusqueda.Valor);
}
else
{
    Console.WriteLine("No encontrado");
}

