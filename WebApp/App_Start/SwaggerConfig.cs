using System.Web.Http;
using WebActivatorEx;
using WebApp;
using Swashbuckle.Application;
using System.Linq;

[assembly: PreApplicationStartMethod(typeof(SwaggerConfig), "Register")]

namespace WebApp
{
    public class SwaggerConfig
    {
        public static void Register()
        {
            var thisAssembly = typeof(SwaggerConfig).Assembly;

            GlobalConfiguration.Configuration
                .EnableSwagger(c =>
                    {
                        c.SingleApiVersion("v1", "Ingenya APIs");
                        c.IncludeXmlComments(string.Format(@"{0}\bin\WebApp.xml1"
                            , System.AppDomain.CurrentDomain.BaseDirectory));
                        c.SingleApiVersion("v1", "Ingenya API")
                          .Description("APIs para la aplicacion Ingenya V1")
                          .TermsOfService("Some terms")
                          //.Contact(cc => cc
                          //.Name("Jesus Angulo")
                          //.Url("https://somostechies.com/contact")
                          //.Email("jesus.angulo@outlook.com"))
                          .License(lc => lc
                          .Name("Ingenya Site")
                          .Url("https://ingenyaconsultores.com/"));
                    });
                //.EnableSwaggerUi(c =>
                //{
                //    c.InjectStylesheet(thisAssembly, "/swagger-custom/swagger-custom-styles.css");
                //});
                  

        }
    }
}
