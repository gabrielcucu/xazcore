﻿using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using xazcore.Models;

namespace xazcore.Controllers
{
    public class HomeController : Controller
    {
        public IActionResult Index()
        {
            var x = "";
            return View();
        }

        public IActionResult About()
        {
            ViewData["Message"] = "NME application description page. ";

            return View();
        }

        public IActionResult Contact()
        {
            ViewData["Message"] = "Your contact page.";

            return View();
        }

        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
