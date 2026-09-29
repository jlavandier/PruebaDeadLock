using Microsoft.AspNetCore.Mvc;
using Prueba.Models;

namespace Prueba.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClienteController : ControllerBase
    {
        [HttpPost]
        public async Task<IActionResult>PostCliente(Clientes cliente)
        {   
            var clienteBody = new Clientes
            {                
                Nombre = cliente.Nombre,
                Apellido = cliente.Apellido
            };



            return Ok(new { mensaje = "Cliente creado exitosamente", cliente });
        }
    }
}
