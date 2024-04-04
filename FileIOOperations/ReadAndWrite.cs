using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOOperations
{
    public class ReadAndWrite
    {

        public void ReadAndWrite1()
        {
            string filePath = @"F:\FilePractice\File1.txt";
            string content = "Currently I am learning File IO Operations Concept";
            //Write All Text
           File.WriteAllText(filePath, content);
            Console.WriteLine("write content in File1");

            //Read All Text
            string con=File.ReadAllText(filePath);
            Console.WriteLine(con);

            for(int i=0; i < con.Length; i++)
            {
                Console.Write(con[i]+" ");
            }
            Console.WriteLine();
            Console.WriteLine("read file");


        }
    }
}
