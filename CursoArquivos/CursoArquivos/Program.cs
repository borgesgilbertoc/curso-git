using System;
using System.IO;

namespace CursoArquivos
{
    class Program
    {
        static void Main(string[] args)
        {
            string sourcePath = @"c:\temp\file1.txt";
            string targetPath = @"c:\temp\file2.txt";

            try
            {
                FileInfo fileInfo = new FileInfo(sourcePath);
                fileInfo.CopyTo(targetPath);
                string[] lines = File.ReadAllLines(sourcePath);
                foreach(string line in lines)
                {
                    Console.WriteLine(line);
                }

            }
            catch(IOException e)
            {
                Console.WriteLine("Erro no arquivo");
                Console.WriteLine(e.Message);
            }
        }
    }
}
