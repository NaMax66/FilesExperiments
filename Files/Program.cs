using System;
using System.IO;
using System.Text;


namespace Files
{
    class Program
    {
        static void Main(string[] args)
        {
            //string test = File.ReadAllText("LogExample.txt", Encoding.Default);
            //Console.WriteLine(test);
            //Console.ReadKey();

            string sorceFile = "LogExample.txt";
            string newFile = "Copy.txt";

            CopyFileUsingFileClass(sorceFile, newFile);

            //FileStream fileStream = new FileStream()
        }

        private static void CopyFileUsingFileClass(string sorceFile, string newFile)
        {
            //string[] lines = File.ReadAllLines(sorceFile, Encoding.Default);

            int i = 1; //it needs for new files names
            string fileExtention = Path.GetExtension(newFile);
            string orginalFileName = newFile.Remove(newFile.Length - fileExtention.Length);
            string finalFileName = newFile;

            while (File.Exists(finalFileName))
            {
                finalFileName = orginalFileName + i + fileExtention;
                i++;
            }
            File.Copy(sorceFile, finalFileName);
            Console.WriteLine(string.Format("file {0} has been copied to file {1}",sorceFile, finalFileName));
        }

      
    }
}
