using Entidades.Data;
using Entidades.Models;

var context = new ApplicationDbContext();

Console.WriteLine("Encadenamiento de Operadores de Consulta");

// Where filtra la lista de productos para obtener solo aquellos cuyo precio es mayor a $50.
// OrderBy ordena los resultados filtrados por nombre en orden ascendente.
// Ambos operadores se encadenan en una sola expresión

var productosFiltradosYOrdenados = context.Products.Where(prod => prod.ListPrice > 50)
                                             .OrderBy(prod => prod.Name);


var customers = context.Customers.ToList();
