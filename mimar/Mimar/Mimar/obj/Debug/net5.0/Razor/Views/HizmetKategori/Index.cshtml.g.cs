#pragma checksum "C:\mimar\Mimar\Mimar\Views\HizmetKategori\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "befb1f9c5e0e6d73e30048d7d58e8b794db232e1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HizmetKategori_Index), @"mvc.1.0.view", @"/Views/HizmetKategori/Index.cshtml")]
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
#line 1 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\Index.cshtml"
using Mimar.Models.Siniflar;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"befb1f9c5e0e6d73e30048d7d58e8b794db232e1", @"/Views/HizmetKategori/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1fcd352491da15f247e4d3ab25f14f1c2d73868", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HizmetKategori_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<HizmetKategori>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-bordered\" style=\"margin-top:20px\">\r\n    <tr>\r\n      \r\n        <th>\r\n            Kategori Ad??\r\n        </th>\r\n        \r\n\r\n    </tr>\r\n");
#nullable restore
#line 17 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\Index.cshtml"
    foreach (var k in Model)
    {
        
    


#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n \r\n        <td>\r\n          ");
#nullable restore
#line 25 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\Index.cshtml"
     Write(k.KategoriAd);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        </td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 447, "\"", 495, 2);
            WriteAttributeValue("", 454, "/HizmetKategori/KategoriSil/", 454, 28, true);
#nullable restore
#line 28 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\Index.cshtml"
WriteAttributeValue("", 482, k.KategoriID, 482, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Sil</a></td>\r\n        <td><a");
            BeginWriteAttribute("href", " href=\"", 548, "\"", 622, 1);
#nullable restore
#line 29 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\Index.cshtml"
WriteAttributeValue("", 555, Url.Action("KategoriGetir","HizmetKategori",new {id=k.KategoriID}), 555, 67, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">G??ncelle</a></td>\r\n    </tr>\r\n");
#nullable restore
#line 31 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n<a href=\"/HizmetKategori/KategoriEkle\" class=\"btn btn-primary\">Kategori Ekle</a>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<HizmetKategori>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
