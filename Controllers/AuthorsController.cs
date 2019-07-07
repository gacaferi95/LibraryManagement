using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryApp1.Controllers
{
    public class AuthorsController : Controller
    {
        private readonly LibraryApp1Context _context;
        public AuthorsController(LibraryApp1Context context)
        {

            _context = context;
        }

        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _context.Authors;
            return View(model.ToList());
        }
    }
}
