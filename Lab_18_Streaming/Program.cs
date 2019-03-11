using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Lab_18_Streaming
{
    class Program
    {
        static void Main(string[] args)
        {
            //Not using streaming, this is direct writing
            //string File01 = File.ReadAllText("tests.text");
            List<string> myList = new List<string>();

            //StreamReader
            //Create stream reader object
            //Enclose it in a using block (To complete cleanup)

            //Relative Path
            string path01 = "data.txt";
            //Absolute Path
            string path02 = "C://labs/Lab_18_Streaming/bin/Debug/data.txt";
            //Absolute path with backslash
            string path03 = "C:\\labs\\Lab_18_Streaming\\bin\\Debug\\data.txt";
            //Absolute path with @ symbol
            string path04 = @"C:\labs\Lab_18_Streaming\bin\Debug\data.txt";
            //Path using environment variables
            string path05 = Path.Combine(Environment.ExpandEnvironmentVariables("%userprofile%"), "data.txt");
            //Path using SpecialFolder
            string path06 = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\data.txt";
            Console.WriteLine(path06);

            using (var reader = new StreamReader(path06))
            {
                //ReadLine() stream and read line by line
                //Read every line
                //Output to string
                //Test each time that the string is not null
                //Continue looping until out of data

                string output;
                while ((output = reader.ReadLine()) != null)
                {
                    myList.Add(output);
                }
            }
            myList.ForEach(output => Console.WriteLine(output));

            //while(Reader.Peek() != -1){} checks for end of data, by looking at next character without removing it
        }
    }
}
