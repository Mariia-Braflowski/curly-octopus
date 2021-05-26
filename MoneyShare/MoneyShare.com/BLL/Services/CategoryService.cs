using MoneyShare.Core.BLL.Inrefaces;
using MoneyShare.Core.DAL.Models;
using System;
using System.Collections.Generic;
using MoneyShare.Core.DAL.Interfaces;

namespace MoneyShare.Core.BLL.Services
{
    class CategoryService : ICategoryService
    {
        IUnitOfWork Database;
        public CategoryService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void CreateCategory(Category category)
        {
            Database.Categories.Create(category);
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Category> GetCategories()
        {
            return Database.Categories.GetAll();
        }

        public Category GetCategory(int id)
        {
            return Database.Categories.Get(id);
        }
    }
}
