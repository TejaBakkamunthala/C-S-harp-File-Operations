using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOOperations
{
    public class StreamWriterAndStreamReader
    {
        public void StreamWriterAndStreamReader1()
        {
            string filePath = @"F:\PracticeStream\europe.txt";
            StreamWriter sw = new StreamWriter(filePath);
           // FileStream fs = new FileStream(filePath,FileMode.Create,FileAccess.Write);
          //  StreamWriter sw=new StreamWriter(fs);
            sw.WriteLine("Hello Europe");
           sw.WriteLine("Namastae Europe");
            sw.WriteLine("Hii Europee");
            sw.WriteLine("Vanakam Europe");
            Console.WriteLine("Data Copied in Europe");
            Console.WriteLine();
            sw.Close();



            StreamReader sr =new StreamReader(filePath);

            //string content= sr.ReadToEnd();
            //Console.WriteLine(content);


            char[] buffer= new char[10];
            int charCount;
            do
            {
                charCount = sr.Read(buffer, 0, 10);
          3      String content1 = new string(buffer);
                Console.WriteLine(content1);

            }
            while (charCount > 0);

            
           // char[] buffer1 = new char[20];

            //int charCount= sr.Read(buffer1, 0, 15);
            // String content2 = new string(buffer1);
            // Console.WriteLine(content2);


            sr.Close();
        }
     
    }
}
