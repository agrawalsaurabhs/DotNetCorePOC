﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Authorization;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

namespace DotNetCorePOC.Controllers
{
    [Route("[controller]/[action]")]
    [Authorize]
    public class AboutController 
    {
        public string Phone()
        {
            return "1234567890";
        }
        
        public string Address()
        {
            return "USA";
        }
    }
}
