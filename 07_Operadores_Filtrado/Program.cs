using Entidades.Data;

var context = new ApplicationDbContext();

Console.WriteLine("Operadores de Filtrado");

/*
Operadores de filtrado:
        Where: filtra una secuencia de elementos según una condición.
        OfType: filtra los elementos de una secuencia según su tipo.
        Take: toma los primeros n elementos de una secuencia.
        Skip: omite los primeros n elementos de una secuencia.
        Distinct: elimina los elementos duplicados de una secuencia.
 */

var customers = context.Customers.Skip(50).Take(30).ToList();

Console.WriteLine($"{customers.Count} customers");

// Take
var lst = from c in context.Customers.Take(50)
          select c;


// Skip
var lst1 = from c in context.Customers.Skip(10).Take(5)
           orderby c.CustomerId
           select c;


// OfType
List<object> objects = new List<object> { 1, "2", 3.0, "4.0", 1, 2 };
List<string> strings = objects.OfType<string>().ToList();


// Distinct
var todos = objects.OfType<int>().ToList();
var distintos = objects.OfType<int>().Distinct().ToList();

Console.ReadLine();