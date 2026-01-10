using System;
using System.IO;
using System.Text;
using static System.Net.Mime.MediaTypeNames;


namespace MyApp
{
    public class Program
    {
        /*
        static void Main(string[] args)
        {

            //disk me file aise create karte hain
            string filepath = @"D:\BridgeLabs\FileHandling\FileHandlingg\Ayush.txt";

            //Create an Instance of FileStream Class By specifying the File Path and File Mode
            //FileMode is going to be Create as we are going to create a New File

            //FileStream FileStream = new FileStream(filepath, FileMode.Create);
            FileStream fs = new FileStream(filepath, FileMode.Append);

            byte[] bytedata = Encoding.Default.GetBytes("Here i am praticing the C# file handling");

            //Write the Byte Array into the File Stream Object using the Write Method
            //array (bytedata): The buffer containing data to write to the stream.
            //offset (0): The zero-based byte offset in the array from which to begin copying bytes to the stream.
            //count (bytedata.Length): The maximum number of bytes to write.

            fs.Write(bytedata, 0, bytedata.Length);

            fs.Close();  // filestream ka object close krne le liye
            Console.Write("Successfully saved file with data praricing C# file handling");
            Console.ReadKey();

        }
        */


        /*
        static void Main(string[] args)
        {
            string filepath = @"D:\BridgeLabs\FileHandling\FileHandlingg\Ayush.txt";
            string data;

            //Create an Instance of FileStream Class By specifying the File Path, File Mode, FileAccess
            //FileMode is going to be Open as we are going to read the data from the file
            //To Read the File, we are providing Read Access
            FileStream fs = new FileStream(filepath, FileMode.Open, FileAccess.Read);

            //Create an Instance of StreamReader Object to Read the Data from the Stream
            //To the Constructor of StreamReader, pass the fileStream Object i.e. the stream to be read.

            using (StreamReader streamReader = new StreamReader(fs)){
                //ReadToEnd method reads all characters from the current position to the end of the stream. 
                //It will return the rest of the stream as a string, from the current position to the end. 
                //If the current position is at the end of the stream, returns an empty string ("").
                data = streamReader.ReadToEnd();

                //print the data 
                Console.WriteLine(data);

                Console.ReadKey();
            }
        }
        */


        /*
        static void Main(string[] args)
        {
            StreamWriter st = new StreamWriter("D:\\BridgeLabs\\FileHandling\\FileHandlingg\\MyFile.txt");

            Console.WriteLine("Enter the text you want to enter in file");

            string inputData = Console.ReadLine();

            st.Write(inputData);
            Console.WriteLine("Data has been Written to the file");

            //Clears all the buffers for the current writer vy calling hye flush methord of the streamwriteer object
            st.Flush();

            st.Close();
            Console.ReadKey();

        }
        */


        /*
        static void Main(string[] args)
        {
            string filepath = @"D:\BridgeLabs\FileHandling\FileHandlingg\Ayush.txt";

            int a, b, result;
            a = 20;b = 20; result = a + b;

            // using block automatically calls the flush and close Mthod of StreamWriter ojbect .
            //This methord is overridden methord of the streamwriter in which we pass the true value after file 
            // so that what we are writing can be ovverridden.
            using(StreamWriter st = new StreamWriter(@"D:\BridgeLabs\FileHandling\FileHandlingg\Ayush.txt",true))
            {
                st.WriteLine($"Sum of {a} + {b} = {result}");
                //no need to call the flush and close methord
            }

            Console.WriteLine("Variable DAta is Saved into the file");
            Console.ReadKey();
        }

        */


        //---------------------SSTTRREEAAMM   RRRRRRRREADER_____________________________



        /*
        static void Main(string[] args)
        {
            string filepath = "D:\\BridgeLabs\\FileHandling\\FileHandlingg\\Ayush.txt";

            StreamReader sr = new StreamReader(filepath);
            Console.WriteLine("Content of the file");

            //BaseStrem: returns the underlying stream.
            //Seek: The new Position Within the Current Stream
            //SeekOrigin.Begi: Specifies the Beginning of a strem

            sr.BaseStream.Seek(0, SeekOrigin.Begin);

            //It reads a line of characters from the current sstream and returns the dat as a string.
            //It returns the next line from the impt stream or null if the end of the input stream is reached.

            String strData = sr.ReadLine();
            while(strData != null)
            {
                Console.WriteLine(strData);
                strData = sr.ReadLine();
            }

            Console.ReadLine();
            //Close teh streamReader Object
            sr.Close();
            Console.ReadKey();
        }
        */


