using Microsoft.EntityFrameworkCore;
using MVCproject.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MVCproject.Data
{
    public class ApplicationDbContext :DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> option) : base(option)   
        {

        }
        public DbSet<Category> Category { get; set; }
    }
}
