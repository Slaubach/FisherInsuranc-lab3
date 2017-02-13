
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860



public class HomeInsController : Controller
{
    // GET: /<controller>/
    public IActionResult Index()
    {
        return Ok("This is the homeIns page");
    }

    [Route("HomeIns/quotes")]
    public IActionResult quotes()
    {

        return Ok("this is the quotes page");
    }
}

