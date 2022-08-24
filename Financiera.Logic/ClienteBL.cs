using Financiera.Data;
using Financiera.Dominio;

namespace Financiera.Logic
{
    public static class ClienteBL
    {
        public static List<Cliente> Listar()
        {
            var clienteData = new ClienteData();
            return clienteData.Listar();
        }
    }
}
