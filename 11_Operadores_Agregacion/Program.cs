using Entidades.Data;
var context = new ApplicationDbContext();

Console.WriteLine("Operadores de Agregación");
/*
Operadores de Agregación:
    Count: cuenta el número de elementos en el conjunto de datos.
    Sum: calcula la suma de todos los elementos en el conjunto de datos.
    Average: calcula el promedio de todos los elementos en el conjunto de datos.
    Max: devuelve el valor máximo en el conjunto de datos.
    Min: devuelve el valor mínimo en el conjunto de datos.
*/


//  Sum:
//      Retorna la suma total de las ventas en la tabla SalesOrderDetails.
var totalVentas = context.SalesOrderDetails.Sum(d => d.LineTotal);
Console.WriteLine($"totalVentas = {totalVentas}");


//  Average:
//      Retorna el promedio de los precios de los productos en la tabla Products.
var promedioPrecios = context.Products.Average(p => p.ListPrice);
Console.WriteLine($"promedioPrecios = {promedioPrecios}");


//  Count:
//      Retorna la cantidad total de productos en la tabla Products.
var cantidadProductos = context.Products.Count();
Console.WriteLine($"cantidadProductos = {cantidadProductos}");


