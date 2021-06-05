using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using MoneyShare.Core.BLL.DTO;
using MoneyShare.Core.BLL.Inrefaces;
using MoneyShare.Models;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Controllers
{
    public class CategoryController : Controller
    {
        ICategoryService categoryService;
        public CategoryController(ICategoryService categoryService)
        {
            this.categoryService = categoryService;
        }
        public IActionResult Index()
        {
            IEnumerable<CategoryDTO> categoriesDTO = categoryService.GetCategories();
            CategoryRecordViewModel CRVM = new CategoryRecordViewModel { categoryViewModel = categoriesDTO };

            return View(CRVM);
        }

        [HttpGet]
        public async Task<IActionResult> CreateCategory()
        {
            return View("~/Views/Category/Creating.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryDTO categoryViewModel)
        {
            categoryService.CreateCategory(categoryViewModel);
            return Redirect("~/Category/Index");
            //return View("Index",CRVM); --RETURNS POST!
        }

        [HttpPost]
        public async Task<IActionResult> DeleteCategory([FromRoute] int id)
        {
            categoryService.DeleteCategory(id);
            return Redirect("~/Category/Index");
        }
        [HttpGet]
        public async Task<IActionResult> EditCategory([FromRoute] int id)
        {
            CategoryDTO cat = categoryService.GetCategory(id);
            ViewBag.CategoryId = cat.CategoryId;
            return View("~/Views/Category/Editing.cshtml", cat);
        }

        [HttpPost]
        public async Task<IActionResult> EditCategory(CategoryDTO categoryViewModel)
        {
            categoryService.UpdateCategory(categoryViewModel);
            return Redirect("~/Category/Index");
        }
    }
}
