using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MulticastDelegate
{
    internal class ReflectionMetaData
    {
    }
    class Student
    {
        public int Rollno {  get; set; }
        public string Name { get; set; }

        public Student()
        {
            Rollno = 0;
            Name = String.Empty;

        }

        public Student(int rno , string str)
        {
            Rollno = rno;
            Name = str;
        }

        public void displayData(int roll , String s)
        {
            Console.WriteLine("Roll no is : {0}", Rollno);
            Console.WriteLine("Name : {0}", Name);
        }

    }

    class GFG
    {
        static void Main(string[] args)
        {
            Assembly executing = Assembly.GetExecutingAssembly();

            Type[] types = executing.GetTypes();
            
            foreach(var item in types)
            {
                Console.WriteLine("Class : {0}", item.Name);

                MethodInfo[] methods = item.GetMethods();

                foreach (var method in methods)
                {
                    Console.WriteLine("MethodName : {0}", method.Name);

                    ParameterInfo[] parameters = method.GetParameters();
                    foreach(var arg in parameters)
                    {
                        Console.WriteLine("parameter : {0}  Type : {1}", arg.Name, arg.ParameterType);
                    }
                }
            }
        }
    }
}
