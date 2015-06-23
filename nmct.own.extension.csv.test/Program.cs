using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using CsvExtension;
using System.Diagnostics;

namespace nmct.own.CsvExtension.csv.test
{
    class Program
    {
        static void Main(string[] args)
        {
            Person stijn = new Person("stijn", "email-stijn", "grensstraat", 123456789);
            Person lars = new Person("lars", "email-lars", "grensstraat", 123456789);
            List<Person> persons = new List<Person>()
            {
                stijn, lars
            };

            string bigString = String.Empty;

            Stopwatch watch = new Stopwatch();
            watch.Start();
            Console.WriteLine("Start adding...");
            for(int i = 0, l = 10000; i < l; i++)
            {
                bigString += persons.ToCsv<Person>();
                Console.WriteLine("Big String adding: " + i);
            }

            watch.Stop();
            Console.WriteLine("Stop adding...");
        }
    }
}
