using OCPLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    class Program
    {
        static void Main(string[] args)
        {
            List<PersonModel> applicants = new List<PersonModel>
            {
                new PersonModel { FirstName = "Tim", LastName = "Corey" },
                new PersonModel { FirstName = "Sue", LastName = "Storm" },
                new PersonModel { FirstName = "Nancy", LastName = "Roman" },
                new PersonModel { FirstName = "Albert", LastName = "Mihai" },
                new PersonModel { FirstName = "Tom", LastName = "Shelby" },
                new PersonModel { FirstName = "Florin", LastName = "Popescu"},
                new PersonModel { FirstName = "Eduard", LastName = "Cosmin" },
                new PersonModel { FirstName = "Alin", LastName = "Ionut" },
                new PersonModel { FirstName = "Alex", LastName = "Marian" },
                new PersonModel { FirstName = "Dan", LastName = "Mihai" },
                new PersonModel { FirstName = "Daniel", LastName = "Ionut" }
            };

            List<EmployeeModel> employees = new List<EmployeeModel>();
            Accounts accountProcessor = new Accounts();

            foreach (var person in applicants)
            {
                employees.Add(accountProcessor.Create(person));
            }

            foreach (var emp in employees)
            {
                Console.WriteLine($"{ emp.FirstName } { emp.LastName }: { emp.EmailAddress } IsManager: { emp.IsManager } IsExecutive: { emp.IsExecutive }");
            }

            Console.ReadLine();
        }
    }
}
