using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Diagnostics;

namespace cons
{
    class Program
    {
        

        static void Main(string[] args)
        {
            
                
            while (true)
            {
                Console.Clear();
                var h = 0;
                while (h == 0)
                {


                    DriveInfo[] drives = DriveInfo.GetDrives();
                    for (int i = 0; i < drives.Length; i++)
                    {
                        if (drives[i].IsReady)
                            Console.WriteLine($"{i + 1}.{drives[i].Name}");



                        else
                            Console.WriteLine($"{i + 1}.{drives[i].Name}");
                    }
                    Console.WriteLine("Select Drive Item Number");


                    h = 1;
                }

                ConsoleKey Kay = Console.ReadKey().Key;

                Console.Clear();
                

                if (Kay == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    DirectoryInfo D1 = new DirectoryInfo(@"C:\");
                    DirectoryInfo[] subDirectories = D1.GetDirectories();
                    for (int i = 0; i < subDirectories.Length; i++)
                    {

                        foreach (var directory in subDirectories)
                        {
                            Console.WriteLine($"{ ++i}.{directory.Name}");

                        }

                        FileInfo[] f1 = D1.GetFiles();
                        foreach (var item in f1)
                        {
                            Console.WriteLine($"{i++}.{item.Name}.[FileName]");
                        }

                        Console.WriteLine("select numberkdfnskfndsklvnkdsfnvokdfnvndfvdkflnv kldnv kdf");
                        var pethnumber = Convert.ToInt32(Console.ReadKey().Key);

                        //new DirectoryInfo(FullName(D1));Path.GetFullPath(D2.FullName);

                        string[] arrey = {D1.FullName};
                        if (pethnumber > 0 && pethnumber < arrey.Length)
                        {
                            for (int k = 1; k < arrey.Length; k++)
                            {
                               // arrey[k].FullName
                                pethnumber = k;
                                var peth = arrey[pethnumber];
                                DirectoryInfo D11 = new DirectoryInfo(peth);
                                DirectoryInfo[] subsubDirectories = D11.GetDirectories();
                                foreach (var item in subsubDirectories)
                                {
                                    Console.WriteLine($"{item.Name}{item.FullName}");
                                }
                                FileInfo[] f11 = D11.GetFiles();
                                foreach (var item in f11)
                                {
                                    Console.WriteLine($"{i++}.{item.Name}.[FileName]");
                                }
                            }
                        }

                    }


                   
                }
                if (Kay == ConsoleKey.NumPad2)
                {
                    Console.Clear();
                    DirectoryInfo D2 = new DirectoryInfo(@"D:\");
                    DirectoryInfo[] subDirectories = D2.GetDirectories();
                    for (int i = 0; i < subDirectories.Length; i++)
                    {
                        FileInfo[] f2 = D2.GetFiles();
                        foreach (var directory in subDirectories)
                        {
                            Console.WriteLine($"{ ++i}.{directory.Name}");
                        }

                        foreach (var item in f2)
                        {
                            Console.WriteLine($"{i++}.{item.Name}.[FileName]");
                        }
                    }
                    
                }
                if (Kay == ConsoleKey.NumPad3)
                {
                    Console.Clear();
                    DirectoryInfo D3 = new DirectoryInfo(@"E:\");
                    DirectoryInfo[] subDirectories = D3.GetDirectories();
                    for (int i = 0; i < subDirectories.Length; i++)
                    {
                        FileInfo[] f3 = D3.GetFiles();
                        foreach (var directory in subDirectories)
                        {
                            Console.WriteLine($"{ ++i}.{directory.Name}");
                        }


                        foreach (var item in f3)
                        {
                            Console.WriteLine($"{i++}.{item.Name}.[FileName]");
                        }
                    }


                }
                if (Kay == ConsoleKey.NumPad4)
                {
                    Console.Clear();
                    DirectoryInfo D4 = new DirectoryInfo(@"F:\");
                    DirectoryInfo[] subDirectories = D4.GetDirectories();
                    for (int i = 0; i < subDirectories.Length; i++)
                    {
                        FileInfo[] f4 = D4.GetFiles();
                        foreach (var directory in subDirectories)
                        {
                            Console.WriteLine($"{ ++i}.{directory.Name}");
                        }


                        foreach (var item in f4)
                        {
                            Console.WriteLine($"{i++}.{item.Name}.[FileName]");
                        }
                    }


                }

                //DriveInfo[] drives2 = DriveInfo.GetDrives();
                //for (int j = 0; j < drives2.Length; j++)
                //{
                //    if (drives2[j].IsReady)
                //        Console.WriteLine($"{j + 1}.{drives2[j].Name}.");
                //    //  string m = drives2[j].RootDirectory.ToString();
                //    else
                //        Console.WriteLine($"{j + 1}.{drives2[j].Name}.{drives2[j].RootDirectory}");

                //    Console.WriteLine("Select Drive Item Number");

                //    Console.WriteLine("-------------------------------");
                //    DirectoryInfo di = new DirectoryInfo(m);
                //    DirectoryInfo[] subDirectories = di.GetDirectories();
                //    for (int i = 0; i < subDirectories.Length; i++)
                //    {
                //        foreach (var directory in subDirectories)
                //        {
                //            Console.WriteLine($"{ ++i}.{directory.Name}\t{directory.FullName}");
                //        }
                //    }
                //}
                //
                //else
                //{
                //    Console.WriteLine("Select Drive Item Number");
                //} 




                //DirectoryInfo d = new DirectoryInfo(@"E:\githup\Pack-9705");
                //Console.WriteLine(d.Parent);

                //////DirectoryInfo dj = new DirectoryInfo(@"D:\");
                //////Console.WriteLine(di.Parent);

                //// Process.Start(@"D:\EBooks\IllustratedCSharp7,5thEdition@farhangv_com.pdf");

                Console.ReadKey();

            }
        }

        private static string FullName(DirectoryInfo ho)
        {
            return ho.FullName;
        }

       
    }
}
