using System;

class Library {
    string _libraryName;
    public Library(string name) {
        this._libraryName = name;
    }
    public string GetLibrary() {
        return string.Format("Welcome to {0} - the date today is {1}",
            this._libraryName, DateTime.Today.ToString());
    }
    public Loaner CreateLoaner(int number, string name) {
        Loaner loaner = new Loaner(number, name);
        return loaner;
    }
    public string GetLoaner(Loaner loaner) {
        return String.Format("Loaner number: <{0}> - Name: <{1}> is loaner at: <{2}>", 
        loaner._loanerNumber, loaner._loanerName, this._libraryName);
    }
}