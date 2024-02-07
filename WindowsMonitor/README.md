# WindowsMonitor

Fully manged wrapper for WMI ( Windows Management Instrumentation ) namespaces and classes.
Useful to retrieve informations abou software and hardware installed on local and remote machine.

     //Retrieve voltage information from local probes
     var probes = VoltageProbe.Retrieve();
       
     foreach (var probe in probes)
     {
         Console.WriteLine($"{probe.Name} {probe.CurrentReading}");
     }
    
     //Retrieve voltage information from probes on remote machine
     var probes = VoltageProbe.Retrieve("remote host", "username", "password");
       
     foreach (var probe in probes)
     {
         Console.WriteLine($"{probe.Name} {probe.CurrentReading}");
     }
     
