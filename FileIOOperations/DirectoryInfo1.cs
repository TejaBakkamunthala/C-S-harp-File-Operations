using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public class DirectoryInfo1
    {
        public void DirectoryInfo11(){

            String countriesPath = @"F:\practice3\countries";

            DirectoryInfo di = new DirectoryInfo(countriesPath);
            di.Create();
            Console.WriteLine("Countries Folder Created");

            //String indiapath = @"F:\practice3\countries\INDIA";

            //DirectoryInfo di2= new DirectoryInfo(indiapath);
            //di2.Create();
            //Console.WriteLine("India folder Created");

            //string usaPath = @"F:\practice3\countries\USA";
            //DirectoryInfo di3 = new DirectoryInfo(usaPath);
            //di3.Create();

            //String ukPath = @"F:\practice3\countries\UK";
            //DirectoryInfo di4=new DirectoryInfo(ukPath);
            //di4.Create();

            //Console.WriteLine("USA and UK folder Created ");
            //Console.WriteLine();


            di.CreateSubdirectory("INDIA");
            di.CreateSubdirectory("UK");
            di.CreateSubdirectory("USA");
            Console.WriteLine("CREATE FOLDERS AS INDIA UK USA BY USING SUB DIRECTORY ");



            FileInfo fii = new FileInfo(countriesPath + @"\hii.txt");
            fii.Create();
            Console.WriteLine("hii ceated");

            new FileInfo(countriesPath+@"\hii2.txt").Create();
            Console.WriteLine("hii2 file is created ");


            String populationPath = @"F:\practice3\countries\population.txt";
            FileInfo fi1 = new FileInfo(populationPath);
            fi1.Create();

            

            String sportspath = @"F:\practice3\countries\sports.txt";
            FileInfo fi2=new FileInfo(sportspath);
            fi2.Create();

            string capitalssPath = @"F:\practice3\countries\capitalss.txt";
            FileInfo fi3=new FileInfo(capitalssPath);
            fi3.Create();
            Console.WriteLine("POPULATION ,SPORTS AND CAPITALS FILES ARE CREATED");

            Console.WriteLine("GET ALL FOLDERSS");

            DirectoryInfo dif = new DirectoryInfo(countriesPath);
            DirectoryInfo[] str=dif.GetDirectories();
            foreach(DirectoryInfo str2 in str)
            {
                Console.WriteLine(str2.Name+"  "+str2.Extension);
            }


            Console.WriteLine("GET ALL FILES");

            DirectoryInfo diff=new DirectoryInfo(countriesPath);
                 FileInfo[] str1= dif.GetFiles();
            foreach(FileInfo str2 in str1)
            {
                Console.WriteLine(str2.Name  +" "+str2.Extension);

            }


            //DirectoryInfo d1=new DirectoryInfo(countriesPath);
            //string desPath = @"F:\practice3\world";
            //di.MoveTo(desPath);
            //Console.WriteLine("countries folder moved to world folder");


            //DirectoryInfo d2 = new DirectoryInfo(countriesPath);
            //d2.Delete(true);
            //Console.WriteLine("Countries folder deleted");


            //DIRECTORY INFO PROPERTIES 




        }
    }
}
