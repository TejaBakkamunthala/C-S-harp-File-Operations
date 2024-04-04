using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOOperations
{
    internal class Directory1
    {

        public void Directory11()
        {
            string coiuntriesFolderPath = @"F:\practice2\countries";
            Directory.CreateDirectory(coiuntriesFolderPath);
            Console.WriteLine("Countries Folder Created");
            //CREATE FOLDERS
            string indiaFolderPath = @"F:\practice2\countries\INDIA";
            Directory.CreateDirectory(indiaFolderPath);
            Console.WriteLine("India Folder Path Created ");

            string ukFolderPath = @"F:\practice2\countries\UK";
            Directory.CreateDirectory(ukFolderPath);
            Console.WriteLine("uk Folder created");

            string usaFolderPath = @"F:\practice2\countries\USA";
            Directory.CreateDirectory(usaFolderPath);
            Console.WriteLine("usaFolderPath Created");

            //CREATE FILES
            string sportsFilePath = @"F:\practice2\countries\sports.txt";
            File.CreateText(sportsFilePath);
            Console.WriteLine("sports text created");

            string captialsFilePath = @"F:\practice2\countries\capitals.txt";
            File.CreateText(captialsFilePath);
            Console.WriteLine("capitals text created");

            string populationFilePath = coiuntriesFolderPath + @"\population.txt";
            File.CreateText(populationFilePath);
            Console.WriteLine("Population Text Created ");


            //string worldFilePath = @"F:\practice2\world";
            //Directory.Move(coiuntriesFolderPath, worldFilePath);
            //Console.WriteLine("countries folder path renamed to world ");

            Console.WriteLine("GET FILES");
            String[] str=Directory.GetFiles(coiuntriesFolderPath);
            foreach (string strItem in str)
            {
                Console.WriteLine(strItem+" ");
            }

            Console.WriteLine("GET FILES");
            string[] str1=Directory.GetDirectories(coiuntriesFolderPath);
            foreach (string strItem in str1)
            {
                Console.WriteLine(strItem+" ");
            }

           //Directory.Delete(coiuntriesFolderPath,true);
           //Console.WriteLine("Countries Folder Deleted ");


        }
    }
}
