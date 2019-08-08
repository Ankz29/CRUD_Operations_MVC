using System.Web;
using System.Web.Mvc;

namespace CRUD_Operations_Using_EF
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}