using Entidades.Data;
using Microsoft.EntityFrameworkCore;

var context = new ApplicationDbContext();

Console.WriteLine("Operadores de Agrupación");
/*
 Operadores de agrupación:
        GroupBy: agrupa los elementos de una secuencia según una clave común.
        ToLookup: crea un objeto de tipo Lookup que permite acceder a los elementos de una secuencia agrupados por clave.
        Join: combina dos secuencias según una clave común.
        GroupJoin: realiza una operación de join y devuelve los resultados agrupados por la clave común.
 */


// GroupJoin:
//      Agrupar las ventas de la tabla "SalesOrderHeader" por el año 
var ventasXaño = context.SalesOrderHeaders
                    .GroupBy(s => s.OrderDate.Year)
                    .Select(g => new
                    {
                        Año = g.Key,
                        TotalVentas = g.Sum(s => s.TotalDue)
                    });


