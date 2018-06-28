using System.Web.Mvc;

namespace ShiKe.Areas.Web
{
    public class WebAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "Web";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "Web_default2",
                "Web/{controller}/{action}/{id}",
                new { controller = "default", action = "Index", id = UrlParameter.Optional }
                , new string[] { "ShiKe.Areas.Web.Controllers" }
            );
        }
    }
}