using ClienteApplication.Repositori;
using ClienteDomain.Entidades;
using ClienteDomain.Services;
using ClienteInfra.IRepositorys;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteApplication
{
    public class DadosClienteService : ClienteRepository
    {

        private readonly IDadosClienteRepository _dadosClienteRepository;
        public DadosClienteService(IDadosClienteRepository dadosClienteRepository)
        {
            _dadosClienteRepository = dadosClienteRepository;
        }
        public Task<Clientedomain> GetCliente(string CPF)
        {
            throw new NotImplementedException();
        }

        public ObjectResponse<object> PostCliente(Clientedomain cliente)
        {
            ObjectResponse<object> result = new();

            try
            {
                _dadosClienteRepository.Post(cliente);

            }

            catch (Exception ex)
            {
                result.OkResult = false;
                result.Data = new { errorMessage = ex.Message, help = ex.HelpLink };
            }

            return result;
        }
    }
}
