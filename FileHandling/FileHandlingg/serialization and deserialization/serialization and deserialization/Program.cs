using System;
using System.Runtime.Intrinsics.Arm;
using System.Text.Json;

namespace MyApp
{

    //Serialization and Deserialization
    //seri convertes object to json and desriali convdrts json back to object.

    public class Person
    {
        public int Id { get; set; }
        public String Name { get; set; }
    }
    public class Program
    {
        // Serialize Object to Json

        /*
        static void Main(string[] args)
        {
            Person person = new Person
            {
                Id = 1,
                Name = "Ayush"
            };

            string json = JsonSerializer.Serialize(person);
            Console.WriteLine(json);
            //File.WriteAllText("person.json", json);
        }
        
        */

        //Deserialization JSON string --> Object

        /*
  
        static void Main(string[] args)
        {
            string json = "{\"Id\":1,\"Name\":\"Ayush\"}";

            Person person = JsonSerializer.Deserialize<Person>(json);
            Console.WriteLine(person.Name);
            Person person = JsonSerializer.Deserialize<Person>(Json);
        }
        */


        //Line Purpose
        //File.WriteAllText(...)	Store data to file
        //JsonSerializer.Deserialize<>() Convert JSON → Object
        //Real-Life Flow

        //Object → Serialize

        //JSON → Save to file

        //JSON → Deserialize

        //Object restored in memory

    }
}