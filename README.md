## What is this for?

Library database demonstration in C#.

## TODO

* Input error checking
* File saving

## Contributing

* New features are only to be added using new branch called `feature/THIS_IS_A_NEW_FEATURE`
* `feature` brances are only to be merged into `develop`
* `develop` is never to be edited directly, except in case of syntax errors or other similar cases.
* `develop` is only to be merged into `master` when thorough testing has been made and all unit tests pass.

## How to run

### Project
```sh
# Run in src/Library
dotnet run
```

### Unit tests
```sh
# Run in src/
dotnet test
```

## How to use

```sh
--------------------------
Options below:
a: Create Loaner
b: Output Loaners
c: Add Book
d: Remove Book
e: Show Books
x: Finish
--------------------------

a

Enter id: 1
Enter email: nikolaj@gmail.com
Enter name: nikolaj
Added Loaner to database

b

Loaner number: <1> - Email: <nikolaj@gmail.com> - Name: <nikolaj> is loaner at: <Sonderborg bibliotek>
```

## Libraries used

* **System**: Required by C#
* **System.Linq**: Easier string and list manipulation