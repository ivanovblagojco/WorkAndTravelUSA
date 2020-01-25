using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WorkAndTravelUSA.Models
{
    public class AddUserToRule
    {
        public string Email { get; set; }
        public string selectedRole { get; set; }
        public List<string> roles { get; set; }

        public AddUserToRule()
        {
            roles = new List<string>();
        }
    }
}