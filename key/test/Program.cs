using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;
namespace test
{
    class Program
    {
       // private static string k;

        static void Main(string[] args)
        {

           // while (true)
            {
                
            
                DirectoryInfo D1 = new DirectoryInfo(@"D:\");
                DirectoryInfo[] subDirectories = D1.GetDirectories();
               for (int i = 0; i < subDirectories.Length;)
               {
                    Console.WriteLine($"{i++}-{subDirectories[i].Name}");
                    FileInfo[] f1 = D1.GetFiles();
                    foreach (var itemf1 in f1)
                    {
                        Console.WriteLine($"{i++}.{itemf1.Name}.[FileName]");
                    }
                     string [] number = { subDirectories[i].FullName };
                    int   h = int .Parse(Console.ReadLine());
                    if (h<subDirectories.Length)
                    {
                        DirectoryInfo d2 = new DirectoryInfo(number[h]);
                        DirectoryInfo[] sub = d2.GetDirectories();
                        for (int j = 0; j < sub.Length; j++)
                        {
                            Console.WriteLine($"{j++}{sub[j].Name}{sub[i].FullName}");
                        }
                    }
                    



                }
                    
            }
        }
    }
}
    