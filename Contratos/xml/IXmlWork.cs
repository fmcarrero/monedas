using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
namespace Contratos.xml
{
   public interface IXmlWork
    {
        XmlTextWriter CrearXml(string filepath);
    }
}
