using System.Web;
using System.Web.Mvc;

namespace OpenTelemetry.DotNet.Example.DocumentService
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
