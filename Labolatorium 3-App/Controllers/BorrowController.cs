using Labolatorium_3_App.Models;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Security.Claims;

namespace Labolatorium_3_App.Controllers
{
    [Authorize]
    public class BorrowController : Controller
    {
        private readonly IBorrowService _borrowService;
        private readonly IBookService _bookService;
        private readonly UserManager<IdentityUser> _userManager;

        public BorrowController(IBookService bookService, UserManager<IdentityUser> userManager)
        {
            _bookService = bookService;
            _userManager = userManager;
        }

        public IActionResult Borrow(int bookId)
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            _borrowService.BorrowBook(bookId, userId);
            return RedirectToAction("Index", "Library"); // Przekierowanie do listy bibliotek po wypożyczeniu
        }

        public IActionResult MyBorrows()
        {
            var userId = User.FindFirstValue(ClaimTypes.NameIdentifier);
            var borrows = _borrowService.GetUserBorrows(userId);
            return View(borrows);
        }

        public IActionResult Index()
        {
            // Tutaj można umieścić logikę potrzebną do wygenerowania danych dla widoku,
            // na przykład listę wszystkich wypożyczeń, jeśli użytkownik ma uprawnienia administratora
            // lub przekierować użytkownika do innego widoku, jeśli jest to wymagane.

            // Dla zwykłego użytkownika, możemy przekierować do listy jego wypożyczeń:
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                // Dla niezalogowanych użytkowników, przekieruj do logowania lub innego odpowiedniego widoku.
                return RedirectToAction("Login", "Account");
            }
        }


        //[HttpPost]
        //public IActionResult Create(BorrowViewModel model)
        //{
        //    if (ModelState.IsValid)
        //    {
        //        var userId = _userManager.GetUserId(User); // Pobierz ID zalogowanego użytkownika

        //        // Logika do zapisu wypożyczenia w bazie danych
        //        // _borrowService.Add(new BorrowEntity { UserId = userId, BookId = model.BookId, ... });

        //        return RedirectToAction("Index"); // Przekieruj do strony z listą wypożyczeń
        //    }

        //    // Jeśli model nie jest prawidłowy, zwróć formularz do poprawy
        //    model.Books = _bookService.GetBooks().Select(x => new SelectListItem
        //    {
        //        Value = x.Id.ToString(),
        //        Text = x.Title
        //    });

        //    return View(model);
        //}

        public IActionResult Create()
        {
            var model = new BorrowViewModel
            {
                Books = _bookService.GetBooks().Select(x => new SelectListItem
                {
                    Value = x.id.ToString(),
                    Text = x.Title
                }),
                BorrowDate = DateTime.Now
            };

            return View(model);
        }
    }
}
