using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contratos.Factory;
using Transversal;
using Contratos;
using RepositorioContratos;

namespace Implementacion.Factory
{
    public class FactoryMoneda : IFactoryMoneda
    {
        private readonly IAlcanciaRepositorio repositorio;
        public FactoryMoneda(IAlcanciaRepositorio _repositorio) {
            repositorio = _repositorio;
        }
        public ITipoMoneda FactoryCrearMoneda(EnumTipoMoneda.TipoMonedaE tipoMoneda) {
           switch (tipoMoneda)
            {
                case EnumTipoMoneda.TipoMonedaE.Moneda50:
                    return new Moneda50(repositorio);
                case EnumTipoMoneda.TipoMonedaE.Moneda100:
                    return new Moneda100(repositorio);
                case EnumTipoMoneda.TipoMonedaE.Moneda200:
                    return new Moneda200(repositorio);
                case EnumTipoMoneda.TipoMonedaE.Moneda500:
                    return new Moneda500(repositorio);
                case EnumTipoMoneda.TipoMonedaE.Moneda1000:
                    return new Moneda1000(repositorio);
                default:
                    throw new Exception("Moneda no permitida");
            }         
        
        }
    }
}
