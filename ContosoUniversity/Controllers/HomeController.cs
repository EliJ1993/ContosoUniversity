using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using SchedulerApp.Models;
using Microsoft.EntityFrameworkCore;
using SchedulerApp.Data;
using SchedulerApp.Models.SchoolViewModels;
using System.Data.Common;

namespace SchedulerApp.Controllers
{
    public class HomeController : Controller
    {

        private readonly SchoolContext _context;

        public HomeController(SchoolContext context)
        {
            _context = context;
        }

        public IActionResult Index()
        {
            return View();
        }

      
    }
}
