using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Collections.Generic;

namespace phonbook2
{
    class Program
    {
        static void Rremovenumbers(ref string[] arrey, int  value)
        {
           string []newarrey = new string[arrey.Length-1];
            for (int i = 0, j = 0; i < arrey.Length;i++)
            {
                if (value!=i )
                {
                    newarrey[j++] = arrey[value];
                }
            }
            arrey = newarrey;
        }
        static void Main()
        {
            string[] phonbook = new string[1];
            
            Console.WriteLine("PLEASE ENTER NUMBER 1 To Reak THELIST PHONEBOOK!! ");
            Console.WriteLine("--------------------------------------------------------------------");
            Console.WriteLine("PLEASE ENTER NUMBER 0 TO EDIT OR REMOVE OR ADD THELIST PHONEBOOK!! ");
            while (true)
            {

            List<string> Name = new List<string>();
            List<string> Family = new List<string>();
            List<string> Phone = new List<string>();

            
            var onezero = Console.ReadKey().Key;
                if (onezero == ConsoleKey.NumPad1)
                {
                    Console.Clear();
                    Console.WriteLine("phonbook");
                    using (StreamReader not = new StreamReader(@"phonbook.txt"))
                    {
                        while (not.Peek() != -1)
                        {
                            Console.WriteLine(not.ReadLine());
                          
                        }
                    }
                    Console.WriteLine("--------------------------------------------------------------------");
                    Console.WriteLine("PLEASE ENTER NUMBER 0 TO EDIT OR REMOVE OR ADD THELIST PHONEBOOK!! ");

                }
                else if (onezero == ConsoleKey.NumPad0)
                {
                    Console.Clear();
                    Console.WriteLine("1-Add\n\n2-Remove\n\n3-Edit\n\n4-Exit");
                    var number = Console.ReadKey().Key;
                    switch (number)
                    {
                        case ConsoleKey.NumPad1://add
                            {
                                Console.Clear();
                                Console.WriteLine("please add name,famile,phonnumber ");
                                using (StreamWriter Writer = new StreamWriter(@"phonbook.txt", true))
                                {
                                    int check = 0;
                                    while (check == 0)
                                    {
                                        var input = Console.ReadLine();
                                        Writer.WriteLine(input);
                                        Writer.Flush(); check = 1;
                                    }
                                    int chech2 = 0;
                                    while (chech2 == 0)
                                    {
                                        Console.WriteLine("DO WANT TO ADD OTHER NUMBER Y OR N");
                                        var yn = Console.ReadKey().Key;
                                        if (yn == ConsoleKey.Y)
                                        {
                                            Console.Clear();
                                            Console.WriteLine("please add name,famile,phon number ");
                                            var input2 = Console.ReadLine();
                                            Writer.WriteLine(input2);
                                            Writer.Flush(); continue;
                                        }
                                        else if (yn == ConsoleKey.N)
                                            chech2 = 1;
                                    }
                                }
                                continue;
                            }


                        case ConsoleKey.NumPad2://remove
                            {
                                Console.Clear();
                                using (StreamReader noty = new StreamReader(@"phonbook.txt"))
                                {   
                                    string[] numbers =   noty.ReadLine().Split('/')  ;
                                    List<string> list = numbers.ToList();
                                    foreach (var item in list)
                                    {   int j = 0; 
                                        while (noty.Peek() != -1)
                                        {
                                            
                                            Console.WriteLine($"{j+1}--{noty.ReadLine()}");
                                        }
                                    }
                                
                                    Console.WriteLine("-------------------------------------------");
                                   Console.WriteLine("PLEASE ENTER NUMBER TO REMVOE !");
                                    int key = int.Parse(Console.ReadLine());
                                    list.RemoveAt(key);
                                     
                                }
                            }     
                            
                            continue;

                        case ConsoleKey.NumPad3://etit
                            {
                                Console.Clear();
                                Console.WriteLine("eeeeeeeeeeeeeeeeeeeee");
                                Console.WriteLine("1-Add\n\n2-Remove\n\n3-Edit\n\n4-Exit");
                                break;
                            }
                        case ConsoleKey.NumPad4:
                            {
                                int k = 2;
                                Console.Clear();
                                Console.WriteLine("thanks for your choice!! "); Environment.Exit(k);
                                break;
                            }
                    }
                    
                }
           
            }
        }
    }
}
