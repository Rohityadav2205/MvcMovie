using Microsoft.AspNetCore.Mvc;
using System.Text.Encodings.Web;

namespace MvcMovie.Controllers;

public class HelloWorldController : Controller
{
    public IActionResult Index()
    {
        return View();
    }
    public IActionResult Welcome(string name, int numTimes = 1)
    {
        ViewData["Message"] = "Hello " + name;
        ViewData["NumTimes"] = numTimes;
        return View();
    }

    public IActionResult AddNumber(int num1=0, int num2 = 0)
    {
        int sum = num1 + num2;
        ViewBag.num1 = num1;
        ViewBag.num2 = num2;
        ViewBag.sum = sum;
        return View();
    }
     public IActionResult Sidebar()
    {
        return View();


    }
    public IActionResult Corousel()
    {
        return View();
    }

    public IActionResult InputPage(string name="",string subject= "")
    {
        ViewBag.name = name;
        ViewBag.subject = subject;
        return View();

    }

    


}