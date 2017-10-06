using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Optimization;
using System.Web.Routing;
using Contratos.xml;
using Implementacion.xml;

namespace Alcancia
{
    public class MvcApplication : System.Web.HttpApplication
    {
        private readonly IXmlWork _xmlwork;
        public MvcApplication() {
            _xmlwork = new XmlWork();
        }
        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            FilterConfig.RegisterGlobalFilters(GlobalFilters.Filters);
            RouteConfig.RegisterRoutes(RouteTable.Routes);
            BundleConfig.RegisterBundles(BundleTable.Bundles);
            _xmlwork.CrearXml(Server.MapPath("/"));
        }
    }
}
