namespace Library {
    class Program {
        static void Main() {
            Library lib = new Library("Sonderborg bibliotek");
            Console.WriteLine(lib.GetLibrary());
        }
    }
}