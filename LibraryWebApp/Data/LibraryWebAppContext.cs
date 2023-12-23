using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using LibraryWebApp.Models;

namespace LibraryWebApp.Data
{
    public class LibraryWebAppContext : DbContext
    {
        public LibraryWebAppContext (DbContextOptions<LibraryWebAppContext> options)
            : base(options)
        {
        }

        public DbSet<LibraryWebApp.Models.Book> Book { get; set; } = default!;
    }
}
