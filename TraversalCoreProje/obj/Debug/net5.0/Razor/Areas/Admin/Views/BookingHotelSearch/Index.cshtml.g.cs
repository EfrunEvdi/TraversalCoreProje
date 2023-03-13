#pragma checksum "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d55f90b2af9bb9e3444d2ecfc2c305619e55c191"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_BookingHotelSearch_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/BookingHotelSearch/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d55f90b2af9bb9e3444d2ecfc2c305619e55c191", @"/Areas/Admin/Views/BookingHotelSearch/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557af1f7dd1ff1b949b6911b8808842c1273542d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_BookingHotelSearch_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<BookingHotelSearchViewModel.Result>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";
    int count = 0;
    double score;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<div class=""card"">
    <h5 class=""card-header"">Booking Hotel Rezarvasyon Sayfası (APİ)  </h5>
    <h6 class=""card-header text-danger"">Arama Yapılan Şehir : Paris / Fransa</h6>
    <div class=""table-responsive text-nowrap"">
        <table class=""table table-hover text-center"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>HOTEL ADI</th>
                    <th>HOTEL PUANI</th>
                    <th>HOTEL DEĞERLENDİRMESİ</th>
                    <th>DETAYLAR</th>
                </tr>
            </thead>

            <tbody class=""table-border-bottom-0 text-center"">
");
#nullable restore
#line 27 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                 foreach (var item in Model)
                {
                    count++;

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                       Write(count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><i class=\"fab fa-angular fa-lg text-danger me-3\"></i> <strong>");
#nullable restore
#line 32 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                                                                                     Write(item.hotel_name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n");
#nullable restore
#line 33 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                          
                            score = double.Parse(item.review_score.ToString()) / 10;
                        

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <td>");
#nullable restore
#line 36 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                       Write(score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 37 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                       Write(item.review_score_word);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1388, "\"", 1404, 1);
#nullable restore
#line 38 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
WriteAttributeValue("", 1395, item.url, 1395, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\" target=\"_blank\"><i class=\'bx bx-detail\'> Detaylar</i></a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 40 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\BookingHotelSearch\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<BookingHotelSearchViewModel.Result>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