        /*
        static void Main(string[] args)
        {
            string filepath = "D:\\BridgeLabs\\FileHandling\\FileHandlingg\\Ayush.txt";
            Console.WriteLine("Content of the file");

            using (StreamReader reader = new StreamReader(filepath))
            {// Here read to end is used os that i can read from start to end.
                Console.WriteLine(reader.ReadToEnd());
            }
        }

        */


        /*
        static void Main(string[] args)
        {
            //Set the File Path
            string FilePath = @"D:\MyFile.txt";
            //Check if the File Exists using the Static Exists Method of the File Class
            //Exits Method will take the string File Path as a parameter
            if (File.Exists(FilePath))
            {
                Console.WriteLine("MyFile.txt File Exists in D Directory");
            }
            else
            {
                Console.WriteLine("MyFile.txt File Does Not Exist in D Directory");
            }
            Console.ReadKey();
        }

        */


        /*
        static void Main(string[] args)
        {
            //Set the File Path
            string FilePath = @"D:\MyFile.txt";
            //Check if the File Exists using the Static Exists Method of the File Class
            //Exits Method will take the string File Path as a parameter
            if (File.Exists(FilePath))
            {
                Console.WriteLine("MyFile.txt File Exists in D Directory");

                string[] lines = File.ReadAllLines(FilePath); //read all lines from file and store in lines.
        //and print here.
                foreach(var line in lines)
                {
                    Console.WriteLine(line);
                }
            }
            else
            {
                Console.WriteLine("MyFile.txt File Does Not Exist in D Directory");
            }
            Console.ReadKey();
        }

        */



        //-------------------TTTTTTTTTTEXT  WRITERRRRRRRRRR-------------------------------//

        /*
        static void Main(string[] args)
        {
            string filePath = @"D:\BridgeLabs\FileHandling\FileHandlingg\Piyush.txt";

            using (TextWriter textwriter = File.CreateText(filePath)) 
            {
                textwriter.WriteLine("Hello TextWriter Abstract Class!");
                textwriter.WriteLine("File Handling Tutorial in c#");
            }

            Console.WriteLine("Write Successful");
            Console.ReadKey();
        }
        */

        /*
        static void Main(string[] args)
        {
            WriteCharAsync();
            Console.ReadKey();
        }
        //We can also asynchrnously write characters to stream by using writeAsync(Char) methord.
        public static async void WriteCharAsync()
        {
            String filepath = @"D:\BridgeLabs\FileHandling\FileHandlingg\Piyush.txt";
            using (TextWriter textwrite = File.CreateText(filepath))
            {
                await textwrite.WriteLineAsync("Hello TextWriter Abstract Class");

                await textwrite.WriteLineAsync("File Handling tutorial in C#");
            }
            Console.WriteLine("Async write Successful");
        }

        */

        /*
        static void Main(string[] args)
        {
            String filepath = @"D:\BridgeLabs\FileHandling\FileHandlingg\Piyush.txt";
            using (TextReader reader = File.OpenText(filepath))
            {
                Console.WriteLine(reader.ReadLine()); //Read one line
            }

            using (TextReader reader = File.OpenText(filepath))
            {
                char[] ch = new char[4];
                reader.ReadBlock(ch, 0, 4);
                Console.WriteLine(ch);  // REad 4 char
            }

            using (TextReader reader = File.OpenText(filepath))  //Read Full File
            {
                Console.WriteLine(reader.ReadToEnd());
            }
            Console.ReadKey();
        }
        */


        //------------------------Binary Writer-------------------------------------/////////


