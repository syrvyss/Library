using System;

class Loaner {
    public int _loanerNumber { get; }
    public string _loanerName { get; }
    public Loaner(int number, string name) {
        this._loanerNumber = number;
        this._loanerName = name;
    }
}