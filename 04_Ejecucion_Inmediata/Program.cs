Console.WriteLine("Ejecución Inmediata");

// Consulta que se ejecuta de inmediato:

var numeros = new List<int> { 1, 2, 3, 4, 5 };
var numerosFiltrados = numeros.Where(n => n % 2 == 0).ToList();

