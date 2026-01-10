using System;
using System.Collections.Generic;
using System.Text;

namespace CreationalDesignPattern
{

    //Prototype interface
    public interface IEmployeePrototype
    {
        IEmployeePrototype Clone();
    }

    //Concrete Prototype --class
    public class Employee: IEmployeePrototype
    {
        public String Name { get; set; }
        public String Department {  get; set; }

        public IEmployeePrototype Clone()
        {
            return (Employee)this.MemberwiseClone();
        }
    }

    class Prototype
    {
        //static void Main(string[] args)
        //{
        //    Employee emp1 = new Employee()
        //    {
        //        Name = "Ayush",
        //        Department = "IT"
        //    };

        //    Employee emp2 = (Employee)emp1.Clone();
        //    emp2.Name = "Rahul";

        //    Console.WriteLine(emp1.Name);
        //    Console.WriteLine(emp2.Name);

        //}
    }

}
