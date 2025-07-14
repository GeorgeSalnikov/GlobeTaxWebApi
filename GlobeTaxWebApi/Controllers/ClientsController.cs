using Microsoft.AspNetCore.Mvc;

namespace GlobeTaxWebApi.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class ClientsController : ControllerBase
    {
        // GET: ClientsController/GetByContryCode/US
        /// <summary>
        /// clients?countryCode=US
        /// </summary>
        /// <param name="countryCode"></param>
        /// <returns></returns>
        [HttpGet(Name = "GetByContryCode")]
        public IEnumerable<Client> GetByContryCode(string countryCode)
        {
            return CsvClient.Get()[countryCode];
        }
    }
}
