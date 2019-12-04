using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using Assignment_Two.Models;

namespace Assignment_Two.Data
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, ApplicationRole, string>
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }
             public DbSet<Assignment_Two.Models.Owner> Owners { get; set; }

            public DbSet<Assignment_Two.Models.Team> Teams { get; set; }
    }
    
}
