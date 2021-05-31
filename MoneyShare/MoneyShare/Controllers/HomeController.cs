using Microsoft.AspNetCore.Mvc;
using MoneyShare.Core.BLL.Inrefaces;
using System.Collections.Generic;
using System.Threading.Tasks;
using MoneyShare.Core.BLL.DTO;
using AutoMapper;
using MoneyShare.Models;

namespace MoneyShare.Controllers
{
    public class HomeController : Controller
    {
        private readonly ICategoryService categoryService;
        private readonly IRecordService recordService;
        public HomeController(ICategoryService categoryService, IRecordService recordService)
        {
            this.categoryService = categoryService;
            this.recordService = recordService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<CategoryDTO> categoriesDTO = categoryService.GetCategories();
            IEnumerable<RecordDTO> recordsDTO = recordService.GetRecords();

            CategoryRecordViewModel CRVM = new CategoryRecordViewModel { categoryViewModel = categoriesDTO, recordViewModel = recordsDTO };

            return View(CRVM);
        }
    }
}
