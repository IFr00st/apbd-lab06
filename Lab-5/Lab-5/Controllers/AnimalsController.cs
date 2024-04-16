using Microsoft.AspNetCore.Mvc;

namespace Lab_5.Controllers;

[ApiController]
//[Route("api/animals")]
[Route("api/[controller]")]
public class AnimalsController : ControllerBase
{

  [HttpGet]
  public IActionResult GetAnimals()
  {
    return Ok();
  }
    
}