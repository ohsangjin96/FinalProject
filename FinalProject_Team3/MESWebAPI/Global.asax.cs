using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Configuration;
using System.Web.Http;
using System.Web.Routing;

namespace MESWebAPI
{
    public class WebApiApplication : System.Web.HttpApplication
    {
        protected void Application_Start()
        {
            GlobalConfiguration.Configure(WebApiConfig.Register);

            string strConn = WebConfigurationManager.ConnectionStrings["FpDB"].ConnectionString;

            EncrytLibrary.AES aes = new EncrytLibrary.AES();
            strConn = aes.AESDecrypt256(strConn);
        }
    }
}
