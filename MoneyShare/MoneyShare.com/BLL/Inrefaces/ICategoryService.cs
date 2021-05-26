using MoneyShare.Core.DAL.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyShare.Core.BLL.Inrefaces
{
    public interface ICategoryService
    {
        public void CreateCategory(Category category);
        public IEnumerable<Category> GetCategories();
        public Category GetCategory(int id);
        void Dispose();
    }
}
