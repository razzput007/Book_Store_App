﻿using Microsoft.AspNetCore.Mvc;

namespace BookStoreApp.Controllers
{
    public class CategoryController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }
    }
}
