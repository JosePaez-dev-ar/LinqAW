using Entidades.Data;
using Entidades.Models;
using Microsoft.EntityFrameworkCore;

var context = new ApplicationDbContext();

Console.WriteLine("Operadores de Proyección");
/*
Operadores de Proyección:
    Select: Se utiliza para seleccionar un conjunto de propiedades específicas de una secuencia
    SelectMany: Se utiliza para seleccionar y proyectar datos de una secuencia anidada
    GroupBy: Se utiliza para agrupar una secuencia de objetos por una propiedad común y proyectar los resultados
*/

// Select #1
//      Retorna una lista con los nombres de todos los productos.
var nombresProductos = from p in context.Products
                       select p.Name;

// Select #2
//      Selecciona solo los precios de los productos
var preciosProductos = from p in context.Products
                       select p.ListPrice;

// Select #3
//      Seleccionar solo el nombre del producto y su precio
var productosYprecios = from p in context.Products
                        select new { Nombre = p.Name, Precio = p.ListPrice };

// Select #4
//      Retorna el nombre completo de las Personas
var personasNombre = from person in context.People
                     select new { Name = person.FirstName + " " + person.MiddleName + " " + person.LastName };


// SelectMany #1
//      Obtiene todos los productos vendidos por cada cliente
var productosVendidos = context.SalesOrderHeaders.SelectMany(s => s.SalesOrderDetails)
                .Where(d => d.SalesOrder.CustomerId == 11000)
                .Select(d => d.ProductId);

// SelectMany #2
//      Obtiene todos los detalles de facturas de ventas para un producto específico
var detallesVentas = context.SalesOrderHeaders.SelectMany(s => s.SalesOrderDetails)
                .Where(d => d.ProductId == 777)
                .Select(d => new { d.SalesOrderId, d.UnitPrice, d.OrderQty });

// SelectMany #3
//      Obtiene todos los pedidos de compra de proveedores que incluyen un producto específico
var pedidosProveedores = context.PurchaseOrderHeaders.SelectMany(p => p.PurchaseOrderDetails)
                .Where(d => d.ProductId == 423)
                .Select(d => d.PurchaseOrderId);


// GroupBy #1
//      Permite Agrupar ventas por mes y año:
var ventasPorMesAño = from s in context.SalesOrderHeaders
             group s by new { s.OrderDate.Month, s.OrderDate.Year } into g
             select new { Month = g.Key.Month, Year = g.Key.Year, TotalSales = g.Sum(x => x.TotalDue) };


Console.ReadLine();