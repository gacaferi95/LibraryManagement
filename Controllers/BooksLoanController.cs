using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp1.Models;
using LibraryApp1.ViewModels;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryApp1.Controllers
{
    public class BooksLoanController : Controller
    {
        private readonly LibraryApp1Context _context;
        public BooksLoanController(LibraryApp1Context context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _context.BooksLoan.Include(b => b.Users).Include(a => a.Books).ThenInclude( au => au.Authors);
            return View(model.ToList());
        }

        public IActionResult AddBookLoan()
        {
            //books selected
            List<Books> books =new List<Books>();
            books = (from book in _context.Books
                    select book).Include(a => a.Authors).ToList();
            books.Insert(0, new Books{ ID = 0, bookTitle = "Select" });

            ViewBag.BooksList = books;


            //users selected
            List < Users > users = new List<Users>();
            users = (from user in _context.Users
                     select user).ToList();
            users.Insert(0, new Users { ID = 0, userName = "Select"});
            ViewBag.UsersList = users;


            return View();
        }

        [HttpPost]
        public IActionResult AddBookLoan(BooksLoan model)
        {

            if (ModelState.IsValid)
            {
                model.UsersId = model.UsersId;
                model.BooksId = model.BooksId;

                _context.BooksLoan.Add(model);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }
            return View();           
          
        }
    }
}
