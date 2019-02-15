using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace Labs_08_files
{
    class Program
    {
        static void Main(string[] args)
        {
            //Read file
            string data01 = File.ReadAllText("file.txt");
            Console.WriteLine(data01);

            //Add Encoding
            string data02 = File.ReadAllText("file.txt", Encoding.UTF8);
            Console.WriteLine(Environment.NewLine + data02);

            //Read as array
            string[] data03 = File.ReadAllLines("file.txt");
            Console.WriteLine("\n\n --+== Reading as an array ==+-- \n\n");
            Console.WriteLine(data03[0]);
            Console.WriteLine(data03[1]);

            //Write data
            File.WriteAllText("file2.txt", "Here is a new document for \nThe hardest of YEEEEETS");
            string data04 = File.ReadAllText("file2.txt");
            Console.WriteLine("\n\n --+== Showing that file2 has content ==+--\n");
            Console.WriteLine(data04);

            //Write data in an array
            Console.WriteLine("\n\n --+== Now write an array to text file and read it back  ==+--\n");
            File.WriteAllLines("file3.txt", data03);
            Console.WriteLine(File.ReadAllText("file3.txt"));

            //Copy file
            File.Copy("file.txt", "copyOfFile1.txt", true);        //The "true", refers to overwrite enabled

            //Delete file
            File.Delete("copyOfFile1.txt");

            //Check file exists
            Console.WriteLine(File.Exists("copyOfFile1.txt"));

            //Date Created/Last Modified
            File.GetCreationTime("file.txt");
            File.GetLastAccessTime("file.txt");

            //EXTRA INFO
            FileInfo fileInfo = new FileInfo("file.txt");
            Console.WriteLine(fileInfo.DirectoryName);
            Console.WriteLine(fileInfo.Extension);

            //Directory Control
            Directory.CreateDirectory("FolderA");
            Directory.CreateDirectory("FolderB");
            Directory.Delete("FolderB");
            File.Create("FolderA/Yeet.txt");
            Console.WriteLine("\n --+== Display files in a folder in an array ==+--\n");
            var fileArray = Directory.GetFiles("FolderA");
            Console.WriteLine(fileArray[0]);
        }
    }
}
