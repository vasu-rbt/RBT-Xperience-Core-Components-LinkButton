using Kentico.Components.Web.Mvc.FormComponents;
using Kentico.Forms.Web.Mvc;
using Kentico.PageBuilder.Web.Mvc;
using Microsoft.SqlServer.Dac.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Reflection.Emit;
using System.Text;

namespace RBT.Xperience.Core.LinkButton
{
    public class LinkButtonWidgetProperties : IWidgetProperties
    {
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 1, Label = "Linkbutton text")]
        public string LinkText { get; set; }
        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 2, Label = "Linkbutton text color")]
        public string LinkTextColor { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 3, Label = "Linkbutton BG color")]
        public string LinkBGColor { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 4, Label = "Linkbutton CSS class")]
        public string LinkCSSClass { get; set; }

        [EditingComponent(TextInputComponent.IDENTIFIER, Order = 5, Label = "Linkbutton URL")]
        public string LinkURL { get; set; }

        [EditingComponentProperty(nameof(DropDownProperties.DataSource), "_self;Self\r\n_blank;Blank\r\n")]
        [EditingComponent(DropDownComponent.IDENTIFIER, Order = 6, Label = "Linkbutton target")]
        public string LinkTarget { get; set; }
        
    }
}
