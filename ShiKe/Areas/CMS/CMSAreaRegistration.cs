using System.Web.Mvc;

namespace ShiKe.Areas.CMS
{
    public class CMSAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "CMS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "CMS_default2",
                "CMS/{controller}/{action}/{id}",
                new {controller="default", action = "Index", id = UrlParameter.Optional }
                ,new string[] { "ShiKe.Areas.CMS.Controllers" }
            );
        }
    }
}