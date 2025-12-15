using Microsoft.AspNetCore.Mvc;
using MvcIntro.DAL;
using MvcIntro.Models;
using MvcIntro.ViewModels;

namespace MvcIntro.Controllers
{
    public class HomeController : Controller
    {
        private readonly AppDbContext _context;
        public HomeController(AppDbContext context)
        {
            _context = context;
            
        }


        //List<Slider> sliders = new List<Slider>
        //{
        //    new Slider { Subtitle="Basliq 1", Title = "Komekci basliq 1", Descreption="Gullerden qalmadi", ImageURL="2-1-960x741.jpg",Order=1, IsDeleted=false, CreatedAt=DateTime.Now },
        //    new Slider { Subtitle="Basliq 2", Title = "Komekci basliq 2", Descreption="Gullerden qalmadi 2", ImageURL="2-2-960x741.jpg",Order=2, IsDeleted=false, CreatedAt=DateTime.Now },
        //    new Slider {Subtitle = "Basliq 3", Title = "Komekci basliq 3", Descreption = "Gullerden qalmadi 3", ImageURL = "2-3-960x741.jpg", Order = 3, IsDeleted = false, CreatedAt = DateTime.Now}
        //};
        public  IActionResult Index(int id)
        {


            List<Slider> sliders = _context.Sliders.OrderBy(s=>s.Order).ToList();
            //_context.AddRange(sliders);
            //_context.SaveChanges();

            HomeVM homeVM = new HomeVM()
            {
                Sliders = sliders.OrderBy(s=>s.Order).Take(2).ToList(),
            };

            return View(homeVM);
        }

       
    }
}
