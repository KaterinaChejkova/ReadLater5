#pragma checksum "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\Bookmark\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7f8ed31f298310503d5fab2eb123c1d00e2644ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bookmark_Details), @"mvc.1.0.view", @"/Views/Bookmark/Details.cshtml")]
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
#line 1 "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\_ViewImports.cshtml"
using ReadLater5;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\_ViewImports.cshtml"
using ReadLater5.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7f8ed31f298310503d5fab2eb123c1d00e2644ba", @"/Views/Bookmark/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"08faceac1ab979c2b859ec9d950e1ab3b3da99e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Bookmark_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Entity.Bookmark>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\Bookmark\Details.cshtml"
  
    ViewBag.Title = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2>Details</h2>\r\n\r\n<div>\r\n    <h4>Bookmark</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
#nullable restore
#line 14 "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\Bookmark\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n\r\n        <dd>\r\n            ");
#nullable restore
#line 18 "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\Bookmark\Details.cshtml"
       Write(Html.DisplayFor(model => model.ShortDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n\r\n    </dl>\r\n</div>\r\n<p>\r\n    ");
#nullable restore
#line 24 "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\Bookmark\Details.cshtml"
Write(Html.ActionLink("Edit", "Edit", new { id = Model.ID }));

#line default
#line hidden
#nullable disable
            WriteLiteral(" |\r\n    ");
#nullable restore
#line 25 "C:\data\ReadLater5\ReadLater5\ReadLater5\ReadLater5\Views\Bookmark\Details.cshtml"
Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</p>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Entity.Bookmark> Html { get; private set; }
    }
}
#pragma warning restore 1591
