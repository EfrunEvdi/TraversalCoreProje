#pragma checksum "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7f4f78aaa2d18a99c17c2b759b2612015da773a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_ApiMovie_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/ApiMovie/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7f4f78aaa2d18a99c17c2b759b2612015da773a", @"/Areas/Admin/Views/ApiMovie/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"557af1f7dd1ff1b949b6911b8808842c1273542d", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_ApiMovie_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<ApiMovieViewModel>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <h5 class=""card-header"">İMDB Top 100 Film Listesi (APİ)  </h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table table-hover text-center"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>FİLM GÖRSELİ</th>
                    <th>FİLM ADI</th>
                    <th>İMDB PUANI</th>
                    <th>YAPIM YILI</th>
                    <th>FRAGMAN</th>
                </tr>
            </thead>

            <tbody class=""table-border-bottom-0 text-center"">
");
#nullable restore
#line 24 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
                       Write(item.rank);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><img");
            BeginWriteAttribute("src", " src=\"", 875, "\"", 892, 1);
#nullable restore
#line 28 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
WriteAttributeValue("", 881, item.image, 881, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Avatar\" class=\"rounded-circle avatar avatar-s pull-up\" /></td>\r\n\r\n                        <td><i class=\"fab fa-angular fa-lg text-danger me-3\"></i> <strong>");
#nullable restore
#line 30 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
                                                                                     Write(item.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                        <td>");
#nullable restore
#line 31 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
                       Write(item.rating);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 32 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
                       Write(item.year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><a");
            BeginWriteAttribute("href", " href=\"", 1204, "\"", 1224, 1);
#nullable restore
#line 33 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
WriteAttributeValue("", 1211, item.trailer, 1211, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-dark\"><i class=\'bx bxl-youtube\'> Fragman</i></a></td>\r\n                    </tr>\r\n");
#nullable restore
#line 35 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\ApiMovie\Index.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<ApiMovieViewModel>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
