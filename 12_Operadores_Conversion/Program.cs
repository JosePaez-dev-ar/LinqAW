using Entidades.Data;
using System.Collections.Generic;

var context = new ApplicationDbContext();

Console.WriteLine("Operadores de Conversión");
/*
Operadores de Conversión:
    Cast: convierte una secuencia de un tipo de datos a otro tipo de datos.
    OfType: filtra los elementos de una secuencia por tipo de datos. 
    ToArray, ToList, ToDictionary: convierte una secuencia a un arreglo, lista o diccionario respectivamente.
*/

List<object> objects = new List<object> { 1, "2", 3.0, "4.0" };


//  OfType
//      Filtra la lista de objetos y devuelve solo los elementos que son de tipo cadena
List<string> strings1 = objects.OfType<string>().ToList();


// TODO: Revisar 
//  Cast
//      Convierte la lista de objetos en una lista de cadenas. 
//List<string> strings2 = objects.Cast<string>().ToList();


//  ToList:
//      Convierte un arreglo de números en una lista de números
int[] numbers = { 1, 2, 9, 3, 4, 5 };
List<int> list = numbers.ToList();


// ToDictionary
//      Convierte en un diccionario cuyas claves son los números y los valores son los mismos números.
Dictionary<int, int> dictionary = numbers.ToDictionary(n => n);


//  ToList:
//      Convierte los productos con un precio mayor a 100 en una lista de objetos.
var productos = context.Products.Where(p => p.ListPrice > 100).ToList();


// ToDictionary:
//      Convierte los productos en un diccionario donde la clave es el ProductID y el valor es el objeto Producto.
var productosDiccionario = context.Products.ToDictionary(p => p.ProductId);


// ToArray:
//      Convierte las categorías en un array de objetos.
var categoriasArray = context.ProductCategories.ToArray();


//  ToList:
//      Convierte la consulta en una lista de productos de color rojo
var listaProductos = context.Products.Where(p => p.Color == "Red").ToList();