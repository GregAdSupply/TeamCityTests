using Library;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleFramework
{
    internal class Program
    {
        static void Main(string[] args)
        {
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
        }
    }
}
