using Microsoft.AspNetCore.Mvc;

namespace client
{
    public class PlayerController : Controller
    {
        public IActionResult Index() => View();
    }
}
