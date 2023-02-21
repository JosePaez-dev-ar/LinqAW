Console.WriteLine("Ejecución Diferida");

// Consulta pero no la ejecuta de inmediato:

var numeros = Enumerable.Range(1, 10);
var numerosFiltrados = numeros.Where(n => n % 2 == 0);
//numeros = Enumerable.Range(1, 5);

foreach (var numero in numerosFiltrados)
{
    Console.WriteLine(numero);
}


