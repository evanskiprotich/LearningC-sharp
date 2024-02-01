using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileHandlingDemo
{
    // File Handling

    // C# provides us with a number of classes to work with files.

    // File, StreamWriter and StreamReader classes.
    // All three classes are available in the System.IO namespace.

    // Note that we have to use double slashes \\ when writing the path. 
    // This is because if we only use a single slash, the compiler will think the single slash is
    // the beginning of an escape sequence and interpret \m as an escape sequence.
    // This will result in an error.

    // The using keyword here ensures that the Dispose() method is always called.
    // The Dispose() method is a pre-written method in the System namespace that
    // closes or releases any unmanaged resources such as files and streams once theycare no longer needed.
    // It is good practice to always use the using keyword whenever you are dealing with files.

    // EndOfStream is a property of the StreamReader class that returns true when the end of the file is reached.
    // sr.ReadLine() reads a line from the text file and returns it as a string.
    // You should always close your file once you no longer need it. -- sr.Close();
    class Program
    {
        static void Main(string[] args)
        {
            // Reading a Text File
            string path = "c:\\myFile.txt";
            using (StreamReader sr = new StreamReader(path))
            {
                while (sr.EndOfStream != true)
                {
                    Console.WriteLine(sr.ReadLine());
                }
                sr.Close();
            }

            // Handling Errors if file doesnt exist

            // Option 1: try…catch

            try
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            } catch (FileNotFoundException e)
            {
                Console.WriteLine(e.Message);
            }

            // Option 2: File.Exists()
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            }
            else
            {
                //Do something else
            }


            // Writing to a Text File

            // To write to a text file, we use the StreamWriter class.
            // If you want to append data to an existing file, you create a StreamWriter instance like this
            //StreamWriter sw = new StreamWriter(path, true); // -- where path is the path of the file and true indicates that we want to append the data
            // If you want to overwrite any existing data in the file, you create a StreamWriter instance like this
            //StreamWriter sw1 = new StreamWriter(path);

            // When we create the StreamWriter instance, the constructor looks for the file at the given path.If the file is not found, it creates the file.
            // After we instantiate our StreamWriter object, we can start writing to our file using the WriteLine() method as shown below:
            //sw.WriteLine("It is easy to write to a file.");
            // After we finish writing to the file, we have to close the file by writing
            //sw.Close();
            // Note that when you write to a text file, it is also good practice to enclose your code in a using statement.

            //Writing to the file
            using (StreamWriter sw = new StreamWriter(path, true))
            {
                sw.WriteLine("ABC");
                sw.WriteLine("DEF");
                sw.Close();
            }

            //Reading from the file
            if (File.Exists(path))
            {
                using (StreamReader sr = new StreamReader(path))
                {
                    while (!sr.EndOfStream)
                    {
                        Console.WriteLine(sr.ReadLine());
                    }
                    sr.Close();
                }
            }
            Console.Read();
        }
    }
}