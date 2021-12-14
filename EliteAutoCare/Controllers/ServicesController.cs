using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace EliteAutoCare.Controllers
{
    public class ServicesController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
        public IActionResult CeramicCoating() //Seramik kaplama
        {
            return View();
        }
        public IActionResult ExteriorDetailing() //Dış Detaylandırma
        {
            return View();
        }
        public IActionResult InteriorDetailing() //İç Detaylandırma
        {
            return View();
        }
        public IActionResult PaintCorrection() //Boya Düzeltme
        {
            return View();
        }
        public IActionResult CompleteDetailing() //Tam Detaylandırma
        {
            return View();
        }
        public IActionResult MaintenanceDetailing() //Detaylı Bakım
        {
            return View();
        }
        public IActionResult HeadlampRestoration() //Far
        {
            return View();
        }
    }
}
