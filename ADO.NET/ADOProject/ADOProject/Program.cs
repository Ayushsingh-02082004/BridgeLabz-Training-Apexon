using ADOProject;
using System;

namespace MyApp
{
    internal class Program
    {

        static void Main(string[] args)
        {
            try {
                //DbConnected.CreateTable();
                crudUsingsp.crudOperation();
            }

            catch (Exception e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}