using System;

namespace CodeSampleMenu
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int response = 0;
            string name = "";
            string surname = "";
            int age = 0;
            int height = 0;
            while (response != -1)
            {
                Console.WriteLine(@"Enter 0 to enter name
                                    Enter 1 to enter surname
                                    Enter 2 to enter age
                                    Enter 3 to enter weight
                                    Enter -1 to exit
                                    Enter -2 to print your application");
                response = int.Parse(Console.ReadLine());
                switch (response)
                {
                    case 0:
                        {
                            name = Console.ReadLine();
                            break;
                        }
                    case 1:
                        {
                            surname = Console.ReadLine();
                            break;
                        }
                    case 2:
                        {
                            age = int.Parse(Console.ReadLine());
                            break;
                        }
                    case -2:
                        {
                            Console.WriteLine(name);
                            Console.WriteLine(surname);
                            Console.WriteLine(age);
                            Console.WriteLine(height);
                            break;
                        }
                    case 3:
                        {
                            height = int.Parse(Console.ReadLine());
                            break;
                        }
                    case -1:
                        {
                            break;
                        }
                    default:
                        {
                            Console.WriteLine("Not valid command");
                            break;
                        }
                }
            }

            Console.ReadKey();
        }
    }
}
