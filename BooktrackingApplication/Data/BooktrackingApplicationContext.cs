using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using booktrackingapp.Models;

namespace BooktrackingApplication.Data
{
    public class BooktrackingApplicationContext : DbContext
    {
        public BooktrackingApplicationContext (DbContextOptions<BooktrackingApplicationContext> options)
            : base(options)
        {
        }

        public DbSet<booktrackingapp.Models.Book> Book { get; set; }

        public DbSet<booktrackingapp.Models.Category> Category { get; set; }

        public DbSet<booktrackingapp.Models.CategoryType> CategoryType { get; set; }
    }
}
