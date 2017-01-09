// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

using DotNetCorePOC.Interfaces;
using DotNetCorePOC.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;

namespace DotNetCorePOC.Controllers
{
    public class HomeController : Controller
    {
        private readonly IRestaurantData RestuarantData;
        public HomeController(IRestaurantData restaurantData)
        {
            RestuarantData = restaurantData;
        }

        public ViewResult Index()
        {
            return View(RestuarantData.GetAll());
        }
    }
}
