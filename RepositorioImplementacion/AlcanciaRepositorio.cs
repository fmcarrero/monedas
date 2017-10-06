using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RepositorioContratos;
using Transversal.Dtos;
using System.IO;
using System.Xml;
using Transversal;
using System.Xml.Linq;
using System.Text.RegularExpressions;
namespace RepositorioImplementacion
{
   public  class AlcanciaRepositorio :IAlcanciaRepositorio
    {
        public List<MonedaInfoDto> getDetallesbyTipo(string path) {
            List<MonedaInfoDto> lista = new List<MonedaInfoDto>();
            XmlDocument xdoc = new XmlDocument();            
            FileStream rfile = new FileStream(path, FileMode.Open);
            xdoc.Load(rfile);
            foreach (EnumTipoMoneda.TipoMonedaE tipomoneda in Enum.GetValues(typeof(EnumTipoMoneda.TipoMonedaE)))
            {
                double suma = getSumaByTipoMoneda(tipomoneda, xdoc);
                lista.Add(new MonedaInfoDto { NombreMoneda = tipomoneda.ToString(), Cantidad = suma });
               
            }
            rfile.Close();
            return lista;
        }
        public void Guardar(string filepath, Moneda moneda) {
            XmlDocument xd = new XmlDocument();
            FileStream lfile = new FileStream(filepath, FileMode.Open);
            xd.Load(lfile);
            XmlElement cl = xd.CreateElement("TipoMoneda");
            cl.SetAttribute("moneda", moneda.TipoMoneda.ToString());
            XmlElement na = xd.CreateElement("cantidad");
            XmlText natext = xd.CreateTextNode(moneda.Cantidad.ToString());
            na.AppendChild(natext);
            cl.AppendChild(na);
            var naTIPO = xd.CreateElement("tipomoneda");
            XmlText natextTIPO = xd.CreateTextNode(moneda.TipoMoneda.ToString());
            naTIPO.AppendChild(natextTIPO);
            cl.AppendChild(naTIPO);
            xd.DocumentElement.AppendChild(cl);
            lfile.Close();

            xd.Save(filepath);
            
        }
        public double getTotal(string path) {
            double suma = 0;
            XmlDocument xdoc = new XmlDocument();
            FileStream rfile = new FileStream(path, FileMode.Open);
            xdoc.Load(rfile);
            XmlNodeList list = xdoc.GetElementsByTagName("TipoMoneda");
            for (int i = 0; i < list.Count; i++)
            {
                XmlElement add = (XmlElement)xdoc.GetElementsByTagName("cantidad")[i];
                suma =suma + double.Parse(add.InnerText);
                
            }
            rfile.Close();
            
            return suma;
        }
        private double getSumaByTipoMoneda(EnumTipoMoneda.TipoMonedaE tipomoneda, XmlDocument xdoc) {
            double suma = 0;
            XmlNodeList list = xdoc.GetElementsByTagName("TipoMoneda");
            suma =list.Cast<XmlNode>().Where(e => e["tipomoneda"].InnerText.Equals(Convert.ToString((int)tipomoneda))).Sum(x =>Double.Parse( x["cantidad"].InnerText));
                     
            return suma;
        }
    }
}
