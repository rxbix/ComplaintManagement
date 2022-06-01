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
    public class IssueAttachmentController : Controller
    {
        private readonly ILogger<IssueAttachmentController> _logger;

        public IssueAttachmentController(ILogger<IssueAttachmentController> logger)
        {
            _logger = logger;
        }

        public IActionResult Index()
        {
            return View();
        }

    }
}
