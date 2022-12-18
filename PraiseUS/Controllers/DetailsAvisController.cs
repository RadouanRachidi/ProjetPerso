﻿using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using PraiseUS.Data;
using PraiseUS.Models;
using System.Diagnostics;

namespace PraiseUs.Controllers
{
    public class DetailsAvisController : Controller
    {

        private readonly ApplicationDbContext _context;

        public IActionResult Details()
        {
            return View();
        }
    }
}