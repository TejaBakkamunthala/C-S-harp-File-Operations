using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FileIOOperations
{
    internal class DriveiNFO1
    {

        public void Driveinfo11()
        {

            DriveInfo di=new DriveInfo("F:");
            Console.WriteLine("NAME "+di.Name);
            Console.WriteLine("VOLUME LABEL"+di.VolumeLabel);
            Console.WriteLine("TOTAL SIzE "+di.TotalSize/1024/1024/1024);
            Console.WriteLine("TOTAL FREE SPACE "+di.TotalFreeSpace/1024/1024/1024);
            Console.WriteLine("DRIVE TYPE "+di.DriveType);
            Console.WriteLine("ROOT "+di.RootDirectory);
        }
    }
}
