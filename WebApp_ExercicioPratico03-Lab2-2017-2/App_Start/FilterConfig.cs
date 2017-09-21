using System.Web;
using System.Web.Mvc;

namespace WebApp_ExercicioPratico03_Lab2_2017_2
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
