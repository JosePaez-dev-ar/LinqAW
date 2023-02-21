using Entidades.Data;
var context = new ApplicationDbContext();

Console.WriteLine("Operadores de Elemento");

/*
Operadores de Elemento 
    First: Devuelve el primer elemento de una secuencia que cumple con una condición determinada o el primer elemento de la secuencia si no se proporciona ninguna condición. Si la secuencia está vacía o no se encuentra ningún elemento que cumpla con la condición, se produce una excepción.
    FirstOrDefault: Devuelve el primer elemento de una secuencia que cumple con una condición determinada o el valor predeterminado del tipo de elementos de la secuencia si no se proporciona ninguna condición o si no se encuentra ningún elemento que cumpla con la condición.
    Last: Devuelve el último elemento de una secuencia que cumple con una condición determinada o el último elemento de la secuencia si no se proporciona ninguna condición. Si la secuencia está vacía o no se encuentra ningún elemento que cumpla con la condición, se produce una excepción.
    LastOrDefault: Devuelve el último elemento de una secuencia que cumple con una condición determinada o el valor predeterminado del tipo de elementos de la secuencia si no se proporciona ninguna condición o si no se encuentra ningún elemento que cumpla con la condición.
    Single: Devuelve el único elemento de una secuencia que cumple con una condición determinada. Si la secuencia contiene más de un elemento que cumple con la condición o está vacía, se produce una excepción.
    SingleOrDefault: Devuelve el único elemento de una secuencia que cumple con una condición determinada o el valor predeterminado del tipo de elementos de la secuencia si no se proporciona ninguna condición o si la secuencia contiene más de un elemento que cumple con la condición.
*/



//  ElementAt:
//      Devuelve el tercer producto de la tabla Products.
//var tercerProducto = context.Products.ElementAt(2);


//  First:
//      Devuelve el primer producto que tiene un precio mayor a 100.
var primerProductoCaro = context.Products.First(p => p.ListPrice > 100);


//  Last:
//      Devuelve el último producto que tiene un precio mayor a 100.
var ultimoProductoCaro = context.Products.OrderBy(p => p.ProductId).Last(p => p.ListPrice > 100);


//  Single:
//      Devuelve el cliente con el CustomerID igual a 1.
var clienteUnico = context.Customers.Single(c => c.CustomerId == 1);


//  ElementAtOrDefault:
//      Devuelve el sexto producto de la tabla Products o null si la tabla tiene menos de 6 elementos.
//var sextoProducto = context.Products.ElementAtOrDefault(5);


//  FirstOrDefault:
//      Devuelve null si no existe un cliente con CustomerID igual a 1000.
var clienteInexistente = context.Customers.FirstOrDefault(c => c.CustomerId == 1000);


// LastOrDefault: 
//      Devuelve null si no hay ningún producto con un precio mayor a 100.
var ultimoProductoCaro2 = context.Products.LastOrDefault(p => p.ListPrice > 100);


//  SingleOrDefault: 
//      Devuelve el cliente con CustomerID igual a 1 o null si no existe ningún cliente con ese ID,
//      o si hay más de un cliente con ese ID.
var clienteUnico2 = context.Customers.SingleOrDefault(c => c.CustomerId == 1);
