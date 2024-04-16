using Microsoft.AspNetCore.Mvc;
using Microsoft.Data.SqlClient;

namespace Lab_5.Controllers;

[ApiController]
//[Route("api/animals")]
[Route("api/[controller]")]
public class AnimalsController : ControllerBase
{
  private readonly IConfiguration _configuration;
  public AnimalsController(IConfiguration configuration)
  {
    _configuration = configuration;
  }

  [HttpGet]
  public IActionResult GetAnimals()
  {
    SqlConnection connection = new SqlConnection(_configuration.GetConnectionString("Default"));
    connection.Open();

    SqlCommand command = new SqlCommand();
    command.Connection = connection;
    command.CommandText = "SELECT * FROM Animal";

    var reader = command.ExecuteReader();
    List<object> animals = new List<object>();
    while (reader.Read())
    {
      
    }
    return Ok();
  }
    
}