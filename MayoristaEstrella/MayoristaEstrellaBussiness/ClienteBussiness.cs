using MayoristaEstrellaDAL;
using MayoristaEstrellaEntities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MayoristaEstrellaBussiness
{
    public class ClienteBussiness
    {

        public static List<Cliente> ListarClientes(string NombreApellido)
        {
            return ClienteDAL.ListarClientes(NombreApellido);
        }

        public static Cliente ABMCliente(Cliente cliente)
        {
            return ClienteDAL.ABMCliente(cliente);
        }

        public static void DeleteCliente(int id)
        {
            ClienteDAL.DeleteCliente(id);
        }

        public static Cliente ObtenerCliente(int Id)
        {
            return ClienteDAL.ObtenerCliente(Id);
        }
    }
}