using Entidades.Data;
var context = new ApplicationDbContext();

Console.WriteLine("Operadores de Cuantificación");
/*
Operadores de cuantificación:
    Any: determina si al menos un elemento de una secuencia cumple con una determinada condición
    All: determina si todos los elementos de una secuencia cumplen con una determinada condición.
    Contains: determina  si una secuencia contiene un elemento específico".
*/

// Any:
//  Determina si hay al menos un producto en la base de datos.
var hayProductos = context.Products.Any();


// All:
//      Determina si todos los clientes de la base de datos tienen al menos un pedido.
var todosLosClientesTienenPedidos = context.Customers.All(c => c.SalesOrderHeaders.Any());


// Contains:
//      Determina si hay algún pedido que contenga productos cuyo ID sea igual 777.
var pedidosConProductosEspecificos = context.SalesOrderHeaders.Where(o => o.SalesOrderDetails.Any(d => d.ProductId.Equals(777)));

Console.ReadLine();


