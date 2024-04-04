using CsvHelper.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOOperations
{

   /* class person
    {
        public string Name { get; set; }
        public int Age { get; set; }
        public string Country { get; set; }
    }
    

    public class Program1
    {


        static void WriteToCsv(string filepath)
        {
            try
            {
                if (!File.Exists(filepath))
                {
                    using (File.Create(filepath)) ;

                }

                List<person> people = new List<person>()
                {
                    new person{Name="Teja" ,Age=23,Country="India"},
                    new person{Name="Tharun",Age=24,Country="USA"}
                };

                var configPersons = new CsvConfiguration(cultureInfo.InvariantCulture)
                {
                    HasHeaderRecord = true,
                };
                StreamWriter sw = new StreamWriter(filepath));
            

        }

    }*/

}