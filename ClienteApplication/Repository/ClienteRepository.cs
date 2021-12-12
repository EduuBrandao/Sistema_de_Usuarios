using ClienteDomain.Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteApplication.Repositori
{
   public interface ClienteRepository
    {
        ObjectResponse<object> PostCliente (Clientedomain cliente);

        Task<Clientedomain> GetCliente(string CPF);

    }
}
