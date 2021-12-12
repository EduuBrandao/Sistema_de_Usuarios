using ClienteApplication;
using ClienteApplication.Repositori;
using ClienteDomain.Entidades;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication1.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class ClienteController : ControllerBase
    {
        private readonly ClienteRepository _dadosClienteService;
        private readonly object OkCreatedResult = new { message = "Successfully created new customer." };
        public ClienteController(ClienteRepository dadosClienteService)
        {
            _dadosClienteService = dadosClienteService;
        }

        [HttpPost]
        public ActionResult PostCliente([FromBody] Clientedomain cliente)
        {
            var retorno = _dadosClienteService.PostCliente(cliente);

            return Ok(OkCreatedResult);
        }


    }
}
