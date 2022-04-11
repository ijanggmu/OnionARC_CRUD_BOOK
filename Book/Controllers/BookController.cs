using Microsoft.AspNetCore.Mvc;
using OA.Data;
using OA.Service;
using OA.Web.Models;
using System;
using System.Collections.Generic;
using System.Linq;

namespace OA.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookServices;
        public BookController(IBookService bookService)
        {
            _bookServices = bookService;
        }
        [HttpGet]
        
        public IActionResult Index()
        {
            List<BookViewModel> model = new List<BookViewModel>();
            _bookServices.GetBooks().ToList().ForEach(u => {
                BookViewModel book = new BookViewModel()
                {
                    Id = u.Id,
                    Name = u.Name,
                    Author = u.Author,
                    ISBN = u.ISBN
                };
                model.Add(book);
            });
            return View(model);
        }
        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(BookViewModel m)
        {
            
            
                BookList b = new BookList()
                {
                    Name=m.Name,
                    Author=m.Author,
                    ISBN=m.ISBN,
                    AddedDate=DateTime.UtcNow,
                    ModifiedDate=DateTime.UtcNow
                    
                };
                _bookServices.InsertBook(b);
            

            return RedirectToAction("Index");
        }
        public IActionResult Delete(int id)
        {
            _bookServices.DeleteBook(id);
            return RedirectToAction("Index");
        }
        public IActionResult Edit(int id)
        {
            //var a = _bookServices.GetBook(id);
            BookViewModel book = new BookViewModel();
            BookList obj = _bookServices.GetBook(id);

            book.Name = obj.Name;
            book.Author = obj.Author;
            book.ISBN = obj.ISBN;
              
           
            return View(book);
        }

        [HttpPost]
        public IActionResult Edit(BookViewModel m)
        {
            BookList b = _bookServices.GetBook(m.Id);

            b.Name = m.Name;
            b.Author = m.Author;
            b.ISBN = m.ISBN;
            _bookServices.UpdateBook(b);
            return RedirectToAction("Index");
        }


    }
}
