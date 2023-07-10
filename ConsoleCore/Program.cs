using Library;
using Newtonsoft.Json;

var greg = new Person
{
    FirstName = "Greg",
    LastName = "Ayer",
    Age = 37
};

IGreeter greeter = new Greeter();

Console.WriteLine(greeter.SayHello(greg.FirstName));
var gregJson = JsonConvert.SerializeObject(greg);
Console.WriteLine(gregJson);
