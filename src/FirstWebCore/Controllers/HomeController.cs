using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using FirstWebCore.Context;

namespace FirstWebCore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            using (SiteContext contexto = new SiteContext())
            {
                //var listaMenu = contexto.MenuSistema.ToList();

                return View();
            }
        }

        public IActionResult About()
        {
            ViewData["Message"] = "Your application description page.";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View();
        }

        public IActionResult Detalhar(int id)
        {
            ViewData["Message"] = "Vamos ver detalhes do link que você clicou.";

            using (SiteContext contexto = new SiteContext())
            {
                var item = contexto.MenuSistema.Find(id);
                if (item == null)
                    item = new Models.ModelMenuSistema();

                return View(item);
            }
        }
    }
}
