using ComplaintManagement.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace ComplaintManagement.Controllers
{
    public class IssueController : Controller
    {
        private readonly ILogger<IssueController> _logger;

        public IssueController(ILogger<IssueController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

      
    }
}
