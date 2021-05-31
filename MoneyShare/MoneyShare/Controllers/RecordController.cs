using Microsoft.AspNetCore.Mvc;
using MoneyShare.Core.BLL.DTO;
using MoneyShare.Core.BLL.Inrefaces;
using System.Threading.Tasks;

namespace MoneyShare.Controllers
{
    public class RecordController : Controller
    {
        IRecordService recordService;
        public RecordController(IRecordService recordService)
        {
            this.recordService = recordService;
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<IActionResult> CreateRecord()
        {
            return View("~/Views/Record/Creating.cshtml");
        }

        [HttpPost]
        public async Task<IActionResult> CreateRecord(RecordDTO recordDTO)
        {
            recordService.CreateRecord(recordDTO);

            return Redirect("~/Home/Index");
            //return View("Index",CRVM); --RETURNS POST!
        }
    }
}
