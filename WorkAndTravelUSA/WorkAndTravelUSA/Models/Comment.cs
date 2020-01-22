﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkAndTravelUSA.Models
{
    public class Comment
    {
        public Comment () { }
        [Key]
        public int Id { get; set; }
        
        public int idClient { get; set; }
        public int IdLoc { get; set; }
        [Required]
        public string Description { get; set; }
    }
}