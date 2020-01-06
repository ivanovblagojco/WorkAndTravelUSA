using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkAndTravelUSA.Models
{
    public class Client
    {
        public Client () {}
        [Key]
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string Surname { get; set; }
        public string Address { get; set; }
        [Range(15, 70, ErrorMessage = "Age must be a number larger than 15")]
        public int Age { get; set; }
    }
}