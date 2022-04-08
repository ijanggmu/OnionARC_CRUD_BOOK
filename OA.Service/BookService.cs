using OA.Data;
using OA.Repo;
using System;
using System.Collections.Generic;

namespace OA.Service
{
    public class BookService:IBookService
    {
        private IRepository<BookList> _bookRepository;
        public BookService(IRepository<BookList> bookRepository)
        {
            _bookRepository = bookRepository;
        }
        public IEnumerable<BookList> GetBooks()
        {
            return _bookRepository.GetAll();
        }
        public BookList GetBook(int id)
        {
            return _bookRepository.Get(id);
        }
        public void InsertBook(BookList book)
        {
            _bookRepository.Insert(book);
        }
        public void UpdateBook(BookList book)
        {
            _bookRepository.Update(book);
            _bookRepository.SaveChanges();
        }
        public void DeleteBook(int id)
        {
            BookList book = GetBook(id);
            _bookRepository.Remove(book);
            _bookRepository.SaveChanges();
        }
    }
}
