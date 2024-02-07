using System.Net.Http.Headers;
using System.Web.Http;
using System.Web.Mvc;

namespace ApiService
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        public static void RegisterWebApi(HttpConfiguration config)
        {
            // Web API configuration and services

            // Web API routes
            config.MapHttpAttributeRoutes();

            config.Routes.MapHttpRoute(
                name: "DefaultApi",
                routeTemplate: "{controller}",
                defaults: new { controller = "Main", action = "Get" }
            );

            config.Formatters.JsonFormatter.SupportedMediaTypes.Add(new MediaTypeHeaderValue("text/html"));
        }

        protected void Application_Start()
        {
            AreaRegistration.RegisterAllAreas();
            GlobalConfiguration.Configure(RegisterWebApi);
        }
    }
}
