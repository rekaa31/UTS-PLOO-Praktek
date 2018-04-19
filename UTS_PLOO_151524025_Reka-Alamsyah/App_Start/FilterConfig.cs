using System.Web;
using System.Web.Mvc;

namespace UTS_PLOO_151524025_Reka_Alamsyah
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
