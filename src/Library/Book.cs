using System;

public class Book {
    public string title { get; init; }
    public string author { get; init; }
    public DateTime checkoutDate { get; init; }
    public Book(string title, string author) {
        this.title = title;
        this.author = author;
        this.checkoutDate = DateTime.Today;
    }
}