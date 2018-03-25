using System.Threading.Tasks;
using microCommerce.Mvc.UI;
using Microsoft.AspNetCore.Mvc;

namespace microCommerce.Web.ViewComponents
{
    public class FooterComponent : BaseComponent
    {
        public IViewComponentResult Invoke()
        {
            return View();
        }
    }
}