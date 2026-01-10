using Microsoft.Data.SqlClient;
using System;
using System.Data;

namespace ADOProject
{
    internal class DbConnected
    {
        static string connectionString = "Data Source=HEY_AYUSH;Initial Catalog=institute;Integrated Security=True;Encrypt=False;TrustServerCertificate=True";
            
        public static void ConnectDatbase()
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                connection.Open();
                Console.WriteLine("Database Connected Successfully");
            }
        }

        public static void DataReaderClass()
        {
            using (SqlConnection con = new SqlConnection(connectionString))
            {
                con.Open();

                SqlCommand cmd = new SqlCommand("SELECT student_id, student_name FROM Students", con);
                SqlDataReader reader = cmd.ExecuteReader();

                while (reader.Read())
                {
                    int id = reader.GetInt32(0);
                    string name = reader.GetString(1);

                    Console.WriteLine($"{id} - {name}");
                }

                reader.Close();
            }
        }

        public static void DataAdapterClass()
        {
            SqlConnection con = new SqlConnection(connectionString);

            // 1️⃣ Create DataAdapter
            SqlDataAdapter adapter =
                new SqlDataAdapter("SELECT student_id, student_name FROM Students", con);

            // 2️⃣ Fill DataSet
            DataSet ds = new DataSet();
            adapter.Fill(ds, "Students");

            // 3️⃣ Modify data (Disconnected)
            ds.Tables["Students"].Rows[0]["student_name"] = "Updated Name";

            // 4️⃣ Auto-generate Update command
            SqlCommandBuilder builder = new SqlCommandBuilder(adapter);

            // 5️⃣ Push changes to database
            adapter.Update(ds, "Students");

            Console.WriteLine("Data Updated Successfully");
        }

        public static void CreateTable()
        {
            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    connection.Open();

                    string sql = @"
                    CREATE TABLE studentfulldetails
                    (
                        id INT PRIMARY KEY,
                        name VARCHAR(50)
                    )";

                    using (SqlCommand cmd = new SqlCommand(sql, connection))
                    {
                        cmd.ExecuteNonQuery();
                    }

                    Console.WriteLine("Table created successfully");
                }
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.ToString());
            }
        }
    }
}
