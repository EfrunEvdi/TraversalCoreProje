#pragma checksum "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\City\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2e8821bc961ecdc67eebc5b2b0353f43df5f7816"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_City_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/City/Index.cshtml")]
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
#line 1 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using DTOLayer.DTOs.AnnouncementDTOs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Admin.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2e8821bc961ecdc67eebc5b2b0353f43df5f7816", @"/Areas/Admin/Views/City/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557af1f7dd1ff1b949b6911b8808842c1273542d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_City_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\City\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card table-border-bottom-0 text-center"">
    <h5 class=""card-header"">Şehir Ülke İşlemleri  </h5>
    <div class=""table-responsive text-nowrap"">
        <button type=""button"" id=""cityBtnGetList"" class=""btn btn-outline-primary col-12 btn-lg"">Şehir Listesi</button>
        <hr />
        <div class=""d-flex justify-content-center"">
            <button type=""button"" id=""cityBtnGetByID"" class=""btn btn-outline-info btn-lg me-2"">Şehir Getir</button>
            <button type=""button"" id=""cityBtnAddCity"" class=""btn btn-outline-success btn-lg me-2"">Şehir Ekle</button>
            <button type=""button"" id=""cityBtnUpdateCity"" class=""btn btn-outline-warning btn-lg me-2"">Şehir Güncelle</button>
            <button type=""button"" id=""cityBtnDeleteCity"" class=""btn btn-outline-danger btn-lg"">Şehir Sil</button>
        </div>
        <hr />
    </div>

    <div class=""table-responsive text-nowrap"" id=""citylist"">
    </div>

    <div class=""table-responsive text-nowrap"">
        <input class=""form-");
            WriteLiteral(@"control mb-2""
               type=""text""
               id=""txtid""
               placeholder=""Şehirin ID değeri"" />
    </div>

    <div class=""table-responsive text-nowrap"">
        <input class=""form-control mb-2""
               type=""text""
               id=""txtcityid""
               placeholder=""Silinecek şehirin ID değeri"" />
    </div>

    <div class=""table-responsive text-nowrap"">
        <input class=""form-control mb-2""
               type=""text""
               id=""txtcityeditid""
               placeholder=""Güncellenecek şehirin ID değeri"" />
        <input class=""form-control mb-2""
               type=""text""
               id=""txtcityname""
               placeholder=""Güncellenecek şehirin adı nedir?"" />
        <input class=""form-control mb-2""
               type=""text""
               id=""txtcitydaynight""
               placeholder=""Güncellenecek şehirin gün bilgileri nedir?"" />
    </div>

    <div id=""destinationListByID""></div>

    <div");
            BeginWriteAttribute("class", " class=\"", 2112, "\"", 2120, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <input class=""form-control mb-2""
               type=""text""
               id=""txtcity""
               placeholder=""Şehirin adı nedir?"" />
        <input class=""form-control mb-2""
               type=""text""
               id=""txtdaynight""
               placeholder=""Kalınacak Gece / Gün sayısı ?"" />
        <input class=""form-control mb-2""
               type=""text""
               id=""txtprice""
               placeholder=""Bu rotanın fiyatı ne kadar?"" />
        <input class=""form-control mb-2""
               type=""text""
               id=""txtcapacity""
               placeholder=""Konaklayacak kişi kapasitesi kaçtır?"" />
    </div>
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
