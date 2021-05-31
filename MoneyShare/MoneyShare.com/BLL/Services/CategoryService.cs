using MoneyShare.Core.BLL.Inrefaces;
using System;
using System.Collections.Generic;
using MoneyShare.Core.DAL.Interfaces;
using MoneyShare.Core.BLL.DTO;
using MoneyShare.Core.DAL.Models;
using AutoMapper;
using MoneyShare.Core.BLL.Infrastructure;
using MoneyShare.Core.DAL.Repositories;

namespace MoneyShare.Core.BLL.Services
{
    public class CategoryService : ICategoryService
    {
        private readonly IRepository<Category> repository;
        public CategoryService(IRepository<Category> repository)
        {
            this.repository = repository;
        }

        public void CreateCategory(CategoryDTO category)
        {
            Category categoryDB = repository.Get(category.CategoryId);
            if (categoryDB == null)
            {
                repository.Create(new Category
                {
                    Title = category.Title,
                    Color = category.Color,
                    Icon = category.Icon,
                    CategoryType = category.CategoryType
                });
            }
        }
        public CategoryDTO GetCategory(int id)
        {
            Category category = repository.Get(id);
            if (category == null)
                throw new ValidationException("Category", "Category not found");
            return new CategoryDTO
            {
                CategoryId = id,
                Title = category.Title,
                Color = category.Color,
                Icon = category.Icon,
                CategoryType = category.CategoryType
            };
        }
        public void DeleteCategory(int id)
        {
            repository.Delete(id);
        }
        public IEnumerable<CategoryDTO> GetCategories()
        {
            // вариация //var mapper = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>()).CreateMapper();
            var config = new MapperConfiguration(cfg => cfg.CreateMap<Category, CategoryDTO>());
            var mapper = new Mapper(config);
            return mapper.Map<IEnumerable<Category>, IEnumerable<CategoryDTO>>(repository.GetAll());
        }
    }
}
