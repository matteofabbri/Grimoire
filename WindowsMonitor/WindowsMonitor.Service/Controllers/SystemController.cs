
using WindowsMonitor.Hardware.Drives.Win32DiskDrives;
using WindowsMonitor.Windows;
using Microsoft.AspNetCore.Mvc;

namespace WindowsMonitor.Service.Controllers
{
    [Produces("application/json")]
    //[Route("system")]
    public class SystemController : Controller
    {
        public IActionResult Index()
        {
            return Json(Win32OperatingSystem.Retrieve());
        }

        public IActionResult Drives()
        {
            return Json(Win32DiskDrive.Retrieve());
        }

        public IActionResult Partitions()
        {
            return Json(Win32DiskPartition.Retrieve());
        }

        public IActionResult Quotas()
        {
            return Json(Win32DiskQuota.Retrieve());
        }
    }
}