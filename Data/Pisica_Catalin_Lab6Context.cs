using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using Pisica_Catalin_Lab6.Models;

namespace Pisica_Catalin_Lab6.Data
{
    public class Pisica_Catalin_Lab6Context : DbContext
    {
        public Pisica_Catalin_Lab6Context (DbContextOptions<Pisica_Catalin_Lab6Context> options)
            : base(options)
        {
        }

        public DbSet<Pisica_Catalin_Lab6.Models.Book> Book { get; set; }
    }
}
