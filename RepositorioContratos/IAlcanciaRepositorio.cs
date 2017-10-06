using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Transversal.Dtos;
namespace RepositorioContratos
{
    public interface IAlcanciaRepositorio
    {
        void Guardar(string filepath, Moneda moneda);
        double getTotal(string path);
        List<MonedaInfoDto> getDetallesbyTipo(string path);
    }
}
