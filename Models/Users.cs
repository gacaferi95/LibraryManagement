using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace LibraryApp1.Models
{
    public class Users
    {
        public int ID { get; set; }

        [Required]
        public string userName { get; set; }

        [Required]
        public string userSurname { get; set; }

        [Required]
        public string userAddress { get; set; }

        [Required]
        public string userPhone { get; set; }

        [Required]
        public string userEmail { get; set; }

    }
}
