using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Financiera.Dominio;

namespace Financiera.Data
{
    public class TipoClienteData
    {
        public List<TipoCliente> Listar()
        {
            var listado = new List<TipoCliente>();
            return listado;
        }

        public TipoCliente BuscarPorId(int id)
        {
            var tipoCliente = new TipoCliente();
            return tipoCliente;
        }

    }
}
