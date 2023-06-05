using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using pizzas.Models;
using pizzas.Services;

namespace pizzas.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Pedido()
        {
            var arch = new LeerPizza();
            ViewBag.ArchivoPizzas = arch.LeerArchivo();
            return View();
        }
        [HttpPost]
        public ActionResult Pedido(Pizza p)
        {
            var pizza = new GuardarPizza();
            pizza.GuardaArchivoPizza(p);
            /*var arch = new LeerPizza();
            ViewBag.ArchivoPizzas = arch.LeerArchivo();*/
            return View("Pedido");
        }
        public ActionResult Terminar(Pizza p)
        {
            var arch = new LeerPizza();
            ViewBag.ArchivoPizzas = arch.LeerArchivo();
            return View();
        }
    }
}