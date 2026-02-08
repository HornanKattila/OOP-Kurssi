
using System;
using KirjastoApp;

class Program
{
    static void Main()
    {
        Library library = new Library();

        library.AddBook(new Book("1984", "George Orwell", 1949));
        library.AddBook(new Book("Sinuhe egyptiläinen", "Mika Waltari", 1945));

        library.SaveToFile("kirjat.json");

        Library loadedLibrary = new Library();
        loadedLibrary.LoadFromFile("kirjat.json");

        foreach (var book in loadedLibrary.Books)
        {
            Console.WriteLine(book);
        }
    }
}
