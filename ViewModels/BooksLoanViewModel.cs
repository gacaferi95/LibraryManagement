using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using LibraryApp1.Models;

namespace LibraryApp1.ViewModels
{
    public class BooksLoanViewModel
    {
     
        public Books Books { get; set; }

        
        public Users Users { get; set; }

        public BooksLoan BooksLoan{get;set;}
    }
}
