using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            //// Change the directory to %WINDIR%
            //Environment.CurrentDirectory = 
            //DirectoryInfo info = new DirectoryInfo(".");
            //Console.WriteLine("Directory Info:   " + info.FullName);
            Console.WriteLine("Hello:   " + Environment.GetEnvironmentVariable("Name"));

        }
    }
}
