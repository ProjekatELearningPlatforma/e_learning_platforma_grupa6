#pragma checksum "C:\Users\backo\Desktop\gitTest\Views\Manage\DisplayRecoveryCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5910958d1599b313971b9c690c60275a36d95855"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Manage_DisplayRecoveryCodes), @"mvc.1.0.view", @"/Views/Manage/DisplayRecoveryCodes.cshtml")]
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
#nullable restore
#line 1 "C:\Users\backo\Desktop\gitTest\Views\_ViewImports.cshtml"
using E_Learning_Platforma;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\backo\Desktop\gitTest\Views\_ViewImports.cshtml"
using E_Learning_Platforma.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\backo\Desktop\gitTest\Views\_ViewImports.cshtml"
using E_Learning_Platforma.Models.AccountViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\backo\Desktop\gitTest\Views\_ViewImports.cshtml"
using E_Learning_Platforma.Models.ManageViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\backo\Desktop\gitTest\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5910958d1599b313971b9c690c60275a36d95855", @"/Views/Manage/DisplayRecoveryCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"65c0955512a4c924f5a87bc199707b40a17e1451", @"/Views/_ViewImports.cshtml")]
    public class Views_Manage_DisplayRecoveryCodes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<E_Learning_Platforma.Models.ManageViewModels.DisplayRecoveryCodesViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\backo\Desktop\gitTest\Views\Manage\DisplayRecoveryCodes.cshtml"
   ViewData["Title"] = "Your recovery codes:"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>");
#nullable restore
#line 4 "C:\Users\backo\Desktop\gitTest\Views\Manage\DisplayRecoveryCodes.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h2>\r\n<p class=\"text-success\">");
#nullable restore
#line 5 "C:\Users\backo\Desktop\gitTest\Views\Manage\DisplayRecoveryCodes.cshtml"
                   Write(ViewData["StatusMessage"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n\r\n<div>\r\n  <h4>Here are your new recovery codes</h4>\r\n  <hr />\r\n  <dl class=\"dl-horizontal\">\r\n    <dt>Codes:</dt>\r\n");
#nullable restore
#line 12 "C:\Users\backo\Desktop\gitTest\Views\Manage\DisplayRecoveryCodes.cshtml"
     foreach (var code in Model.Codes)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("<dd>\r\n  <text>");
#nullable restore
#line 15 "C:\Users\backo\Desktop\gitTest\Views\Manage\DisplayRecoveryCodes.cshtml"
   Write(code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</text>\r\n</dd>");
#nullable restore
#line 16 "C:\Users\backo\Desktop\gitTest\Views\Manage\DisplayRecoveryCodes.cshtml"
     }

#line default
#line hidden
#nullable disable
            WriteLiteral("  </dl>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<E_Learning_Platforma.Models.ManageViewModels.DisplayRecoveryCodesViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
