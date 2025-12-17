using MvcIntro.Models;
using System.Collections.Generic;

namespace MvcIntro.ViewModels
{
    public class HomeVM
    {
        public List<Slider> Sliders { get; set; } = new();
        public List<Product> Products { get; set; } = new();
    }
}
