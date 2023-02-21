using Entidades.Data;
using Entidades.Models;

var context = new ApplicationDbContext();

Console.WriteLine("Consultas");


var customers = context.Customers.ToList();
var people = context.People.ToList();

IEnumerable<Customer> lst = from c in customers.Take(10)
                            select c;

foreach (var customer in lst)
    Console.WriteLine($"CustomerId = {customer.CustomerId} - ModifiedDate = {customer.ModifiedDate}");


//  Sintaxis de consulta 
var resultadosQry = from objeto in people
                    where objeto.FirstName == "Mary"
                    orderby objeto.LastName
                    select objeto;


//  Sintaxis de método
var resultadosMth = people.Where(objeto => objeto.FirstName == "Mary")
                        .OrderBy(objeto => objeto.LastName)
                        .ThenBy(objeto => objeto.MiddleName);

Console.ReadLine();