using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace WorkAndTravelUSA.Models
{
    public class ClientLoc
    {
        public ClientLoc () { }
        [Key]
        public int Id { get; set; }
        public Client Client { get; set; }
        public List<Location> Locations { get; set; }
    }
}