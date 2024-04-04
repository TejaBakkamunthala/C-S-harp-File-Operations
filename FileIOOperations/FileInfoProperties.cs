using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOOperations
{
    public class FileInfoProperties
    {

        public void FileInfoProperties1() {


            String path = @"F:\FilePractice\book.txt";
            String path1 = @"F:\FilePractice\book1.txt";
            FileInfo fi = new FileInfo(path);
          //  fi.Create();
            if (fi.Exists)
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("File Not Exists");
            }

            long len = fi.Length;
            Console.WriteLine("Length "+len);
            Console.WriteLine("Length "+fi.Length);
            Console.WriteLine("Full Name "+fi.FullName);
            Console.WriteLine("Name "+fi.Name);
            Console.WriteLine("Exists "+fi.Exists);
            Console.WriteLine("To String "+fi.ToString());
            Console.WriteLine("Creation Time "+ fi.CreationTime);
            Console.WriteLine("Directory "+fi.Directory);
            Console.WriteLine("Directory Name "+fi.DirectoryName);
            // Console.WriteLine(fi.AppendText("hii"));
            // Console.WriteLine(fi.CopyTo(path1));
            Console.WriteLine("Last Access Time "+fi.LastAccessTime);
            Console.WriteLine("Last Write Time "+fi.LastWriteTime);
            Console.WriteLine("Extension "+fi.Extension);
            //Console.WriteLine(fi.Delete(path1));
            



        }
    }
}
