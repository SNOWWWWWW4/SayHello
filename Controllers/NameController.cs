using Microsoft.AspNetCore.Mvc;
namespace Routes.Controller;

[ApiController]
[Route("[controller]")]
public class NameController : ControllerBase
{
    public string input = "";
    
    public NameController()
    {
        
    }

    

    [HttpPost]
    [Route("AddName/{inputName}")]
    public string AddName(string inputName)
    {
        input = inputName;
        return $"Hello, {input}!";
    }
}
