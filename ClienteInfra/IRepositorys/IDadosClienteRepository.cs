using ClienteDomain.Entidades;
using Dados.date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteInfra.IRepositorys
{
    public interface IDadosClienteRepository
    {

        void Post(Clientedomain daods);

        Task<Cliente> Get(string CPF);
    }
}
