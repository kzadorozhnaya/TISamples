using System;
using System.Collections.Generic;
using System.Linq;

namespace LinqInterviewExample
{

    //  A team is having four Employees, two Testers and two Developers:
    //- David, 34 years(Tester)
    //- Louis, 22 years(Tester)
    //- Daniel, 38 years(Developer)
    //- Sandy, 31 years(Developer)

    //1. Create data structure, containing information about employees's type (tester/developer), names and age
    //2. Iterate trough all employees and write info about them to the console
    //3. Find and write into console name and age of youngest Developer

    class Program
    {
        static void Main(string[] args)
        {
            //1. Create data structure, containing information about employees's type (tester/developer), names and age
            List<IEmployee> employeeList = new List<IEmployee>
            {
                new Tester(34, "David"),
                new Tester(22, "Louis"),
                new Developer(38, "Daniel"),
                new Developer(31, "Sandy")
            };

            //2. Iterate trough all employees and write info about them to the console
            foreach (var employee in employeeList)
            {
                Console.WriteLine("Name is {0}, age is {1}, job is {2}", employee.Name, employee.Age, employee.GetType().Name);
            }

            //3. Find and write into console name and age of youngest Developer
            var youngestDeveloper = employeeList.OfType<Developer>().OrderBy(dev => dev.Age).First();
            Console.WriteLine("The name of youngest developer is: {0}, the age of youngest developer is: {1}", youngestDeveloper.Name, youngestDeveloper.Age);
        }
    }
}
