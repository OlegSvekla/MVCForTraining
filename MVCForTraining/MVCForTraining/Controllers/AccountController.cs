﻿using Microsoft.AspNetCore.Mvc;

namespace MVCForTraining.Controllers
{
    public class Account : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
