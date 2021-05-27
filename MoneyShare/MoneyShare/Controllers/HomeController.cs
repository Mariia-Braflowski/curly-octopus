using Microsoft.AspNetCore.Mvc;
using MoneyShare.Core.BLL.Inrefaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MoneyShare.Core.BLL.DTO;
using AutoMapper;
using MoneyShare.Models;

namespace MoneyShare.Controllers
{
    public class HomeController : Controller
    {
        //private ApplicationContext db;
        ICategoryService categoryService;
        IRecordService recordService;
        public HomeController(ICategoryService categoryService, IRecordService recordService)
        {
            this.categoryService = categoryService;
            this.recordService = recordService;
        }
        public async Task<IActionResult> Index()
        {
            IEnumerable<CategoryDTO> categoriesDTO = categoryService.GetCategories();
            IEnumerable<RecordDTO> recordsDTO = recordService.GetRecords();
            var mapper1 = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, CategoryViewModel>()).CreateMapper();
            var categories = mapper1.Map<IEnumerable<CategoryDTO>, List<CategoryViewModel>>(categoriesDTO);

            var mapper2 = new MapperConfiguration(cfg => cfg.CreateMap<RecordDTO, RecordViewModel>()).CreateMapper();
            var records = mapper2.Map<IEnumerable<RecordDTO>, List<RecordViewModel>>(recordsDTO);

            CategoryRecordViewModel CRVM = new CategoryRecordViewModel { categoryViewModel = categories, recordViewModel = records };

            return View(CRVM);
        }

        [HttpGet]
        public async Task<IActionResult> CreateCategory()
        {
            return View();
        }

        [HttpPost]
        public async Task<IActionResult> CreateCategory(CategoryViewModel categoryViewModel)
        {
            
            
            
            
            IEnumerable<CategoryDTO> categoriesDTO = categoryService.GetCategories();
            IEnumerable<RecordDTO> recordsDTO = recordService.GetRecords();
            var mapper1 = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, CategoryViewModel>()).CreateMapper();
            var categories = mapper1.Map<IEnumerable<CategoryDTO>, List<CategoryViewModel>>(categoriesDTO);

            var mapper2 = new MapperConfiguration(cfg => cfg.CreateMap<RecordDTO, RecordViewModel>()).CreateMapper();
            var records = mapper2.Map<IEnumerable<RecordDTO>, List<RecordViewModel>>(recordsDTO);

            CategoryRecordViewModel CRVM = new CategoryRecordViewModel { categoryViewModel = categories, recordViewModel = records };

            return View("Index",CRVM);
        }
        public async Task<IActionResult> CreateRecord()
        {
            IEnumerable<CategoryDTO> categoriesDTO = categoryService.GetCategories();
            IEnumerable<RecordDTO> recordsDTO = recordService.GetRecords();
            var mapper1 = new MapperConfiguration(cfg => cfg.CreateMap<CategoryDTO, CategoryViewModel>()).CreateMapper();
            var categories = mapper1.Map<IEnumerable<CategoryDTO>, List<CategoryViewModel>>(categoriesDTO);

            var mapper2 = new MapperConfiguration(cfg => cfg.CreateMap<RecordDTO, RecordViewModel>()).CreateMapper();
            var records = mapper2.Map<IEnumerable<RecordDTO>, List<RecordViewModel>>(recordsDTO);

            CategoryRecordViewModel CRVM = new CategoryRecordViewModel { categoryViewModel = categories, recordViewModel = records };

            return View(CRVM);
        }
    }
}
