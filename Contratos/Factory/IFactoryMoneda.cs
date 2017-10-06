using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal;

namespace Contratos.Factory
{
    public interface IFactoryMoneda
    {
        ITipoMoneda FactoryCrearMoneda(EnumTipoMoneda.TipoMonedaE tipoMoneda);
    }
}
