using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkAndTravelUSA.Models
{
    public class Location
    {
        public Location () { }
        [Key]
        public int Id { get; set; }
        public int IdClient { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        public string State { get; set; }
        [Required]
        public string Description { get; set; }
        [Required]
        public string imgUrl { get; set; }

        public virtual List<Comment> Comments { get; set;}

    }
}