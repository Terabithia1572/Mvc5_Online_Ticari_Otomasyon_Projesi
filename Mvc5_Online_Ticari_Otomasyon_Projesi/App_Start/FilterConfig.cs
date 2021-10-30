using System.Web;
using System.Web.Mvc;

namespace Mvc5_Online_Ticari_Otomasyon_Projesi
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
