using Xunit;
using MyLibrary;
using System;

public class UnitTest1 {
    [Fact]
    public void Library_GetLibrary_True() {
        Library lib = new Library("Sonderborg bibliotek");

        string str = string.Format("Welcome to {0} - the date today is {1}",
            "Sonderborg bibliotek", DateTime.Today.ToString());
        Assert.Equal(lib.GetLibrary(), str);
    }

    [Fact]
    public void Library_GetLoaner_True() {
        Library lib = new Library("Sonderborg bibliotek");
        lib.CreateLoaner(1, "Adrian", "adrian@gmail.com");
        string str = string.Format("Loaner number: <{0}> - Email: <{1}> - Name: <{2}> is loaner at: <{3}>",
            1, "adrian@gmail.com", "Adrian", "Sonderborg bibliotek");
        Assert.Equal(lib.GetLoaner(1), str);
    }

    [Fact]
    public void Library_GetLoaner_False() {
        Library lib = new Library("Sonderborg bibliotek");
        lib.CreateLoaner(1, "Adrian", "adrian@gmail.com");
        Assert.Equal(lib.GetLoaner(0), "Sorry, duplicate loaner or loaner not found");
    }
}