using Microsoft.AspNetCore.Mvc;

namespace ryvex_pdv.Controllers;

public class AuthController : Controller
{
    public IActionResult Login()
    {
        return View();
    }
}
