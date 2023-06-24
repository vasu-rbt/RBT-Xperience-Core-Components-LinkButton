using CMS;
using Kentico.PageBuilder.Web.Mvc;
using RBT.Xperience.Core.LinkButton;


[assembly: AssemblyDiscoverable]
[assembly: RegisterWidget("RBT.Xperience.Core.LinkButton", 
    typeof(LinkButtonWidgetViewComponent), "Link button",
    typeof(LinkButtonWidgetProperties),
    Description = "Displays a hyperlink to a specified target URL. The link can be rendered in text format.",
    IconClass = "icon-square")]