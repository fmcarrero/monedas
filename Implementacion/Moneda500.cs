using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contratos;
using Transversal.Dtos;
using RepositorioContratos;
namespace Implementacion
{
   public class Moneda500 : ITipoMoneda
    {
        private readonly IAlcanciaRepositorio repositorio;
        public Moneda500(IAlcanciaRepositorio _repositorio)
        {
            repositorio = _repositorio;
        }
        public void AgregarMoneda(string path,Moneda moneda)
        {
            repositorio.Guardar(path, moneda);
        }
    }
}
