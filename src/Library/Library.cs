using System;

public class Library {
    string _libraryName;
    List<Loaner> loanerList = new List<Loaner>();
    public Library(string name) {
        this._libraryName = name;
    }
    public string GetLibrary() {
        return string.Format("Welcome to {0} - the date today is {1}",
            this._libraryName, DateTime.Today.ToString());
    }
    public string CreateLoaner(int number, string name) {
        this.loanerList.Add(new Loaner(number, name));
        return "Added Loaner to database";
    }
    public string GetLoaner(int number) {
        List<Loaner> loaner = this.loanerList.Where(x => x.number == number).ToList();
        if (loaner.Count > 1 || loaner.Count == 0)
            return "Sorry, duplicate loaner or loaner not found";

        return String.Format("Loaner number: <{0}> - Name: <{1}> is loaner at: <{2}>", 
            loaner.First().number, loaner.First().name, this._libraryName);
    }
    public string GetAllLoaner() {
        string str = "";
        foreach (var item in loanerList)
        {
            str += String.Format("Loaner number: <{0}> - Name: <{1}> is loaner at: <{2}>\n",
                item.number, item.name, this._libraryName);
        }
        return str;
    }
}