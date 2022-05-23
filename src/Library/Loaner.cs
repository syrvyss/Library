using System;

class Loaner : Person {
    public int number { get; }
    public Loaner(int number, string name, string email) {
        this.number = number;
        this.name = name;
        this.email = email;
    }
}