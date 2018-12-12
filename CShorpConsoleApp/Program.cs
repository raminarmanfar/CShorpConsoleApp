using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CShorpConsoleApp
{
    class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person("Ramin", new DateTime(1980, 06, 26));
            Console.WriteLine("Person name is: {0}. he is {1} years old.", person.Name, person.Age);
            Console.WriteLine("{0} has lived {1} days so far.", person.Name, person.DaysLived);
            Console.ReadKey();
        }
    }
}
