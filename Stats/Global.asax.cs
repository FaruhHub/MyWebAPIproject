using System.Web;
using System.Web.Http;
using Stats.App_Start;

namespace Stats {
    public class WebApiApplication : HttpApplication {
        protected void Application_Start( ) {
            GlobalConfiguration.Configure( WebApiConfig.Register );
        }
    }
}