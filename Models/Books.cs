using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp1.Models
{
    public class Books
    {
        public int ID { get; set; }
        public string bookTitle { get; set; }
        public string image { get; set; }
        public int AuthorsId { get; set; }
        public int CategoriesId { get; set; }
        public int? Numbers { get; set; }

        public Authors Authors { get; set; }
        public Categories Categories { get; set; }

    }
}
