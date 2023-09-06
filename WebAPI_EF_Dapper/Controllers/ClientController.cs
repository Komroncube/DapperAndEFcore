global using DapperAndEFcore.Models;
using DapperAndEFcore.Service.DapperFolder;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI_EF_Dapper.Controllers
{
    [Route("api/[controller]/[action]")]
    [ApiController]
    public class ClientController : ControllerBase
    {
        private readonly ClientServiceDapper clientServiceDapper;

        public ClientController(ClientServiceDapper clientServiceDapper)
        {
            this.clientServiceDapper = clientServiceDapper;
        }
        [HttpGet]
        public IEnumerable<Client> GetAllClients()
        {
            return clientServiceDapper.GetAllClients();
        }
        [HttpGet]
        public Client GetClientById(int id) 
        {
            return clientServiceDapper.GetById(id);

        }
        [HttpPost]
        public IActionResult AddClient(Client client)
        {
            clientServiceDapper.AddClient(client);
            return Ok();
        }
        [HttpPut]
        public IActionResult EditClient(Client client)
        {
            clientServiceDapper.Update(client);
            return Ok(client);
        }
        [HttpDelete]
        public void DeleteClient(int clientId)
        {
            clientServiceDapper.DeleteClient(clientId);
        }
    }
}
