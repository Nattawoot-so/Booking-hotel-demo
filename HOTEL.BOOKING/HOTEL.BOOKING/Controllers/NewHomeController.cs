using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace HOTEL.BOOKING.Controllers
{
    public class NewHomeController : Controller
    {
        public IActionResult NewIndexPage()
        {
            return View();
        }
    }
}
