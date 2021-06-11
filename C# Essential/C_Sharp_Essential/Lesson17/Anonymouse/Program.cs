using System;
using System.Collections.Generic;
using System.Linq;

namespace Anonymouse
{
    public class Employee
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public decimal Salary { get; set; }
    }

    class Program
    {
        static void Main(string[] args)
        {
            var employees = new List<Employee>
            {
            new Employee
                { FirstName = "Ivan",
                    LastName = "Ivanov",
                    Salary = 120000},
             new Employee
             {FirstName = "Petro",
                 LastName = "Penrov",
                 Salary = 60000},
             new Employee
             {FirstName = "Stepan",
                 LastName = "Stepanov",
                 Salary = 200000 }
            };


            var query =
                from employee in employees
                where employee.Salary > 100000
                orderby employee.LastName, employee.FirstName
                select new
                {
                    LastName = employee.LastName,
                    FirstName = employee.FirstName,
                    Salary = employee.Salary
                };

            foreach (var element in query)
            {
                Console.WriteLine("{0}, {1}, {2}", element.LastName, element.FirstName, element.Salary);
            }

        }
    }
}
