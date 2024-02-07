using HardwareProviders.Board;
using HardwareProviders.CPU;
using HardwareProviders.HDD;
using System.Collections.Generic;
using System.Web.Http;

namespace ApiService.Controllers
{
    public class MainController : ApiController
    {
        static Mainboard mainboard = new Mainboard();
        static Cpu[] cpu = Cpu.Discover();
        static HardDrive[] hdd = HardDrive.Discover();

        // GET api/values
        public IEnumerable<Cpu> Get()
        {
            return Cpu.Discover();
        }
    }
}
