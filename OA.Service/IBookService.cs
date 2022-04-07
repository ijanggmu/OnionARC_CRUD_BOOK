using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service
{
    public interface IBookService
    {
        IEnumerable<Book> GetBooks();
        Book GetBook(long id);
        void InsertBook(Book book);
        void UpdateBook(Book book);
        void DeleteBook(long id);

    }
}
