using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace eCommerce.Campaign.MvcWebUI.Controllers
{
    public class CampaignController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}