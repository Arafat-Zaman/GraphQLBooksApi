using GraphQLBooksApi.Models;
using System.Collections.Generic;

namespace GraphQLBooksApi.GraphQL
{
    public class BookMutation
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "C# in Depth", Author = "Jon Skeet" },
            new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andy Hunt" }
        };

        public Book AddBook(string title, string author)
        {
            var newBook = new Book { Id = books.Count + 1, Title = title, Author = author };
            books.Add(newBook);
            return newBook;
        }
    }
}
