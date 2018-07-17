using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Web_Card_Validator.CardValidation;

namespace Web_Card_Validator.Controllers
{
    public class HomeController : Controller
    {
        // GET /home/index
        public ActionResult Index()
        {
            ViewBag.Message = "Enter a card number:";
            return View();
        }

        [HttpPost]
        public ActionResult Index(string message)
        {
            ViewBag.Message = "Enter a card number:";
            ViewBag.Response = CardInputProcessing.get_response_string(message);
            return View();
        }
    }
}