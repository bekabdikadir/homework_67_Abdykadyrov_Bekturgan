using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using les70.Models;
using WebApplication3;
using WebApplication3.Models;

namespace les70.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        ViewData["Message"] = "Добрый день, это тестовый текст на главной странице";
        var model = new IndexViewModel
        {
            Rows = new List<string>(),
            PageTitle = "Главная",
            Page = 1
        };
        ViewResult result = View("Main", model);
        result.StatusCode = 200;
        return result;
    }

    public IActionResult Privacy()
    {
        ViewData["Policy"] = "Текст политики конфидециальности сайта.";
        return View("Privacy");
    }

    public IActionResult TestPage(int page)
    {
        ViewBag.PageIncrement = ++page;
        return View(new TestPageViewModel{Page = page});
    }
}
