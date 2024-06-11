using Microsoft.AspNetCore.Mvc;

namespace QLKS_APIs.Controllers
{
    public class UserController : Controller
    {

        [HttpGet]

        public IEnumerable<WeatherForecast>? Get()
        {
            return null ;

        }
    }
}
