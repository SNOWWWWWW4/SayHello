using Microsoft.AspNetCore.Mvc;
namespace Routes.Controller;

[ApiController]
[Route("[controller]")]
public class NameController : ControllerBase
{
    
    [HttpPost]
    [Route("AddName/{inputName}")]
    public string AddName(string inputName)
    {
        return $"Hello, {inputName}!";
    }
    
}
