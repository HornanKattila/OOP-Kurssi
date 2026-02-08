
using System.Collections.Generic;
using System.IO;
using System.Text.Json;

namespace KirjastoApp
{
    public class Library
    {
        public List<Book> Books { get; private set; }

        public Library()
        {
            Books = new List<Book>();
        }

        public void AddBook(Book book)
        {
            Books.Add(book);
        }

        public void SaveToFile(string filePath)
        {
            string json = JsonSerializer.Serialize(Books, new JsonSerializerOptions
            {
                WriteIndented = true
            });
            File.WriteAllText(filePath, json);
        }

        public void LoadFromFile(string filePath)
        {
            if (!File.Exists(filePath))
                return;

            string json = File.ReadAllText(filePath);
            Books = JsonSerializer.Deserialize<List<Book>>(json);
        }
    }
}
