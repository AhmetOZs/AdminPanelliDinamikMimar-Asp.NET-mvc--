#pragma checksum "C:\mimar\Mimar\Mimar\Views\BüyükResimGün\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ab0a67d92597e9fd9c70f34c4198851c3775842"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BüyükResimGün_Index), @"mvc.1.0.view", @"/Views/BüyükResimGün/Index.cshtml")]
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
#line 1 "C:\mimar\Mimar\Mimar\Views\_ViewImports.cshtml"
using Mimar;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\mimar\Mimar\Mimar\Views\_ViewImports.cshtml"
using Mimar.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\mimar\Mimar\Mimar\Views\BüyükResimGün\Index.cshtml"
using Mimar.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ab0a67d92597e9fd9c70f34c4198851c3775842", @"/Views/BüyükResimGün/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1fcd352491da15f247e4d3ab25f14f1c2d73868", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_BüyükResimGün_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Anasayfa>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\mimar\Mimar\Mimar\Views\BüyükResimGün\Index.cshtml"
  
    ViewBag.Title = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\" style=\"margin-top:20px\">\r\n    <tr>\r\n        <th>Büyük Resim</th>\r\n        <th>Büyük Resim Sol Yazi</th>\r\n        <th>Büyük Resim Baslik</th>\r\n        \r\n\r\n    </tr>\r\n");
#nullable restore
#line 16 "C:\mimar\Mimar\Mimar\Views\BüyükResimGün\Index.cshtml"
     foreach (var k in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td> <img");
            BeginWriteAttribute("src", " src=\"", 419, "\"", 438, 1);
#nullable restore
#line 20 "C:\mimar\Mimar\Mimar\Views\BüyükResimGün\Index.cshtml"
WriteAttributeValue("", 425, k.BüyükResim, 425, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px; height:80px;\"/></td>\r\n           \r\n            <td> ");
#nullable restore
#line 22 "C:\mimar\Mimar\Mimar\Views\BüyükResimGün\Index.cshtml"
            Write(k.BüyükResimSolYazi);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td> ");
#nullable restore
#line 23 "C:\mimar\Mimar\Mimar\Views\BüyükResimGün\Index.cshtml"
            Write(k.BüyükResimBaslik);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            \r\n           \r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 623, "\"", 696, 1);
#nullable restore
#line 26 "C:\mimar\Mimar\Mimar\Views\BüyükResimGün\Index.cshtml"
WriteAttributeValue("", 630, Url.Action("BüyükResimGünGetir","BüyükResimGün",new {id=k.AnaID}), 630, 66, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Güncelle</a></td>\r\n          </tr>\r\n");
#nullable restore
#line 28 "C:\mimar\Mimar\Mimar\Views\BüyükResimGün\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n\r\n\r\n<img src=\"/images/bg/büyükresimklavuz.png\" />");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Anasayfa>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
