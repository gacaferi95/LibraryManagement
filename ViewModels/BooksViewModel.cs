using LibraryApp1.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp1.ViewModels
{
    public class BooksViewModel
    {
        [Required]
        public Books Books { get; set; }

        [Required]
        public Authors Authors { get; set; }

        [Required]
        public Categories Categories { get; set; }
    }
}
