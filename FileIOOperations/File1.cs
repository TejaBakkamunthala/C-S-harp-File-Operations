using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace FileIOOperations
{
    internal class File1
    {

        public void File11()
        {
            File.Create(@"F:\FilePractice\File1.txt").Close();

            string path1 = @"F:\FilePractice\File1.txt";
            string path2 = @"F:\FilePractice\File2.txt";
            string path3 = @"F:\FilePractice\File3.txt";
            Console.WriteLine("File Cretated In above Path");
            Console.WriteLine();
            Console.WriteLine(File.Exists(path1));
            if (File.Exists(path1))
            {
                //File.Copy(path1, path2);
                // Console.WriteLine("File Copied from path1 to path2");
                // File.Move(path1, path3);
                 //Console.WriteLine("File moved from path1 to path 3");
                Console.WriteLine("Exists");
            }
            if (File.Exists(path3))
            {
                File.Delete(path3);
                Console.WriteLine("File3 Deleted");
            }
            else
            {
                Console.WriteLine("Path Not Exists");
            }
            }

        }
    }

