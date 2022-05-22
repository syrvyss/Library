namespace MyLibrary {
    class Program {
        static void Main() {
            Library lib = new Library("Sonderborg bibliotek");
            Console.WriteLine(lib.GetLibrary());
            lib.CreateLoaner(1, "Adrian");
            Console.WriteLine(lib.GetLoaner(1));
        }
    }
}