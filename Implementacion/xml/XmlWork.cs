using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contratos.xml;
using System.Xml;
using System.IO;
using System.Configuration;

namespace Implementacion.xml
{
    public class XmlWork : IXmlWork
    {
        public XmlTextWriter CrearXml(string filepath) {
            string namefile = ConfigurationManager.AppSettings["nombrearchivoxml"];
            XmlTextWriter xtw = new XmlTextWriter(filepath+ namefile, Encoding.UTF8);
            xtw.WriteStartDocument();
            xtw.WriteStartElement("monedas");
            xtw.WriteEndElement();
            xtw.Close();            
            return xtw;
        }
        
    }
}
