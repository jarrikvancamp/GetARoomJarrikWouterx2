using System.Web;
using System.Web.Mvc;

namespace GetARoom.UI.Web.Administration
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
