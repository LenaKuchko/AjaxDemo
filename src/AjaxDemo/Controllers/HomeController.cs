using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using AjaxDemo.Models;

namespace AjaxDemo.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index() => View();

        public IActionResult HelloAjax() => Content("Hello from the controller", "text/plain");

        public IActionResult Sum(int firstNumber, int secondNumber) => Content((firstNumber + secondNumber).ToString(), "text/plain");

        public IActionResult DisplayObject()
        {
            Destination destination = new Destination("Tokyo", "Japan", 1);
            return Json(destination);
        }

        public IActionResult DisplayViewWithAjax() => View();
    }
}
