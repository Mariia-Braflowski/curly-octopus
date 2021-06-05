using Microsoft.AspNetCore.Mvc;
using MoneyShare.Core.BLL.Inrefaces;
using System.Threading.Tasks;

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
            if (User.Identity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return View("~/Views/Account/Register.cshtml");
            }
            //IEnumerable<CategoryDTO> categoriesDTO = categoryService.GetCategories();
            //IEnumerable<RecordDTO> recordsDTO = recordService.GetRecords();

            //CategoryRecordViewModel CRVM = new CategoryRecordViewModel { categoryViewModel = categoriesDTO, recordViewModel = recordsDTO };

           
        }
    }
}
