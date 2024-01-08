using Microsoft.AspNetCore.Mvc;
namespace Routes.Controller;

[ApiController]
[Route("[controller]")]
public class NameController : ControllerBase
{
    public string input = "";
    //input = Console.Readline();
    // public List<string> nameList = new();

    public NameController()
    {
        // nameList.Add()input;
    }

    // [HttpGet]
    // public List<string>GetNames()
    // {
    //     return nameList;
    // }

    [HttpPost]
    [Route("AddName/{inputName}")]
    public string AddName(string inputName)
    {
        input = inputName;
        return $"Hello, {input}!";
    }
}
