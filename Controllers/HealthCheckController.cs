using Microsoft.AspNetCore.Mvc;

namespace AzureContainerApp_WebApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class HealthCheckController : ControllerBase
    {
        public HealthCheckController()
        {
        }

        [HttpGet]
        public IActionResult Get()
        {
            var data = new
            {
                Date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                Message = "Hello, world!"
            };

            return Ok(data);
        }

        [HttpPost]
        public IActionResult Register([FromBody] PersonModel person)
        {
            var data = new
            {
                Date = DateTime.Now.ToString("dd/MM/yyyy HH:mm:ss"),
                Message = $"Olá {person.Name}, te enviamos uma mensagem especial no email {person.Email}."
            };

            return Ok(data);
        }
    }
}