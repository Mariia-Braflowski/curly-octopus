using Microsoft.EntityFrameworkCore;
using MoneyShare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        public DbSet<Record> Records { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
