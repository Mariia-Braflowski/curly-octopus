using Microsoft.AspNetCore.Mvc;
using MoneyShare.Context;
using MoneyShare.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MoneyShare.Controllers
{
    public class HomeController : Controller
    {
        private ApplicationContext db;
        public HomeController(ApplicationContext context)
        {
            db = context;
        }
        public async Task<IActionResult> Index()
        {
            Category cat = new Category() {
                Title = "Transfer",
                Color = "blue",
                Icon = null,
                CategoryType = 1
            };

            db.Categories.Add(cat);
            db.Records.Add(new Record() {
                CategoryId = 1,
                Amount = 12.2m,
                Date = DateTime.Now
            });
            await db.SaveChangesAsync();

            return View();
        }
    }
}
