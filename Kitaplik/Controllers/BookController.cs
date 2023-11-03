using Microsoft.AspNetCore.Mvc;

namespace Kitaplik.Controllers;

public class BookController : Controller
{
    public IActionResult Index()
    {
        return View();
    }

    public IActionResult Create()
    {
        return View();
    }

}
