#pragma checksum "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "63160e75e337043ac102b4b7a4c6393928fa5f8b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Member_Views_Reservation_MyApprovalReservation), @"mvc.1.0.view", @"/Areas/Member/Views/Reservation/MyApprovalReservation.cshtml")]
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
#line 1 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProje;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\_ViewImports.cshtml"
using TraversalCoreProje.Areas.Member.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"63160e75e337043ac102b4b7a4c6393928fa5f8b", @"/Areas/Member/Views/Reservation/MyApprovalReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32ec19881daa9c406a3e822741c8d3bb751aacdf", @"/Areas/Member/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Member_Views_Reservation_MyApprovalReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Reservation>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
  
    ViewData["Title"] = "MyApprovalReservation";
    Layout = "~/Views/Shared/_UserLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 9 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h4>Hiç onay bekleyen rezervasyonunuz bulunmamaktadır.</h4>\r\n");
#nullable restore
#line 12 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <div class=""container-fluid py-4"">
        <div class=""row"">
            <div class=""col-12"">
                <div class=""card mb-4"">
                    <div class=""card-header pb-0"">
                        <h6>Onay Bekleyen Rezervasyonlarım</h6>
                    </div>
                    <div class=""card-body px-0 pt-0 pb-2   m-3"">
                        <div class=""table-responsive p-0 text-center"">
                            <table class=""table align-items-center justify-content-center mb-0"">
                                <thead>
                                    <tr>
                                        <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7"">#</th>
                                        <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Lokasyon</th>
                                        <th class=""text-uppercase text-secondary text-xxs font-weight-bolder opacity-7 ps-2"">Kişi Sayısı</th>
       ");
            WriteLiteral(@"                                 <th class=""text-uppercase text-secondary text-xxs font-weight-bolder text-center opacity-7 ps-2"">Rezervasyon Tarihi</th>
                                        <th class=""text-uppercase text-secondary text-xxs font-weight-bolder text-center opacity-7 ps-2"">Durum</th>
                                    </tr>
                                </thead>
                                <tbody>
");
#nullable restore
#line 35 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                     foreach (var item in Model)
                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                        <tr>\r\n                                            <td>\r\n                                                <div");
            BeginWriteAttribute("class", " class=\"", 1978, "\"", 1986, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                    <div>\r\n                                                        <img");
            BeginWriteAttribute("src", " src=\"", 2109, "\"", 2138, 1);
#nullable restore
#line 41 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
WriteAttributeValue("", 2115, item.Destination.Image, 2115, 23, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"avatar avatar-sm rounded-circle me-2\" alt=\"spotify\">\r\n                                                    </div>\r\n");
            WriteLiteral("                                                </div>\r\n                                            </td>\r\n                                            <td>\r\n                                                <p class=\"text-sm font-weight-bold mb-0\">");
#nullable restore
#line 49 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                                                                    Write(item.Destination.City);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                            </td>\r\n                                            <td>\r\n                                                <span class=\"text-xs font-weight-bold\">");
#nullable restore
#line 52 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                                                                  Write(item.PersonCount);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td>\r\n                                                <span class=\"text-xs font-weight-bold\">");
#nullable restore
#line 55 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                                                                   Write(((DateTime)item.ReservationDate).ToString("dd-MMM-yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                            <td>\r\n                                                <span class=\"text-xs font-weight-bold\">");
#nullable restore
#line 58 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                                                                  Write(item.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                            </td>\r\n                                        </tr>\r\n");
#nullable restore
#line 61 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                </tbody>\r\n                            </table>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 70 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Member\Views\Reservation\MyApprovalReservation.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Reservation>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591