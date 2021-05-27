using MoneyShare.Core.BLL.Inrefaces;
using System;
using System.Collections.Generic;
using MoneyShare.Core.DAL.Interfaces;
using MoneyShare.Core.BLL.DTO;
using MoneyShare.Core.DAL.Models;
using AutoMapper;
using MoneyShare.Core.BLL.Infrastructure;

namespace MoneyShare.Core.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        IUnitOfWork Database;
        public CategoryService(IUnitOfWork uow)
        {
            Database = uow;
        }
        public void CreateCategory(CategoryDTO category)
        {
            Category categoryDB = Database.Categories.Get(category.CategoryId);
            if(categoryDB == null)
                Database.Categories.Create(new Category { CategoryId = category.CategoryId, Title = category.Title, Color = category.Color,
                    Icon = category.Icon, CategoryType = category.CategoryType });
        }

        public void Dispose()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<CategoryDTO> GetCategories()
        {
            // вариация //var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>()).CreateMapper();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>());
            var mapper = new Mapper(config);
            return mapper.Map<IEnumerable<Category>, List<CategoryDTO>>(Database.Categories.GetAll());
        }

        public CategoryDTO GetCategory(int id)
        {
            if (id == null) { }
            Category category = Database.Categories.Get(id);
            if(category == null) 
                throw new ValidationException("Category", "Category not found");
            return new CategoryDTO { CategoryId = id, Title = category.Title, Color = category.Color, Icon = category.Icon, CategoryType = category.CategoryType } ;
        }
    }
}
