using Microsoft.AspNetCore.Mvc;

namespace DinoApi.Controllers;

[ApiController]
[Route("[controller]")]
public class WeatherForecastController : ControllerBase
{
    [HttpGet]
    public IEnumerable<string> Get(){
        string[] nombres = new[]{"Fabian", "Rolando", "Maria","Rebeca"};
        return nombres;
    }
}
