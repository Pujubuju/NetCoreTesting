using System;
using Microsoft.AspNetCore.Mvc;

public class HelloWorldController : Controller
    {
        [HttpGet("api/helloworld")]
        public object HelloWorld()
        {
            return new
            {
                message = "Hello World",
                time = DateTime.Now
            };
        }

        [HttpGet("helloworld")]
        public ActionResult Helloworld()
        {
            ViewBag.Message = "Hello world!";
            ViewBag.Time = DateTime.Now;
            return View("helloworld");
        }
    }