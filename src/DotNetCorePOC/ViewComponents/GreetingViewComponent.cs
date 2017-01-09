using DotNetCorePOC.Interfaces;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotNetCorePOC.ViewComponents
{
    public class GreetingViewComponent : ViewComponent
    {
        private readonly IGreetingService _greetingservice;

        public GreetingViewComponent(IGreetingService greetingservice )
        {
            _greetingservice = greetingservice;
        }
        public IViewComponentResult Invoke()
        {
            var model = _greetingservice.Message;
            return View("Default", model);
        }
    }
}
