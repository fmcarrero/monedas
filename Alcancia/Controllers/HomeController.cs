using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Transversal.Dtos;
using Contratos;
using System.Configuration;
using System.Net;
using Alcancia.App_Start;

namespace Alcancia.Controllers
{
    public class HomeController : Controller
    {
        private readonly IMonedaServices monedaservices;
        public HomeController(IMonedaServices _monedaservices) {
            monedaservices = _monedaservices;
        }
        public ActionResult Index()
        {
            return View();
        }
        [ExceptionErrorHandler]
        public ActionResult AgregarMoneda(Moneda moneda) {
            string namefile = ConfigurationManager.AppSettings["nombrearchivoxml"];
            monedaservices.Agregar(Server.MapPath("/")+namefile,moneda);
            return RedirectToAction("Index", "Home");
        }
    }
    
}