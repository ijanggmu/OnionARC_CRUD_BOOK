using Microsoft.AspNetCore.Mvc;
using OA.Service;

namespace OA.Web.Controllers
{
    public class BookController : Controller
    {
        private readonly IBookService _bookServices;
        public BookController(IBookService bookService)
        {
            _bookServices = bookService;
        }
        public IActionResult Index()
        {
            return View();
        }
    }
}
