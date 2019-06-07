using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace ExamPreparation.Controllers
{
    public class MealOfTheDayController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}