#pragma checksum "C:\mimar\Mimar\Mimar\Views\HizmetKategori\KategoriGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bf194a60b92011cc8e6d97936c96f413566004db"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HizmetKategori_KategoriGetir), @"mvc.1.0.view", @"/Views/HizmetKategori/KategoriGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf194a60b92011cc8e6d97936c96f413566004db", @"/Views/HizmetKategori/KategoriGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1fcd352491da15f247e4d3ab25f14f1c2d73868", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_HizmetKategori_KategoriGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mimar.Models.Siniflar.HizmetKategori>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\KategoriGetir.cshtml"
  
    ViewBag.Title = "KategoriGetir";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n\r\n<h2>Kategori Güncelleme</h2>\r\n<br />\r\n");
#nullable restore
#line 11 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\KategoriGetir.cshtml"
 using (Html.BeginForm("KategoriGüncelle", "HizmetKategori", FormMethod.Post))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 14 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\KategoriGetir.cshtml"
   Write(Html.LabelFor(x=>x.KategoriAd));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 15 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\KategoriGetir.cshtml"
   Write(Html.TextBoxFor(x=>x.KategoriAd, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 16 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\KategoriGetir.cshtml"
   Write(Html.HiddenFor(x=>x.KategoriID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <button class=\"btn btn-warning \">Güncelle</button>\r\n");
#nullable restore
#line 20 "C:\mimar\Mimar\Mimar\Views\HizmetKategori\KategoriGetir.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mimar.Models.Siniflar.HizmetKategori> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
