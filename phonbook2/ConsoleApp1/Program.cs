using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        { FileStream file = new FileStream(@"phonbook.txt", FileMode.Open,FileAccess.Read);
            StreamReader f = new StreamReader(file);
                }
       
    }
}
