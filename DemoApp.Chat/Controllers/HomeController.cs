using DemoApp.Chat.Interfaces.Services;
using DemoApp.Chat.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System.Diagnostics;

namespace DemoApp.Chat.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IChatAgent _agent;
        public HomeController(ILogger<HomeController> logger, IChatAgent agent)
        {
            _logger = logger;
            _agent = agent;

        }
        public IActionResult Index()
        {
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

        public IActionResult SendMessage([FromBody]string message)
        {
            try
            {
                _agent.SendMessage("User", message);
                return Ok();
            }
            catch
            {
                throw;
            }            
        }
    }
}
