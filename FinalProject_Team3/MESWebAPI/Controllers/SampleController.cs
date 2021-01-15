using log4net;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace MESWebAPI.Controllers
{
    public class SampleController : ApiController
    {
        ILog log = log4net.LogManager.GetLogger(typeof(SampleController));

        public string GetSampleAPI()
        {
            log.Debug("GetSampleAPI 호출");
            return "GetSampleAPI 호출";
        }
    }
}
