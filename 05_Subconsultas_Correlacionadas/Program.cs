using Entidades.Data;

var context = new ApplicationDbContext();

Console.WriteLine("SubConsultas Correlacionadas");

/*
Subconsulta correlacionada:
    Es una consulta que depende de la consulta principal
    y se ejecuta una vez por cada fila de la consulta principal. 
    Es decir, los resultados de la subconsulta dependen de los valores de la fila actual de la consulta principal.
 */


//  Obtiene todos los clientes que tienen una orden en un estado específico:
var result1 = from c in context.Customers
              where context.SalesOrderHeaders
                    .Where(s => s.CustomerId == c.CustomerId &&
                                s.Status == 5)
                    .Any()
              select c;

//  Obtiene el nombre de los productos que se han vendido a un cliente específico:
var result2 = from p in context.Products
              where context.SalesOrderDetails
                    .Where(s => s.ProductId == p.ProductId &&
                                s.SalesOrder.CustomerId == 29566)
                    .Any()
              select p.Name;

Console.ReadLine();