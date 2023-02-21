using Entidades.Data;
using Entidades.Models;

var context = new ApplicationDbContext();

Console.WriteLine("Operadores de ordenamiento");

/*
 Operadores de ordenamiento:
        OrderBy: ordena los elementos de una secuencia en orden ascendente.
        OrderByDescending: ordena los elementos de una secuencia en orden descendente.
        ThenBy: ordena los elementos de una secuencia según una segunda clave en orden ascendente.
        ThenByDescending: ordena los elementos de una secuencia según una segunda clave en orden descendente.
 */


var resultados = context.People.Where(objeto => objeto.FirstName == "Mary")
                        .OrderBy(objeto => objeto.LastName)
                        .ThenBy(objeto => objeto.MiddleName);
