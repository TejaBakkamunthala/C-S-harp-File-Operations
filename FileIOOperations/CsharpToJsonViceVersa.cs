using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace FileIOOperations
{
    public class CsharpToJsonViceVersa
    {

        public string Name {  get; set; }
        public int Age { get; set; }

        public CsharpToJsonViceVersa(string name, int age)
        {
            this.Name = name;
            this.Age = age;
        }


    }
}
