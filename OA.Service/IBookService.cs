using OA.Data;
using System;
using System.Collections.Generic;
using System.Text;

namespace OA.Service
{
    public interface IBookService
    {
        IEnumerable<BookList> GetBooks();
        BookList GetBook(int id);
        void InsertBook(BookList book);
        void UpdateBook(BookList book);
        void DeleteBook(int id);
    }
}
