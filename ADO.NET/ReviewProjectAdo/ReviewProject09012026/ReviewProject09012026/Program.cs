using ReviewProject09012026.Interface;
using ReviewProject09012026.service;
using ReviewProject09012026.Service;

class Program
{
    static void Main()
    {
        IFileFactory factory;

        // CSV
        factory = new CsvFactory();
        var csvWriter = factory.CreateWriter();
        var csvReader = factory.CreateReader();

        csvWriter.Write("data.csv", "1,Ayush,India");
        FileWriterSingleton.Close();
        csvReader.Read("data.csv");
        FileWriterSingleton.Close();


        
        // JSON
        factory = new JsonFactory();
        var jsonWriter = factory.CreateWriter();
        var jsonReader = factory.CreateReader();

        jsonWriter.Write("data.json", "{ \"id\": 1, \"name\": \"Ayush\" }");
        FileWriterSingleton.Close();

        jsonReader.Read("data.json");

        FileWriterSingleton.Close();

       
    }
}
