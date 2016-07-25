using Autofac;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Web.Http;

namespace Bootstrap_Libraries.App_Start
{
    class Bootstrapper
    {
        private static void SetAutofac()
        {
            var configuration = GlobalConfiguration.Configuration;
            var builder = new ContainerBuilder();
          
        }

    }
}
