using Microsoft.EntityFrameworkCore;
using MoneyShare.Core.DAL.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Core.DAL.Context
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {
            
        }

        //static ApplicationContext()
        //{
        //    Database.SetInitializer<MobileContext>(new StoreDbInitializer());
        //}
        //public ApplicationContext(string connectionString)
        //    : base(connectionString)
        //{
        //}

        public DbSet<Record> Records { get; set; }
        public DbSet<Category> Categories { get; set; }
    }
}
