using System.Web.Mvc;

namespace Murugi_25July.Areas.AMBULANCES
{
    public class AMBULANCESAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "AMBULANCES";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "AMBULANCES_default",
                "AMBULANCES/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}