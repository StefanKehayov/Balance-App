#pragma checksum "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "49301f49dadd0191b6644e0b8f809db7d3c28891"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Balance_Edit), @"mvc.1.0.view", @"/Views/Balance/Edit.cshtml")]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"49301f49dadd0191b6644e0b8f809db7d3c28891", @"/Views/Balance/Edit.cshtml")]
    public class Views_Balance_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Balance_App.ViewModels.Balances.EditVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Edit.cshtml"
  
    Layout = "/Views/Shared/_Layout.cshtml";
    ViewBag.Title = "Edit Contact";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"status\">\r\n    <h1>Edit Balance</h1>\r\n\r\n\r\n</div>\r\n\r\n   \r\n    <form action=\"/Balance/Edit\" method=\"post\">\r\n        ");
#nullable restore
#line 15 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Edit.cshtml"
   Write(Html.HiddenFor(m => m.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Edit.cshtml"
   Write(Html.HiddenFor(m => m.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        <div class=\"grid\">\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">Name or type of your balance:</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 20 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Edit.cshtml"
                              Write(Html.TextBoxFor(m => m.NameOrType, new { @class = "form", placeholder = "Enter your balance type..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 21 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Edit.cshtml"
                              Write(Html.ValidationMessageFor(m => m.NameOrType));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">Expiration date:</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 25 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Edit.cshtml"
                              Write(Html.TextBoxFor(m => m.ExDate, new { @class = "form", placeholder = "Enter your expiration date..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 26 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Edit.cshtml"
                              Write(Html.ValidationMessageFor(m => m.ExDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n            </div>\r\n            <div class=\"row\">\r\n                <div class=\"col-1\">Balance Amount:</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 30 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Edit.cshtml"
                              Write(Html.TextBoxFor(m => m.BalanceAmount, new { @class = "form", placeholder = "Enter your balance amount..." }));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n                <div class=\"col-2\">");
#nullable restore
#line 31 "\\Mac\Home\Desktop\Balance-App\Balance-App\Views\Balance\Edit.cshtml"
                              Write(Html.ValidationMessageFor(m => m.BalanceAmount));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
            </div>
            <div class=""flex-rows"">
                
                    <input class=""SubmitButton"" type=""submit"" value=""Save"" />
                    <a class=""Buttoncheta"" href=""/Balance/Index"">Back</a>
                
            </div>
        </div>
    </form>
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Balance_App.ViewModels.Balances.EditVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
