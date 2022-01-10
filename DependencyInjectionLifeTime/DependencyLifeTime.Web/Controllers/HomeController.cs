using DependencyLifeTime.Web.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;

namespace DependencyLifeTime.Web.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IMyScopedService _scopedService;
        private readonly IMySingletonService _singletonService;
        private readonly IMyTransientService _transientService;
        private readonly AllManagementService _allmanagementService;
        public HomeController(ILogger<HomeController> logger,IMyScopedService myScopedService,IMyTransientService myTransientService,IMySingletonService mySingletonService,AllManagementService allManagementService)
        {
            _singletonService = mySingletonService;
            _transientService = myTransientService;
            _scopedService = myScopedService;
            _allmanagementService = allManagementService;
            _logger = logger;
        }

        public IActionResult Index()
        {
            ViewBag.Singleton = _singletonService.instanceId;
            ViewBag.Transient = _transientService.instanceId;
            ViewBag.Scoped = _scopedService.instanceId;
            ViewBag.AllManagement = _allmanagementService;
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
