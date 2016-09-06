using System.Web;
using System.Web.Mvc;

namespace GetARoom.UI.web.main
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
