using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    public class BinaryWriterAndReader1
    {

        public void BinaryWriterAndReader11() { 
        int countryId = 1;
        string coutryName = "AndhraPradesh";
        string region = "South India";
        long populationName = 12345678;


        string filePath = @"F:\practiceBinary\indiaa.txt";

        FileStream fs = new FileStream(filePath, FileMode.Create, FileAccess.Write);

         //   BinaryWriter binaryWriter = new BinaryWriter(filePath);
            BinaryWriter bw=new BinaryWriter(fs);

            bw.Write(countryId);//0001
            bw.Write(coutryName);
            bw.Write(populationName);
            bw.Write(region);

            Console.WriteLine( "Indiaa File Created");
            bw.Close();

            FileStream fs1=new FileStream(filePath,FileMode.Open, FileAccess.Read);

            BinaryReader br=new BinaryReader(fs1);
            
            int countryId1=br.ReadInt32();
            string countryName1 =br.ReadString();
            long population1 = br.ReadInt64();
            string regionName1 =br.ReadString();

            Console.WriteLine("countryId1 "+countryId1);
            Console.WriteLine("CountryName "+countryName1);
            Console.WriteLine("Population " + population1);

            Console.WriteLine("Region name "+regionName1);




            br.Close();


        }


    }
}
