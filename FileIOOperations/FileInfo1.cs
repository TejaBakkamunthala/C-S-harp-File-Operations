using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Security.AccessControl;

namespace FileIOOperations
{
    public class FileInfo1
    {
        public void FileInfo11() {

            string filePath1 = @"F:\FilePractice\japan1.txt";
            String desPath1 = @"F:\FilePractice\japan2.txt";
            String movpath1= @"F:\FilePractice\japan3.txt";

            FileInfo fileInfo = new FileInfo(filePath1);

             fileInfo.Create().Close();
            //  fileInfo.CreateText("Hii This is Teja");

            //fileInfo.OpenWrite("Hii This is Teja");
           
            if (fileInfo.Exists)
            {
                Console.WriteLine("File Exists");
            }
            else
            {
                Console.WriteLine("Not Exists");
            }

            fileInfo.CopyTo(desPath1);
            Console.WriteLine(fileInfo.Name+"  Created");

           


           //fileInfo.MoveTo(movpath1);
           //Console.WriteLine(fileInfo.Name+"   moved");


            fileInfo.Delete();
            Console.WriteLine(fileInfo.Name+" Deleted ");

        }
    }
}
