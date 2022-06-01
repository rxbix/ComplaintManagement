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
    public class CustomerAttachmentController : Controller
    {
        private readonly ILogger<CustomerAttachmentController> _logger;

        public CustomerAttachmentController(ILogger<CustomerAttachmentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }
    }
}
