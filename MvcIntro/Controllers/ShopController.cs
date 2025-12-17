using Microsoft.AspNetCore.Mvc;
using MvcIntro.DAL;
using MvcIntro.Models;
using MvcIntro.ViewModels;
using System.Reflection.Metadata.Ecma335;

namespace MvcIntro.Controllers
{
    public class ShopController : Controller
    {
        private readonly AppDbContext _context;

        public ShopController(AppDbContext context)
        {
            _context = context;
        }
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult Details(int? id)
        {
            if (id == null || id<1) 
            { 
                return BadRequest();
            }


            Product? product = _context.Products.FirstOrDefault(p => p.Id == id);

            if (product == null) 
            {
                return NotFound();
            }

            DetailVM detailVM = new DetailVM()
            {
                    product = product,
            };

            return View(detailVM);
        }
    }
}
