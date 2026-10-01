using System.Diagnostics;
using Microsoft.AspNetCore.Mvc;
using WebApplication1.Models;

namespace WebApplication1.Controllers;

public class HomeController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Privacy()
    {
        return View();
    }

    public IActionResult TeemerProfile()
    {
        TeemerInfo myInfo = new TeemerInfo();

        myInfo.Name = "Tyrone Louis V. Teemer";
        myInfo.Age = 19;
        myInfo.Program = "Conputer Science";
        myInfo.School = "Polytechnic University of the Philippines";
        return View(myInfo);
    }

    [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
    public IActionResult Error()
    {
        return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
    }
}
