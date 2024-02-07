using WindowsMonitor.Windows;
using Microsoft.AspNetCore.Mvc;

namespace WindowsMonitor.Service.Controllers
{
    [Produces("application/json")]
    public class HardwareController : Controller
    {
        public IActionResult Index()
        {
            return Json(Win32OperatingSystem.Retrieve());
        }
    }
}