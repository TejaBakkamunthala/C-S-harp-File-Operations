using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOOperations
{
    internal class ReadAndWriteLines
    {

        public void ReadAndWriteLines1() 
        {


            List<string> countries = new List<string>() { "India", "China", "Ruusia", "Thiland", "SInagapore" };

            //List<string> countries=new List<string>();
            //countries.Add("India");
            //countries.Add("China");
            //countries.Add("Russia");
            //countries.Add("Thailand");
            //countries.Add("Singapore");

          // File.Create(@"F:\FilePractice\asia.txt");

            String filepath = @"F:\FilePractice\asia.txt";


            if (File.Exists(filepath))
            {
                Console.WriteLine("Exists");
            }
            else
            {
                Console.WriteLine("NOT");
            }

            if (File.Exists(filepath))
            {
                File.WriteAllLines(filepath, countries);
                Console.WriteLine("Content created in countries file");
                Console.WriteLine("Read All Lines");
                string[] str = File.ReadAllLines(filepath);
                for (int i = 0; i < str.Length; i++)
                {
                    Console.WriteLine(str[i] + " ");

                }
            }
            else
            {
                Console.WriteLine("Not Exists");
            }


        }
    }
}
