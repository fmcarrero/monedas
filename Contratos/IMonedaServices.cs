using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.Dtos;

namespace Contratos
{
   public interface IMonedaServices
    {
        void Agregar(string path,Moneda moneda);
        List<MonedaInfoDto> GetAll();
        double GetSumaAlcancia(string path);
        List<MonedaInfoDto> getDetalles(string path);
    }
}
