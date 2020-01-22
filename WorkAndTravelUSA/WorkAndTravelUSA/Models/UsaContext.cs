using Microsoft.AspNet.Identity.EntityFramework;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace WorkAndTravelUSA.Models
{
    public class UsaContext:IdentityDbContext
    {
        public DbSet<Client> clientModels { get; set; }
        public DbSet<Location> locationModels { get; set; }
        public DbSet<Comment> commentModels { get; set; }
        

        public UsaContext():base("DefaultConnection")
        {

        }

    }
}