using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Contratos;
using Transversal.Dtos;
using System.Configuration;
namespace Alcancia.Controllers
{
    public class MonedaController : Controller
    {
        private readonly IMonedaServices _monedaservices;
        public MonedaController(IMonedaServices monedaservices) {
            _monedaservices = monedaservices;
        }
        public ActionResult GetAll() {
            List<MonedaInfoDto> lista = _monedaservices.GetAll();
            return Json(lista);
        }
        public ActionResult GetSumaAlcancia() {
            string namefile = ConfigurationManager.AppSettings["nombrearchivoxml"];
            double suma = _monedaservices.GetSumaAlcancia(Server.MapPath("/") + namefile);

            return Json(suma);
        }
        public ActionResult getDetalles() {
            string namefile = ConfigurationManager.AppSettings["nombrearchivoxml"];
            List<MonedaInfoDto> lista = _monedaservices.getDetalles(Server.MapPath("/") + namefile);
            return Json(lista);
        }
    }
}