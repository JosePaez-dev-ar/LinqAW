using Entidades.Data;

var context = new ApplicationDbContext();

Console.WriteLine("SubConsultas No Correlacionadas");

/*
Subconsulta No Correlacionada:
    Es una consulta que no depende de la consulta principal y se puede ejecutar de manera independiente. 
    Estas subconsultas se ejecutan primero y luego se utilizan los resultados en la consulta principal.
 */

// Consulta #1:
//      Encontrar los 10 productos más vendidos en la tabla "SalesOrderDetail"

Console.WriteLine("\nConsulta #1");
var topSellingProducts = from p in context.Products
                         where (from od in context.SalesOrderDetails
                                orderby od.OrderQty descending
                                where od.ProductId == p.ProductId
                                select od).Take(10).Any()
                         select p;

foreach (var product in topSellingProducts)
{
    Console.WriteLine(product.Name);
}


// Consulta #2:
//      Obtener una lista de los nombres de productos que tienen un precio mayor que el promedio de todos los precios de productos:

Console.WriteLine("\nConsulta #2");
var query2 = from p in context.Products
             where p.ListPrice > context.Products.Average(x => x.ListPrice)
             select p.Name;

foreach (var name in query2)
{
    Console.WriteLine(name);
}


// Consulta #3:
//      Obtener una lista de los nombres de productos que no tienen ningún producto relacionado en la tabla de detalles de pedido:

Console.WriteLine("\nConsulta #3");
var query3 = from p in context.Products
             where !context.SalesOrderDetails.Any(x => x.ProductId == p.ProductId)
             select p.Name;

foreach (var name in query3)
{
    Console.WriteLine(name);
}


Console.ReadLine();
