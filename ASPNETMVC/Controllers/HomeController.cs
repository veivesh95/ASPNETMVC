using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ASPNETMVC.Models;
using ASPNETMVC.Data;
using System.Net.Http;
using Newtonsoft.Json;

namespace ASPNETMVC.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly PeopleDbContext _context;
        private readonly IHttpClientFactory _httpClient;


        public HomeController(ILogger<HomeController> logger, PeopleDbContext context, IHttpClientFactory httpClient)
        {
            _logger = logger;
            _context = context;
            _httpClient = httpClient;

        }

        public IActionResult Index()
        {
            return View();
        }

        public IActionResult Privacy()
        {
            return View();
        }
        public IActionResult Names()
        {
            // get the names and send it to the view

            var req = new HttpRequestMessage(HttpMethod.Get, "https://randomuser.me/api?inc=gender,name,nat");
            var client = _httpClient.CreateClient();

            // just pass the response to Json formatter and map the resilts to 


            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}
