# Workday.WebServices
## 29 client to interact with Workday API


Making Visual Studio processing correctly Workday WSDL is a real pain.

Fortunately Ben Martin has did this job and made it availbale for the rest of world.

Sadly, his library is so omnicomprensive that the binary is 25MB and only for .Net Framework 4.6

So, I splitted it into different DotNet Standard dll that can be referenced separately


## How to use

```csharp
using System.ServiceModel;
using WorkdayWebServices.Human_ResourcesService;

namespace WWS_tester
{
    class Program
    {
        static void Main(string[] args)
        {
            Human_ResourcesPortClient hr = new Human_ResourcesPortClient();
            hr.Endpoint.Address = new EndpointAddress("https://wd2-impl-services1.workday.com/ccx/service/{TENANT_NAME_HERE}/Human_Resources/v28.1");

            //Specify the username and password for WS-Security UsernameToken Header
            hr.ClientCredentials.UserName.UserName = "lmcneil@{TENANT_NAME_HERE}";   //put a working username with credentials here.  include the @tenant, replace {TENANT_NAME_HERE} with tenant, no curly brackets
            hr.ClientCredentials.UserName.Password = "validPassword";         //put a working password here

            //Instantiate Header for the request
            Workday_Common_HeaderType header = new Workday_Common_HeaderType();
            //Fill the Workday header at your wish (omitted for code clarity)
            FillHeader(header);

            //Setting up request criteria to use Country
            Get_Workers_RequestType request = new Get_Workers_RequestType();
            //Fill the Workday request at your wish (omitted for code clarity)
            FillRequest(request);

            //Invoke HR getworker api via Proxy
            var workers = hr.Get_Workers(header, request);
        }
    }
}
```
