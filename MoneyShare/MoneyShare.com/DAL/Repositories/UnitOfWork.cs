using System;
using System.Collections.Generic;
using System.Text;
using MoneyShare.Core.DAL.Interfaces;
using MoneyShare.Core.DAL.Models;
using MoneyShare.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;

namespace MoneyShare.Core.DAL.Repositories
{
    public class UnitOfWork : IUnitOfWork
    {
        private ApplicationContext db;
        private CategoryRepository categoryRepository;
        private RecordRepository recordRepository;

        private bool disposed = false;


        public UnitOfWork(ApplicationContext appDb)
        {
            db = appDb;
        }
        public IRepository<Category> Categories { get {
                if (categoryRepository == null)
                    categoryRepository = new CategoryRepository(db); //ToDo: everytime new instance?
                return categoryRepository;

            } 
        }
        public IRepository<Record> Records { get {
                if(recordRepository == null)
                    recordRepository = new RecordRepository(db);
                return recordRepository;
            } 
        }
        async public void Save()
        {
            await db.SaveChangesAsync();
        }


        public virtual void Dispose(bool disposing)
        {
            if (!this.disposed)
            {
                if (disposing)
                {
                    db.Dispose();
                }
                this.disposed = true;
            }
        }

        public void Dispose()
        {
            Dispose(true);
            GC.SuppressFinalize(this);
        }
    }
}
