using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using FisherInsurance.Models;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling MVC for empty projects, visit http://go.microsoft.com/fwlink/?LinkID=397860



    public class AutoController : Controller
    {
        // GET: /<controller>/
        public IActionResult Index()
        {
            return Ok("This is the auto page");
        }

        [Route("auto/quotes")]
        public IActionResult quotes()
        {
        Quote quote = new Quote
        {
            Id = 345,
            Product = "Auto Insurance",

            ExpireDate = DateTime.Now.AddDays(45),
            Price = 45.00M
        };

        //return Ok("this is the quotes page");  
        return View(quote);      
        }

    }

