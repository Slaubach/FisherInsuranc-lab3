
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860



    public class LifeController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
        return Ok("This is the life page");
    }

    [Route("life/quotes")]
    public IActionResult quotes()
    {

        return Ok("this is the quotes page");
    }
}
