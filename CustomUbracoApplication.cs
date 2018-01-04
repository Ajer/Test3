using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Web.Routing;
using Umbraco.Core;
using Umbraco.Web;

namespace TestUmbraco
{
    public class CustomUbracoApplication:UmbracoApplication
    {
        protected override IBootManager GetBootManager()
        {
            return new CustomWebBootManager(this);
        }


    }


    public class CustomWebBootManager:WebBootManager
    {

        public CustomWebBootManager(UmbracoApplicationBase cua):base(cua)
        {

        }

        public override IBootManager Complete(Action<ApplicationContext> afterComplete)
        {
            RouteTable.Routes.MapRoute(
                "HomePage",
                "home/index",
                new {controller = "Home", action = "Index"}
            );
            return base.Complete(afterComplete);
        }
    } 
}