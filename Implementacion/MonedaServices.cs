using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contratos;
using Transversal.Dtos;
using Contratos.Factory;
using Transversal;
using RepositorioContratos;
namespace Implementacion
{
    public class MonedaServices : IMonedaServices
    {
        private readonly IFactoryMoneda Factory;
        private readonly IAlcanciaRepositorio repositorio;
        public MonedaServices(IFactoryMoneda _factory,IAlcanciaRepositorio _repositorio) {
            Factory = _factory;
            repositorio = _repositorio;
        }
        public List<MonedaInfoDto> getDetalles(string path) {
            return repositorio.getDetallesbyTipo(path);
        }
        public double GetSumaAlcancia(string path) {
            return repositorio.getTotal(path);
        }
        public List<MonedaInfoDto> GetAll() {
            List<MonedaInfoDto> lista = new List<MonedaInfoDto>();
            foreach (EnumTipoMoneda.TipoMonedaE tipomoneda in Enum.GetValues(typeof(EnumTipoMoneda.TipoMonedaE)))
            {
                lista.Add(new MonedaInfoDto { NombreMoneda = tipomoneda.ToString(),TipoMoneda= (int) tipomoneda });
            }
            return lista;
        }
        public void Agregar(string path,Moneda moneda) {
            EnumTipoMoneda.TipoMonedaE enunmoneda= (EnumTipoMoneda.TipoMonedaE)Enum.ToObject(typeof(EnumTipoMoneda.TipoMonedaE), moneda.TipoMoneda);
            ITipoMoneda tipomoneda=  Factory.FactoryCrearMoneda(enunmoneda);
            tipomoneda.AgregarMoneda(path,moneda);
        }
    }
}
