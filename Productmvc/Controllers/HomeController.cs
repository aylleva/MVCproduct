using Microsoft.AspNetCore.Mvc;
using Productmvc.Models;
using Productmvc.ViewModels;
using static System.Net.WebRequestMethods;

namespace Productmvc.Controllers
{
    public class HomeController:Controller
    {
        public IActionResult Index()
        {
            List<Product> product = new List<Product> { 
            new Product
            {Image="https://encrypted-tbn0.gstatic.com/images?q=tbn:ANd9GcTAuZud1AOhMfutFcsbaUlibPMKysRmFGROYA&s",
            Name="YSL LIBRE",
            Description="Aromalar:Portagal,Lavander//Symbol Of Freedom",
            Price=195m,
            DiscountPrice=150m,
            Category="Fragrance",
            Color="Yellow"
            
            }

            };

            HomeVM homeVM = new HomeVM { Products=product };



            return View(homeVM);
        }
    }
}
