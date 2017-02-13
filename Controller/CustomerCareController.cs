
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860

[Route("customer")]

public class CustomerCareController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
        return Ok("This is the customer care page");
    }

    [Route("customercare/fileclaim")]
    public IActionResult quotes()
    {

        return Ok("this is the claims page");
    }
}
    

