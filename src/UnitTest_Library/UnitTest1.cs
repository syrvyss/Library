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
        lib.CreateLoaner(1, "Adrian");
        string str = string.Format("Loaner number: <{0}> - Name: <{1}> is loaner at: <{2}>", 
            1, "Adrian", "Sonderborg bibliotek");
        Assert.Equal(lib.GetLoaner(1), str);
    }

    [Fact]
    public void Library_GetLoaner_False() {
        Library lib = new Library("Sonderborg bibliotek");
        lib.CreateLoaner(1, "Adrian");
        Assert.Equal(lib.GetLoaner(0), "Sorry, wrong index. numbers <= 0 are invalid, index starts at 1");
    }
}