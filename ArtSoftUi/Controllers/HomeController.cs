using ArtSoftUi.Models;
using ArtSoftUi.ProxyClases;
using ArtSoftUi.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace ArtSoftUi.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IService _service;

        public HomeController(ILogger<HomeController> logger, IService service)
        {
            _logger = logger;
            _service = service;
        }

        public async Task<IActionResult> Index()
        {
            List<Test> list = await _service.GetTests();

            return View(list);
        }

        public async Task<IActionResult> Quiz(int Id)
        {
            List<QuizModel> list = await _service.GetQuiz(Id);

            return View(list);
        }

    }
}