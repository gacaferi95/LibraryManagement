using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;

namespace LibraryApp1.Models
{
    public class LibraryApp1Context : DbContext
    {
        public LibraryApp1Context (DbContextOptions<LibraryApp1Context> options)
            : base(options)
        {
        }

        public DbSet<LibraryApp1.Models.Movies> Movies { get; set; }

        public DbSet<LibraryApp1.Models.Authors> Authors { get; set; }
        public DbSet<LibraryApp1.Models.Categories> Categories { get; set; }
        public DbSet<LibraryApp1.Models.Users> Users { get; set; }
        public DbSet<LibraryApp1.Models.Books> Books { get; set; }
        public DbSet<LibraryApp1.Models.BooksLoan> BooksLoan { get; set; }
    }
}
