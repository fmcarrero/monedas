using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.Dtos;

namespace Contratos
{
   public interface ITipoMoneda
    {
        void AgregarMoneda(string path,Moneda moneda);
    }
}
