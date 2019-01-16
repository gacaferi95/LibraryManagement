using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp1.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace LibraryApp1.Controllers
{
    public class UsersController : Controller
    {
        private readonly LibraryApp1Context _context;
        public UsersController(LibraryApp1Context context)
        {
            _context = context;
        }
        // GET: /<controller>/
        public IActionResult Index()
        {
            var model = _context.Users;
            return View(model.ToList());
        }

        public IActionResult Create()
        {
            return View();
        }


        [HttpPost]
        public IActionResult Create(Users modelUser)
        {
            if (ModelState.IsValid)
            {
                _context.Users.Add(modelUser);
                _context.SaveChanges();
                return RedirectToAction(nameof(Index));
            }

            return View(modelUser);
        }


        public IActionResult Edit(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }
            var user = _context.Users.SingleOrDefault(u => u.ID == id);

            if (user == null)
            {
                return NotFound();
            }

            return View(user);
        }


        [HttpPost]
        public IActionResult Edit(int id, Users modelUser)
        {
            if (id != modelUser.ID)
            {
                return NotFound();
            }
            if (ModelState.IsValid)
            {
                try
                {
                    _context.Users.Update(modelUser);
                    _context.SaveChanges();

                }
                catch (Exception ex)
                {
                    if (_context.Users.Any(d => d.ID == id))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }

                return RedirectToAction(nameof(Index));
            }

            return View(modelUser);
        }



        [HttpPost]
        public IActionResult Delete(int? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var user = _context.Users.SingleOrDefault(d => d.ID == id);
            if (user == null)
            {
                return NotFound();
            }

            _context.Users.Remove(user);
            _context.SaveChanges();
            return RedirectToAction(nameof(Index));
        }
    }
}

