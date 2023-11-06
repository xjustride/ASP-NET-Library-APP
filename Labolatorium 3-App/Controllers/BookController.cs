using Labolatorium_3_App.Models;
using Microsoft.AspNetCore.Mvc;

namespace Labolatorium_3_App.Controllers
{
    public class BookController : Controller
    {
        //static readonly Dictionary<int, Contact> _contacts = new Dictionary<int, Contact>();
        private readonly IBookService _bookService;

        public BookController(IBookService bookService)
        {
            _bookService = bookService;
        }

        public IActionResult Index()
        {
            List<Book> books = _bookService.FindAll();
            return View(books);
        }

        [HttpGet]
        public IActionResult Create()
        {
            return View();
        }

        [HttpPost]
        public IActionResult Create(Book model)
        {
            if (ModelState.IsValid)
            {
                _bookService.Add(model);
                return RedirectToAction("Index");
            }
            else
            {
                return View(model);
            }
        }

        [HttpGet]
        public IActionResult Update(int id)
        {
            Book book = _bookService.FindById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Update(Book model)
        {
            if (ModelState.IsValid)
            {
                _bookService.Update(model);
                return RedirectToAction("Index");
            }
            return View();
        }
        [HttpGet]
        public IActionResult Delete(int id)
        {
            Book book = _bookService.FindById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }
        [HttpPost]
        public IActionResult Delete(Book model)
        {
            _bookService.Delete(model.id);
            return RedirectToAction("Index");
        }
        [HttpGet]
        public IActionResult Details(int id)
        {
            Book book = _bookService.FindById(id);
            if (book == null)
            {
                return NotFound();
            }
            return View(book);
        }

    }

}
