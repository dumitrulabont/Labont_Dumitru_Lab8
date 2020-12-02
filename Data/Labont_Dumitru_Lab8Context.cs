using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Labont_Dumitru_Lab8.Models;

namespace Labont_Dumitru_Lab8.Data
{
    public class Labont_Dumitru_Lab8Context : DbContext
    {
        public Labont_Dumitru_Lab8Context (DbContextOptions<Labont_Dumitru_Lab8Context> options)
            : base(options)
        {
        }

        public DbSet<Labont_Dumitru_Lab8.Models.Book> Book { get; set; }

        public DbSet<Labont_Dumitru_Lab8.Models.Publisher> Publisher { get; set; }

        public DbSet<Labont_Dumitru_Lab8.Models.Category> Category { get; set; }
    }
}
