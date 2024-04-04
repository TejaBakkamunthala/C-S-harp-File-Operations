using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    internal class FileWriter1
    {

        public void FileWriter11()
        {


            String path = @"F:\Stream1\Dogg.txt";
            Console.WriteLine("HII");

            //FileInfo fi= new FileInfo(path);

            FileStream fs = new FileStream(path,FileMode.Create,FileAccess.Write);
           
            //FileStream fS1 = File.Open(path,FileMode.Create,FileAccess.Write);

            //FileStream fs3=File.Create(path);

            //FileStream fs4=File.OpenWrite(path);


            //FileStream fs5 = fi.Create();

            //FileStream fs6 = fi.OpenWrite();

            //FileStream fs7 = fi.Open(FileMode.Create,FileAccess.Write);


            Console.WriteLine("Dog text is created ");
            //CREATE CONTENT
            String content = "Dog is one of the domestic animal AND Dog is a pet animal";

            String content1 = "My dog name is shannu";

           

            byte[] byteContent=Encoding.ASCII.GetBytes(content);

            byte[] byteContent1 = Encoding.ASCII.GetBytes(content1);


            //WRITE


            fs.Write(byteContent,0,byteContent.Length);
            fs.Write(byteContent1,0, byteContent1.Length);

           
            Console.WriteLine("CONTENT PASTED");

           FileStream fsr = new FileStream(path,FileMode.Open,FileAccess.Read);

            //FileStream fsr2 = File.Open(path, FileMode.Open, FileAccess.Read);

            //FileStream fsr3 = File.OpenRead(path);

            //FileStream fsr4=fi.Open(FileMode.OpenOrCreate,FileAccess.Read);

          //  FileStream fsr5 = fi.OpenRead();


            //create an empty BYTE ARRAY
            byte[] byteReadd = new byte[fsr.Length];

            //READ
            fsr.Read(byteReadd,0,(int)fsr.Length);

            //CONVERT BYTE[] TO STRING 
            String content3 = Encoding.ASCII.GetString(byteReadd);
            Console.WriteLine(content3);
            Console.WriteLine("DATA READ");


            //  foreach(char content4 in content3)
            //{
            //  Console.WriteLine(content4+" ");
            //}

            fs.Close();



        }



    }
}
