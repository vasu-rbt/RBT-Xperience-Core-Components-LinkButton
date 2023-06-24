using Kentico.PageBuilder.Web.Mvc;
using Microsoft.AspNetCore.Mvc;


namespace RBT.Xperience.Core.LinkButton
{
    public class LinkButtonWidgetViewComponent :ViewComponent
    {
        public IViewComponentResult Invoke(ComponentViewModel<LinkButtonWidgetProperties> componentViewModel)
        {
            var properties=componentViewModel?.Properties;
            var model = new LinkButtonWidgetViewModel()
            {
                LinkText = properties.LinkText,
                LinkTextColor=properties.LinkTextColor,
                LinkBGColor=properties.LinkBGColor,
                LinkCSSClass = properties.LinkCSSClass,
                LinkURL = properties.LinkURL,
                LinkTarget = properties.LinkTarget
            };
            return View("~/Components/Widgets/LinkButtonWidget/_LinkButtonWidget.cshtml", model);
        }

    }
}
