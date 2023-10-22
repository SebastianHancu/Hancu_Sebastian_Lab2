using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Hancu_Sebastian_Lab2.Models;

namespace Hancu_Sebastian_Lab2.Data
{
    public class Hancu_Sebastian_Lab2Context : DbContext
    {
        public Hancu_Sebastian_Lab2Context (DbContextOptions<Hancu_Sebastian_Lab2Context> options)
            : base(options)
        {
        }

        public DbSet<Hancu_Sebastian_Lab2.Models.Book> Book { get; set; } = default!;

        public DbSet<Hancu_Sebastian_Lab2.Models.Publisher>? Publisher { get; set; }
    }
}
