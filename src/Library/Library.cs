using System;

class Library {
    string _libraryName;
    List<Loaner> _loanerList = new List<Loaner>();
    public Library(string name) {
        this._libraryName = name;
    }
    public string GetLibrary() {
        return string.Format("Welcome to {0} - the date today is {1}",
            this._libraryName, DateTime.Today.ToString());
    }
    public void CreateLoaner(int number, string name) {
        this._loanerList.Append(new Loaner(number, name));
    }
    public string GetLoaner(int number) {
        Loaner loaner = this._loanerList[number-1];
        return String.Format("Loaner number: <{0}> - Name: <{1}> is loaner at: <{2}>", 
            loaner._loanerNumber, loaner._loanerName, this._libraryName);
    }
}