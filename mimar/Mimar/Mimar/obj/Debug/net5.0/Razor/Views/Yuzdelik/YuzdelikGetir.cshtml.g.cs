#pragma checksum "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fb76d33f3aaeb1317aec881cd5daf4acac1c6e74"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Yuzdelik_YuzdelikGetir), @"mvc.1.0.view", @"/Views/Yuzdelik/YuzdelikGetir.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb76d33f3aaeb1317aec881cd5daf4acac1c6e74", @"/Views/Yuzdelik/YuzdelikGetir.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1fcd352491da15f247e4d3ab25f14f1c2d73868", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Yuzdelik_YuzdelikGetir : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Mimar.Models.Siniflar.Anasayfa>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
  
    ViewBag.Title = "YuzdelikGetir";
    Layout = "~/Views/Shared/AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<br />\r\n<h2>Hizmet Güncelleme Ekranı</h2>\r\n<br />\r\n");
#nullable restore
#line 10 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
 using (Html.BeginForm("YuzdelikGüncelle", "Yuzdelik", FormMethod.Post, new { enctype = "multipart/form-data" }))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"form-group\">\r\n    ");
#nullable restore
#line 13 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.HiddenFor(x => x.AnaID));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 14 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Yuzde1Oran));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 15 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yuzde1Oran, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br />\r\n     ");
#nullable restore
#line 17 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Yuzde1Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 18 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yuzde1Baslik, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n     ");
#nullable restore
#line 20 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Yuzde1Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 21 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yuzde1Aciklama, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n     ");
#nullable restore
#line 23 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Yuzde2Oran));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 24 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yuzde2Oran, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n   \r\n    <br />\r\n    ");
#nullable restore
#line 27 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Yuzde2Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 28 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yuzde2Baslik, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    ");
#nullable restore
#line 30 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Yuzde2Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 31 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yuzde2Aciklama, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    ");
#nullable restore
#line 33 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Yuzde3Oran));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 34 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yuzde3Oran, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    ");
#nullable restore
#line 36 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Yuzde3Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 37 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yuzde3Baslik, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    ");
#nullable restore
#line 39 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Asama3Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 40 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yuzde3Aciklama, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n   ");
#nullable restore
#line 42 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Yuzde4Oran));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 43 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yuzde4Oran, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    ");
#nullable restore
#line 45 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Yde4Baslik));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 46 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yde4Baslik, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    ");
#nullable restore
#line 48 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.LabelFor(x => x.Yuzde4Aciklama));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    ");
#nullable restore
#line 49 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
Write(Html.TextBoxFor(x => x.Yuzde4Aciklama, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <br/>\r\n    <button class=\"btn btn-default\" style=\"background-color:yellowgreen\">Güncelle</button>\r\n\r\n</div>\r\n");
#nullable restore
#line 54 "C:\mimar\Mimar\Mimar\Views\Yuzdelik\YuzdelikGetir.cshtml"
}

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Mimar.Models.Siniflar.Anasayfa> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591