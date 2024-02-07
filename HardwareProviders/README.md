# Hardware Providers

Collection of libraries to explore hardware installed on the machine and relative parameters, including: clock, voltages and temperatures.
For Dotnet Standard and 4.6

| Component        | Purpose  |  Standard  | .Net 4.6      |
| ------------- | ------------- | ------------- | ------------- |
| HardwareProviders  | Contains base classes and interface to read and write directly on pc ports  | ✓  | ✓
| HardwareProviders.CPU  | Retrieves Intel and AMD processors installed and relative values | ✓  | ✓
| HardwareProviders.HDD | Retrieves hard drives and relative values   | ✓  | ✓

This project contains code extracted from [Open Hardware Monitor](https://github.com/openhardwaremonitor) and is released under the same  [license](https://github.com/matteofabbri/HardwareProviders/blob/master/LICENSE)


## CPU library Usage
Retrieving information about the current state of CPUs is incredibly simple.

TROUBLESHOOTING:
Depending on Windows version you may need to run it as administrator to retrieve all values.



```csharp

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
```
