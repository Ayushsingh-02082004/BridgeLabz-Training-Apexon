using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Text;

namespace ADOProject
{
    public class crudUsingsp
    {

        public static string connectionString = "Data Source=HEY_AYUSH;Initial Catalog=institute;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";

        public static void crudOperation()
        {
            // commented code untouched

            while (true)
            {
                Console.WriteLine("\n--- STUDENT CRUD MENU ---");
                Console.WriteLine("1. Insert Student");
                Console.WriteLine("2. View Students");
                Console.WriteLine("3. Update Student");
                Console.WriteLine("4. Delete Student");
                Console.WriteLine("5. Exit");
                Console.Write("Enter choice: ");
                int choice = int.Parse(Console.ReadLine());

                switch (choice)
                {
                    case 1: InsertStudent(); break;
                    case 2: GetAllStudents(); break;
                    case 3: UpdateStudent(); break;
                    case 4: DeleteStudent(); break;
                    case 5: return;
                }
            }
        }

        public static void InsertStudent()
        {
            Console.Write("Enter Name: ");
            string name = Console.ReadLine();

            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_InsertStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure; //THis tells ado.net that ihis is stored procedure name not sql text query.

                cmd.Parameters.Add("@student_name", System.Data.SqlDbType.VarChar, 50)
                              .Value = name;

                con.Open();
                cmd.ExecuteNonQuery();
            }

            Console.WriteLine("Student inserted successfully");
        }

        static void GetAllStudents()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_getAllStudents", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                con.Open();
                SqlDataReader reader = cmd.ExecuteReader();

                Console.WriteLine("Id\tName");
                while (reader.Read())
                {
                    Console.WriteLine($"{reader["student_id"]}\t{reader["student_name"]}");
                }
            }
        }
        static void UpdateStudent()
        {
            Console.WriteLine("Enter new id : ");
            int id = int.Parse((Console.ReadLine()));

            Console.WriteLine("Enter new name : ");
            string name = Console.ReadLine();

            using (SqlConnection con = new SqlConnection(connectionString))
            {

                SqlCommand cmd = new SqlCommand("sp_UpdateStudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@student_id", System.Data.SqlDbType.Int)
                              .Value = id;
                cmd.Parameters.Add("@student_name", System.Data.SqlDbType.VarChar, 50)
                              .Value = name;

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                Console.WriteLine(rows > 0 ? "Updated Successfully" : "No Student Found");
            }

        }
        static void DeleteStudent()
        {
            Console.Write("Enter ID to delete: ");
            int id = int.Parse(Console.ReadLine());


            using (SqlConnection con = new SqlConnection(connectionString))
            {
                SqlCommand cmd = new SqlCommand("sp_deletestudent", con);
                cmd.CommandType = System.Data.CommandType.StoredProcedure;

                cmd.Parameters.Add("@student_id", System.Data.SqlDbType.Int)
                                      .Value = id; 

                con.Open();
                int rows = cmd.ExecuteNonQuery();

                Console.WriteLine(rows > 0 ? "Deleted Successfully" : "No record found");
            }
        }
    }
}