        /*
        static void Main(string[] args)
        {
            using(BinaryWriter writer = new BinaryWriter(File.Open("D:\\BridgeLabs\\FileHandling\\FileHandlingg\\MyBinaryFile.bin" , FileMode.Create)))
            {
                //Writting Error Log
                writer.Write("0x80234400");
                writer.Write("Windows Explorer Has Stopped Working");
                writer.Write(true);
            }
            Console.WriteLine("Binary File Created!");
            Console.ReadKey();
        }
        */
        /*
            static void Main(string[] args)
            {
                WriteDataToBinaryFile();
                ReadDataFromBinaryFile();
                Console.ReadKey();
            }

            static void WriteDataToBinaryFile()
            {
                using (BinaryWriter writer = new BinaryWriter(File.Open("D:\\BridgeLabs\\FileHandling\\FileHandlingg\\MyBinaryFile2.bin", FileMode.Create)))
                {
                    //Writting Error Log
                    writer.Write("0x80234400");
                    writer.Write("Windows Explorer Has Stopped Working");
                    writer.Write(true);
                }
            }

            static void ReadDataFromBinaryFile()
            {
                using (BinaryReader readrer = new BinaryReader(File.Open("D:\\BridgeLabs\\FileHandling\\FileHandlingg\\MyBinaryFile2.bin" , FileMode.Open)))
                {
                    Console.WriteLine("Error Code :" + readrer.ReadString());
                    Console.WriteLine("Message :" + readrer.ReadString());
                    Console.WriteLine("Restart Explorer:" + readrer.ReadBoolean());
                }
            }
        */

        //------------------SSSSString Writer--------------------------------///////////

        /*
        static void Main(string[] args)
        {
            String text = "Hello . This is First Line \nHello. This is Second Line \nHello. This is Third Line";

            // writing string into StringBuilder
            StringBuilder builder = new StringBuilder();
            StringWriter writer = new StringWriter(builder);

            writer.WriteLine(text);
            writer.Flush();
            writer.Close();

            //Read Entry
            StringReader reader = new StringReader(builder.ToString());

            while(reader.Peek() > -1)
            {
                Console.WriteLine(reader.ReadLine());
            }

            Console.ReadKey();
        }

        */

        /*
        static void Main(string[] args)
        {
            string text = @"you are reading this stringwriter and stringReader in c#";
            
            using (StringReader reader = new StringReader(text))
            {
                int count = 0;
                string line;
                while((line = reader.ReadLine())!= null)
                {
                    count++;
                    Console.WriteLine("Line {0}: {1}", count, line);
                }
            }
            Console.ReadKey();
        }
        */

        //------------------File Info Class -------------------------------///////

        /*
        static void Main(string[] args)
        {
            string path = @"D:\\BridgeLabs\\FileHandling\\FileHandlingg\\Mytextfile.txt";
            FileInfo fileinfo = new FileInfo(path);
            fileinfo.Create();
            {
                Console.WriteLine("File has been created");
            }
            Console.ReadKey();
        }

        */

        /*
        static void Main(string[] args)
        {
            string path = @"D:\\BridgeLabs\\FileHandling\\FileHandlingg\\Mytextfile.txt";
            FileInfo fileinfo = new FileInfo(path);
            StreamWriter str = fileinfo.CreateText();

            str.WriteLine("Hello");
            Console.WriteLine("File has been created with text");
            str.Close();
            Console.ReadKey();
            
        fileinfo.Delete();  used to delete the file.

        }
        */





        ///----------------------Buffer Reader--------------------------////////

        // Buffering means Data Stored in temporarily in memory.
        // Read/write happens in chunks, not character-by-character



        //BufferedStream works with bytes, not text

        //Must be wrapped around another stream

        //Faster than direct FileStream

        //Use StreamReader/Writer for text

        //Use BufferedStream for binary data

        /*
        static void Main()
        {
            using (FileStream source = new FileStream("source.bin", FileMode.Open))
            using (FileStream destination = new FileStream("dest.bin", FileMode.Create))
            using (BufferedStream bsRead = new BufferedStream(source))
            using (BufferedStream bsWrite = new BufferedStream(destination))
            {
                byte[] buffer = new byte[1024];
                int bytesRead;

                while ((bytesRead = bsRead.Read(buffer, 0, buffer.Length)) > 0)
                {
                    bsWrite.Write(buffer, 0, bytesRead);
                }
            }
        }
        */


        /*
        static void Main()
        {
            string message = "Hello BufferedStream in C#";

            using (FileStream fs = new FileStream("data.txt", FileMode.Create))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                byte[] data = Encoding.UTF8.GetBytes(message);

                bs.Write(data, 0, data.Length);
                bs.Flush(); // force write to file
            }

            Console.WriteLine("String written successfully");
        }
        */

        /*
        static void Main()
        {
            using (FileStream fs = new FileStream("data.txt", FileMode.Open))
            using (BufferedStream bs = new BufferedStream(fs))
            {
                byte[] buffer = new byte[1024];
                int bytesRead = bs.Read(buffer, 0, buffer.Length);

                string text = Encoding.UTF8.GetString(buffer, 0, bytesRead);
                Console.WriteLine(text);
            }
        }
        */


    }

}