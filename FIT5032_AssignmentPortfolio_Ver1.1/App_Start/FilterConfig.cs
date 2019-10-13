using System.Web;
using System.Web.Mvc;

namespace FIT5032_AssignmentPortfolio_Ver1._1
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
