using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contratos;
using RepositorioContratos;
using Transversal.Dtos;
namespace Implementacion
{
    public class Moneda100 : ITipoMoneda
    {
        private readonly IAlcanciaRepositorio repositorio;
        public Moneda100 (IAlcanciaRepositorio _repositorio)
        {
            repositorio = _repositorio;
        }
        public void AgregarMoneda(string path,Moneda moneda)
        {
            repositorio.Guardar(path, moneda);
        }
    }
}
