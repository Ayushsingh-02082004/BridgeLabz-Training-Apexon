using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace oop
{

    //POCO stands for Plain Old CLR Object.
    //It is a simple C# class that:
    //Has no inheritance from special framework classes.
    //Has no attributes that tightly couple it to a framework.
    //Usually contains properties, fields, and sometimes methods.
    //Is mainly used for data representation (models, entities, DTOs, etc.).


    public class Employee
    {
        // ===== Read-only Property =====
        private int _employeeId;   // Backing field

        public int EmployeeId      // Getter only
        {
            get { return _employeeId; }
        }

        // ===== Write-only Property =====
        private string _password;  // Backing field

        public string Password      // Setter only
        {
            set { _password = value; }
        }

        // ===== Read/Write Property =====
        private string _name;

        public string Name           // Getter + Setter
        {
            get { return _name; }
            set { _name = value; }
        }

        // Constructor to set read-only value
        public Employee(int id)
        {
            _employeeId = id;
        }
    }

}
