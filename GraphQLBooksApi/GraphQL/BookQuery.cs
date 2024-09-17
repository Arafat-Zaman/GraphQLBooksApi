using GraphQLBooksApi.Models;
using System.Collections.Generic;

namespace GraphQLBooksApi.GraphQL
{
    public class BookQuery
    {
        private static List<Book> books = new List<Book>
        {
            new Book { Id = 1, Title = "C# in Depth", Author = "Jon Skeet" },
            new Book { Id = 2, Title = "The Pragmatic Programmer", Author = "Andy Hunt" }
        };

        public List<Book> GetBooks() => books;

        public Book GetBookById(int id) => books.Find(book => book.Id == id);
    }
}
