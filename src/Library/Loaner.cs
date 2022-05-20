using System;

class Loaner {
    int _loanerNumber { get; }
    string _loanerName { get; }
    public Loaner(int number, string name) {
        this._loanerNumber = number;
        this._loanerName = name;
    }
}