
using HardwareProviders;
using HardwareProviders.Board;
using HardwareProviders.CPU;
using HardwareProviders.HDD;
using System;
using System.Linq;

namespace TestApp
{
    class Program
    {
        static void Print(Sensor[] sensors)
        {
            if(sensors.Any())
            Console.WriteLine(string.Join(" ", sensors.Select(x => x.ToString())));
        }

        static void Main(string[] args)
        {
            var mainboard = new Mainboard();
            Console.WriteLine(mainboard.Smbios.BIOS.Vendor);

            var cpu = Cpu.Discover();

            foreach (var item in cpu)
            {
                Print(item.CoreTemperatures);
                Print(item.CoreClocks);
                Print(item.CorePowers);
                Print(item.CoreVoltages);
                Print(item.CoreClocks);
            }

            var hdd = HardDrive.Discover();

            foreach (var item in hdd)
            {
                foreach(var smart in item.SmartSensors)
                {
                    Console.WriteLine(smart.Key.Name);
                    Print(new[]{ smart.Value });
                }
            }
            Console.ReadKey();
        }
    }
}
