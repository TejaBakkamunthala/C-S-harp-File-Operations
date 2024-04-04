using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public class DirectoryInfoProperties
    {
        public void DirectoryInfoProperties1() {


            string path = @"F:\practice3\MyProp";
            DirectoryInfo di=new DirectoryInfo(path);
            di.Create();
            Console.WriteLine("MyProp Folder Created");

            Console.WriteLine("EXISTS OR NOT "+di.Exists);
            Console.WriteLine("FULL NAME "+di.FullName);
            Console.WriteLine("NAME "+di.Name);
            Console.WriteLine("TO STRING "+di.ToString());
            Console.WriteLine("PARENT "+di.Parent);
            Console.WriteLine("CREATION DATE AND TIME "+di.CreationTime);
            Console.WriteLine("CREATION DATE AND TIME UTC "+di.CreationTimeUtc);
            Console.WriteLine("LAST ACCESS DATE AND TIME "+di.LastAccessTime);
            Console.WriteLine("LAST ACCESS DATE AND TIME UTC "+di.LastAccessTimeUtc);
            Console.WriteLine("LAST WRITE DATE AND TIME "+di.LastWriteTime);
            Console.WriteLine("LAST WRITE DATE AND TIME UTC "+di.LastWriteTimeUtc);
            Console.WriteLine("ROOT "+di.Root);
            Console.WriteLine("ATTRIBUTES "+di.Attributes);
          

        }


    }
}
