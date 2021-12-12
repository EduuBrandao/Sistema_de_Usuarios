using AutoMapper;
using ClienteDomain.Entidades;
using ClienteInfra.IRepositorys;
using Dados.date;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClienteInfra.RepositoryService
{
    public class DadosClienteRepositoryService : BaseRepository<Cliente>, IDadosClienteRepository
    {

        private readonly IMapper _mapper;
        public DadosClienteRepositoryService(ClientesContext context, IMapper mapper) : base(context)
        {
            _mapper = mapper;
        }
        public Task<Cliente> Get(string CPF)
        {
            throw new NotImplementedException();
        }

        public void Post(Clientedomain cliente)
        {
            Cliente dados = new();


            dados.Nome = cliente.Nome;
            dados.Sobrenome = cliente.Sobrenome;
            dados.Telefone = cliente.Telefone;
            dados.Endereco = cliente.Endereco;
            dados.Cpf = cliente.CPF;


            Context.Cliente.Add(dados);
            Context.SaveChanges();
        }
        protected T Mapper<T>(object data)
        {
            return _mapper.Map<T>(data);
        }
    }
}
