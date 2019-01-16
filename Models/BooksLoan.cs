using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp1.Models
{
    public class BooksLoan
    {
        public int ID { get; set; }
        public DateTime IssuedData { get; set; }
        public DateTime ReturnedDate { get; set; }

        public int BooksId { get; set; }
        public int UsersId { get; set; }

        public Books Books { get; set; }
        public Users Users { get; set; }
    }
}
