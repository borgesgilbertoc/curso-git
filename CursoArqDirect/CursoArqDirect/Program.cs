using System;
using System.IO;
using System.Collections.Generic;

namespace CursoArqDirect
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = @"c:\temp\pastacurso";

            try
            {
                IEnumerable<string> folders = Directory.EnumerateDirectories(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Pastas:");
                foreach (string s in folders)
                {
                    Console.WriteLine(s);
                }

                var files = Directory.EnumerateFiles(path, "*.*", SearchOption.AllDirectories);
                Console.WriteLine("Arquivos:");
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                }


                Directory.CreateDirectory(path + @"\newfolder");

                path = @"c:\temp\pastacurso\file1.txt";
                Console.WriteLine();
                Console.WriteLine("DirectorySeparatorChar: " + Path.DirectorySeparatorChar);
                Console.WriteLine("PathSeparator: " + Path.PathSeparator);
                Console.WriteLine("GetDirectoryName: " + Path.GetDirectoryName(path));
                Console.WriteLine("GetFileName: " + Path.GetFileName(path));
                Console.WriteLine("GetFileNameWithoutExtension: " + Path.GetFileNameWithoutExtension(path));
                Console.WriteLine("GetExtension: " + Path.GetExtension(path));
                Console.WriteLine("GetFullPath: " + Path.GetFullPath(path));
                Console.WriteLine("GetTempPath: " + Path.GetTempPath());
            }
            catch (IOException e)
            {
                Console.WriteLine("Erro no arquivo");
                Console.WriteLine(e.Message);
            }
        }
    }
}
