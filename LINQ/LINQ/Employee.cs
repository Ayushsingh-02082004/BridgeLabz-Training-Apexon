using System;
using System.Collections.Generic;
using System.Text;

namespace LINQ
{
    public class Employee
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Department { get; set; }
        public decimal Salary { get; set; }
        public DateTime JoiningDate { get; set; }

        public override string ToString()
        {
            return $"{Id} - {Name} ({Department}), Salary: {Salary:C}, Joined: {JoiningDate:yyyy-MM-dd}";
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> employees = new List<Employee>
            {
                new Employee { Id = 1, Name = "Alice",   Department = "IT",      Salary = 90000, JoiningDate = new DateTime(2025, 3, 12) },
                new Employee { Id = 2, Name = "Bob",     Department = "HR",      Salary = 60000, JoiningDate = new DateTime(2016, 7, 1) },
                new Employee { Id = 3, Name = "Charlie", Department = "IT",      Salary = 75000, JoiningDate = new DateTime(2009, 1, 20) },
                new Employee { Id = 4, Name = "Diana",   Department = "Finance", Salary = 85000, JoiningDate = new DateTime(2018, 11, 5) },
                new Employee { Id = 5, Name = "Eve",     Department = "IT",      Salary = 95000, JoiningDate = new DateTime(2021, 6, 15) },
                new Employee { Id = 6, Name = "Frank",   Department = "HR",      Salary = 65000, JoiningDate = new DateTime(2014, 2, 10) },
                new Employee { Id = 7, Name = "Grace",   Department = "Finance", Salary = 72000, JoiningDate = new DateTime(2017, 9, 25) }
            };

            Console.WriteLine("=== LINQ Demo with Employee Data ===\n");

            Console.WriteLine("How do you filter employee whose slalary fall between a specific range using LINQ?");
            var filterbetw = employees.Where(e => e.Salary >= 50000 && e.Salary <= 90000);

            Console.WriteLine("How can you use LINQ to convert all employee names to uppercase?");
            var uppercase_name = employees.GroupBy(e => e.Name.ToUpper());

            Console.WriteLine("How can you retrieve the top three highest-paid employees using LINQ?");
            var top3Paid = employees.OrderByDescending(e => e.Salary).Take(3);

            Console.WriteLine("How do you count the number of employees in each department using LINQ?");
            var countbydept = employees.CountBy(e => e.Department);

            Console.WriteLine("How do you find employees whose salary is greater than the average salary using LINQ?");
            var empsal_avg = employees.Average(e => e.Salary);
            var above_AvgEmployee = employees.Where(e => e.Salary > empsal_avg);

            Console.WriteLine("How can LINQ be used to group a list of employees by department and calculate the average salary for each employee?");
            var averagesalary = employees.GroupBy(e => e.Department).Select(g => new
            {
                Department = g.Key,  
                AverageSalary = g.Average(g => g.Salary)
            });

            Console.WriteLine("How do you use a lambda expression with the LINQ OrderBy method to sort a list of strings based on their length in ascending order?");
            var sortstring = employees.OrderByDescending(e => e.Name.Length).Select(e => e.Name);
            foreach (var emp in sortstring) Console.WriteLine($"String name by length is {emp}");

            Console.WriteLine("How can you use a lambda expression in LINQ to filter employees who joined in the last six months and belong to a specific department?");
            var last6month = employees.Where(e => e.Department == "IT" && e.JoiningDate >= DateTime.Now.AddMonths(-6));
            Console.WriteLine($"LatestEmployee by {last6month}");

            Console.WriteLine("Employees in IT Department.");
            var itemployees = from e in employees where e.Department == "IT" select e;
            foreach (var emp in itemployees) Console.WriteLine(emp);

            Console.WriteLine("Where salary is more than 70000");
            var itsalary = from e in employees where e.Salary >= 70000 select e.Salary;
            foreach (var emp in itsalary) Console.WriteLine(emp);

            Console.WriteLine("Name and salary"); // to fetch specfic property we have to use 
            var namesalary = from e in employees select new { e.Name, e.Salary };
            foreach (var emp in namesalary) Console.WriteLine($" Name : {emp.Name} salary is : {emp.Salary}");

            Console.WriteLine("Orderby/ThenBy");
            //var sorted = from e in employees orderby e.Salary descending, e.JoiningDate select e;
            var sorted = employees.OrderByDescending(e => e.Salary).ThenBy(e => e.JoiningDate);
            foreach (var emp in sorted) Console.WriteLine(emp);

            //Aggregate Function
            Console.WriteLine("Aggrigation");
            Console.WriteLine($"Total Employees {employees.Count()}");
            Console.WriteLine($"Average Salary{employees.Average(e => e.Salary):C}");
            Console.WriteLine($"Highest Salary{employees.Max(e => e.Salary):C}");
            Console.WriteLine($"Lowest Salary{employees.Min(e => e.Salary):C}");
            Console.WriteLine($"Total Salary Bill : {employees.Sum(e => e.Salary):C}");

            //GroupBy
            Console.WriteLine("Employees GroupBy dempartment");
            var grouped = employees.GroupBy(e => e.Department);
            foreach(var group in grouped)
            {
                Console.WriteLine($"Department: {group.Key}");
                    foreach(var emp in group)
                {
                    Console.WriteLine($"{emp.Name} - {emp.Salary:C}");
                }
            }

            //Top 3 hightst paid employees
            Console.WriteLine("Top 3 highest Paid employees : ");
            var topthree = employees.OrderByDescending(e => e.Salary).Take(3);
            foreach (var emp in topthree) Console.WriteLine(emp);

            //Employees except top 3
            Console.WriteLine("Employees except top 3: ");
            var except3 = employees.OrderByDescending(e => e.Salary).Skip(3);
            foreach (var emp in employees) Console.WriteLine(emp);


            //first/firstordefault
            var firstIt = employees.First(e => e.Department == "IT");
            Console.WriteLine($"first it employee {firstIt}");

            //highest paid
            var highestPaid = employees.OrderByDescending(e => e.Salary).First();
            Console.WriteLine($"HighestPaid {highestPaid}");

            var oldemployee = employees.FirstOrDefault(e => e.JoiningDate.Year < 2010);
            Console.WriteLine($"Old employees are {oldemployee}");


            //Any / All / Contains
            Console.WriteLine($"Any employee in Marketing? {employees.Any(e => e.Department == "Finance")}");   //Return Boolean value true when if any value present.
            Console.WriteLine($"Where All IT earn > 70000  {employees.Where(e => e.Department == "IT").All(e => e.Salary > 70000)}"); //
            Console.WriteLine($"Is alice present{employees.Select(e => e.Name).Contains("Alice")}");

            //Set Operations
            var deplist1 = employees.Select(e => e.Department);
            var deplist2 = new[] { "IT", "Finance", "Marketing" };

            Console.WriteLine("Distinct : " + String.Join(",", deplist1.Distinct()));
            Console.WriteLine("Union : " + String.Join(",", deplist1.Union(deplist2)));
            Console.WriteLine("Intersect : " + String.Join(",", deplist1.Intersect(deplist2)));
            Console.WriteLine("Except : " + String.Join(",", deplist1.Except(deplist2)));

            var Departments = new[]
            {
                new {Departments = "IT" , Location = "Building A"},
                new {Departments = "HR" , Location = "Building B"},
                new {Departments = "Finance" , Location = "Building C"}
            };

            Console.WriteLine("Join with department locations");
            var joined = employees.Join(Departments, emp => emp.Department, dept => dept.Departments , (emp, dept) => new {emp.Name , emp.Salary , dept.Location});


            //var Complex Query
            var complexQuery = from emp in employees where emp.Department == "IT" && emp.JoiningDate.Year > 2018 orderby emp.Salary descending select emp;

            foreach (var emp in complexQuery)
            {
                Console.WriteLine(emp);
            }

            Console.WriteLine("Linq demo completed.");


        }
    }
}


