using MoneyShare.Core.DAL.Interfaces;
using MoneyShare.Core.DAL.Models;
using System;
using System.Collections.Generic;
using MoneyShare.Core.DAL.Context;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace MoneyShare.Core.DAL.Repositories
{
    public class CategoryRepository : IRepository<Category>
    {
        private ApplicationContext db;

        public CategoryRepository(ApplicationContext db)
        {
            this.db = db;
        }
        public void Create(Category item)
        {
            db.Categories.Add(item);
            db.SaveChanges();
        }

        public void Delete(int id)
        {
            Category category = db.Categories.FirstOrDefault(e=>e.CategoryId == id);
            if (category != null)
            {
                db.Categories.Remove(category);
                db.SaveChanges();
            }
        }

        public IEnumerable<Category> Find(Func<Category, bool> predicate)
        {
            return db.Categories.Include(o => o.CategoryId).Where(predicate).ToList();
        }

        public Category Get(int id)
        {
            return db.Categories.FirstOrDefault(e=>e.CategoryId == id);
        }

        public IEnumerable<Category> GetAll()
        {
            return db.Categories.ToList();
        }

        public void Update(Category item)
        {
            //db.Entry(item).State = EntityState.Modified; //ToDo: ?
        }
    }
}
