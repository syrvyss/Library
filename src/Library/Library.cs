using System;
using System.Linq;

public class Library {
    string _libraryName;
    List<Loaner> _loanerList = new List<Loaner>();
    public Library(string name) {
        this._libraryName = name;
    }
    public string GetLibrary() {
        return string.Format("Welcome to {0} - the date today is {1}",
            this._libraryName, DateTime.Today.ToString());
    }
    public string CreateLoaner(int number, string name, string email) {
        List<Loaner> loaner = this._loanerList
            .Where(x => x.number == number || x.name == name || x.email == email)
            .ToList();
        if (loaner.Count >= 1)
            return "Sorry, duplicate loaner or loaner not found";

        this._loanerList.Add(new Loaner(number, name, email));
        return "Added Loaner to database";
    }
    public string GetLoaner(int number) { // also works as FindLoaner method in "options"
        List<Loaner> loaner = this._loanerList.Where(x => x.number == number).ToList();
        if (loaner.Count != 1)
            return "Sorry, duplicate loaner or loaner not found";

        return String.Format("Loaner number: <{0}> - Email: <{1}> - Name: <{2}> is loaner at: <{3}>", 
            loaner.First().number, loaner.First().email, loaner.First().name, this._libraryName);
    }
    public string GetAllLoaner() {
        string str = "";
        foreach (var item in _loanerList)
        {
            str += String.Format("Loaner number: <{0}> - Email: <{1}> - Name: <{2}> is loaner at: <{3}>\n",
                item.number, item.email, item.name, this._libraryName);
        }
        return str;
    }
    public string LoanBook(Book book, int loanerNum) {
        List<Loaner> loaner = this._loanerList.Where(x => x.number == loanerNum).ToList();
        if (loaner.Count != 1)
            return "Sorry, duplicate loaner or loaner not found";

        List<Loaner> bookCheck = loaner.Where(x => x.books.Contains(book)).ToList();
        
        if (bookCheck.Count >= 1) {
            return "Sorry, cannot loan same book twice.";
        }

        for (int i = 0; i < loaner.Count; i++) {
            loaner[i].books.Add(book);
        }
        return "Added book!";
    }
    public string RemoveBook(int loanerNum, string title) {
        List<Loaner> loaner = this._loanerList
            .Where(x => x.number == loanerNum).ToList();
        if (loaner.Count != 1)
            return "Sorry, duplicate loaner or loaner not found";

        int bookNum = loaner.First().books
            .Select(x => x.title == title)
            .ToList().Count;

        if (bookNum < 1)
            return "Sorry, could not find book";

        loaner.First().books.RemoveAll(x => x.title == title);
        return "Removed book!";
    }
    public string ShowBooks(int loanerNum) {
        string str = "";
        List<Book> books = this._loanerList
            .Where(x => x.number == loanerNum)
            .Select(x => x.books)
            .ToList().FirstOrDefault();

        if (books.Count == 0)
            return "Sorry, no books detected.";

        foreach (var item in books) {
            str += String.Format("Title: {0} - Author: {1}", item.title, item.author);
        }

        return str;
    }
}