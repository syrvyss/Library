using System;
namespace MyLibrary {
    class Program {
        static void Main() {
            Library lib = new Library("Sonderborg bibliotek");
            Console.WriteLine(lib.GetLibrary());
            Console.WriteLine(lib.GetAllLoaner());
            
            while (true) {
                Menu();

                switch (Console.ReadKey().KeyChar) {
                    case 'a':
                        Console.Write("Enter id: ");
                        int id = int.Parse(Console.ReadLine());
                        
                        Console.Write("Enter email: ");
                        string email = Console.ReadLine();

                        Console.Write("Enter name: ");
                        string name = Console.ReadLine();
                        lib.CreateLoaner(id, name, email);
                        break;

                    case 'b':
                        Console.WriteLine(lib.GetAllLoaner());
                        Console.ReadLine();
                        break;

                    case 'x':
                        Console.WriteLine("\nGoodbye {0}!", Environment.MachineName);
                        Console.ReadLine();
                        System.Environment.Exit(1);
                        break;
                    
                    default:
                        Console.WriteLine("Try again, wrong input.");
                        continue;
                        break;
                }
            }
        }
        static void Menu() {
            Console.Clear();
            Console.WriteLine("--------------------------");
            Console.WriteLine("Options below:");
            Console.WriteLine("a: Create Loaner");
            Console.WriteLine("b: Output Loaners");
            Console.WriteLine("x: Finish");
            Console.WriteLine("--------------------------");
        }
    }
}