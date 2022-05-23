namespace MyLibrary {
    class Program {
        static void Main() {
            Library lib = new Library("Sonderborg bibliotek");
            Console.WriteLine(lib.GetLibrary());
            lib.CreateLoaner(1, "Adrian");
            lib.CreateLoaner(2, "dav");
            lib.CreateLoaner(4, "Nikolaj");
            Console.WriteLine(lib.GetAllLoaner());
        }
    }
}