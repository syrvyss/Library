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
                        Console.WriteLine(lib.CreateLoaner(id, name, email));
                        Console.ReadLine();
                        break;

                    case 'b':
                        Console.WriteLine(lib.GetAllLoaner());
                        Console.ReadLine();
                        break;

                    case 'c':
                        Console.WriteLine("Enter title: ");
                        string title = Console.ReadLine();

                        Console.WriteLine("Enter Author: ");
                        string author = Console.ReadLine();

                        Console.WriteLine("Enter User index: ");
                        int user = int.Parse(Console.ReadLine());

                        Console.WriteLine(lib.LoanBook(new Book(title, author), user));
                        Console.ReadLine();
                        break;

                    case 'd':
                        Console.Write("Enter User index: ");
                        int userIndex = int.Parse(Console.ReadLine());

                        Console.Write("Enter title: ");
                        string bookTitle = Console.ReadLine();

                        Console.WriteLine(lib.RemoveBook(userIndex, bookTitle));
                        Console.ReadLine();
                        break;

                    case 'e':
                        Console.Write("Enter User index: ");
                        int index = int.Parse(Console.ReadLine());

                        Console.WriteLine(lib.ShowBooks(index));
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
            Console.WriteLine("c: Add Book");
            Console.WriteLine("d: Remove Book");
            Console.WriteLine("e: Show Books");
            Console.WriteLine("x: Finish");
            Console.WriteLine("--------------------------");
        }
    }
}