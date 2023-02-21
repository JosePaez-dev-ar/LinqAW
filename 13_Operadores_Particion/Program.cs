using Entidades.Data;
var context = new ApplicationDbContext();

Console.WriteLine("Operadores de Partición");
/*
Operadores de Partición:
    Take: Devuelve los primeros n elementos de una secuencia.
    TakeWhile: Devuelve elementos de una secuencia mientras se cumple una condición dada.
    Skip: Omite los primeros n elementos de una secuencia y devuelve los elementos restantes.
    SkipWhile: Omite elementos de una secuencia mientras se cumple una condición dada y devuelve los elementos restantes.
    ElementAt: Devuelve el elemento en una posición específica de una secuencia.
    First: Devuelve el primer elemento de una secuencia que cumple una condición dada.
    Last: Devuelve el último elemento de una secuencia que cumple una condición dada.
    Single: Devuelve el único elemento de una secuencia que cumple una condición dada.
*/

//  Skip:
//      Retorna los productos ordenados por nombre, saltando los primeros 10 y tomando los siguientes 10.
var productosPagina2 = context.Products.OrderBy(p => p.Name).Skip(10).Take(10);


//  Take:
//      Retorna los primeros 5 productos ordenados por precio.

var primerosProductos = context.Products.OrderBy(p => p.ListPrice).Take(5);


// SkipWhile:
//      Skip over amounts in the array until the first amount
//      that is less than or equal to the product of its
//      index in the array and 1000. Take the remaining items.

int[] amounts = { 5000, 2500, 9000, 8000, 6500, 4000, 1500, 5500 };

IEnumerable<int> query =
    amounts.AsQueryable()
    .SkipWhile((amount, index) => amount > index * 1000);

foreach (int amount in query)
    Console.WriteLine(amount);

Console.ReadLine();