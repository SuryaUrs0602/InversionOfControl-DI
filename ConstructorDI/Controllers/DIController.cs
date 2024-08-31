using AddTransient.Services;
using ConstructorDI.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace ConstructorDI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class DIController : ControllerBase
    {
        private readonly IService _service;

        public DIController(IService service, 
            SharedDevices shared, HitCounters hit, HitCounters hit1, HitCounters hit2,
            Caching cache, Caching cache2, Caching cache3)
        {
            _service = service;            
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok(_service.GetName());
        }
    }
}


//, 
