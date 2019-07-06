using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net.Http.Headers;
using System.Threading.Tasks;
using LibraryApp1.Models;
using LibraryApp1.ViewModels;
using Microsoft.AspNetCore.Hosting;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryApp1.Controllers
{
    public class BooksController : Controller
    {

        private readonly IHostingEnvironment _environment;       
        private readonly LibraryApp1Context _context;

        public BooksController(LibraryApp1Context context, IHostingEnvironment environment)
        {
            _context = context;
            _environment = environment;



        }


        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _context.Books.Include(a=>a.Authors).Include(c => c.Categories);
            return View(model.ToList());
        }

        
        public IActionResult AddBook()
        {
            List<Categories> _categories = new List<Categories>();

            _categories = (from category in _context.Categories
                          select category).ToList();

            _categories.Insert(0, new Categories { Id = 0, categoryName = "Select" });
            ViewBag.ListOfCategories = _categories;
            return View();
        }

        [HttpPost]
        public IActionResult AddBook(BooksViewModel model, IFormFile files)
        {

            model.Books.Authors = model.Authors;
            model.Books.CategoriesId = model.Categories.Id;


            UploadFile(files);
            model.Books.image = "/images/Books/"+files.FileName;

            _context.Books.Add(model.Books);
             _context.SaveChanges();



            return RedirectToAction(nameof(Index));
        }



        [HttpPost]
        public JsonResult UploadFile(IFormFile files) //List<IFormFile>
        {
            
            // full path to file in temp location
            //var filePath = Path.GetTempFileName();          


            //foreach (var formFile in files)
            //{
                var path = Path.Combine(
                  Directory.GetCurrentDirectory(), "wwwroot/images/Books/",
                  files.FileName);

                if (files.Length > 0)
                {
                    using (var stream = new FileStream(path, FileMode.Create))
                    {
                        files.CopyTo(stream);
                    }
                }
            //}

            // process uploaded files
            // Don't rely on or trust the FileName property without validation.

            //return Ok(new { count = files.Count, size, filePath });
            return Json(true);
        }     
    }
}
