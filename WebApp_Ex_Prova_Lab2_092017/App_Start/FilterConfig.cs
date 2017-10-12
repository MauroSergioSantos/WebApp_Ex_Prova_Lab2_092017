using System.Web;
using System.Web.Mvc;

namespace WebApp_Ex_Prova_Lab2_092017
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
