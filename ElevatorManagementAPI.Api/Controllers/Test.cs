using Microsoft.AspNetCore.Mvc;

namespace ElevatorManagementAPI.Api.Controllers
{
  [Route("api/[controller]")]
  [ApiController]
  public class Test : ControllerBase
  {
    [HttpGet]
    public IActionResult Get()
    {
      return Ok("Hello World test!!!");
    }
  }
}