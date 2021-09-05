using System.Web.Mvc;

namespace Murugi_25July.Areas.USERS
{
    public class USERSAreaRegistration : AreaRegistration 
    {
        public override string AreaName 
        {
            get 
            {
                return "USERS";
            }
        }

        public override void RegisterArea(AreaRegistrationContext context) 
        {
            context.MapRoute(
                "USERS_default",
                "USERS/{controller}/{action}/{id}",
                new { action = "Index", id = UrlParameter.Optional }
            );
        }
    }
}