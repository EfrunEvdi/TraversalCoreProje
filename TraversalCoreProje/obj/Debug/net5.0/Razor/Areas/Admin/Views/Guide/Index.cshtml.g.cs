#pragma checksum "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78363f92c37c8605527ff9b3610b0e0d6d2d10fd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Guide_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Guide/Index.cshtml")]
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
#line 1 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
using EntityLayer.Concrete;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78363f92c37c8605527ff9b3610b0e0d6d2d10fd", @"/Areas/Admin/Views/Guide/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e7d9394ea5a35064272f310f1f88306572c4170", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Areas_Admin_Views_Guide_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Guide>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""card"">
    <h5 class=""card-header"">Rehber Listesi  </h5>
    <div class=""table-responsive text-nowrap"">
        <table class=""table table-hover text-center"">
            <thead>
                <tr>
                    <th>#</th>
                    <th>GÖRSEL</th>
                    <th>İSİM SOYİSİM</th>
                    <th>AÇIKLAMA</th>
                    <th>DURUM</th>
                    <th>İŞLEM SEÇİNİZ</th>
                </tr>
            </thead>

            <tbody class=""table-border-bottom-0 text-center"">
");
#nullable restore
#line 24 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 27 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                       Write(item.GuideID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td><img");
            BeginWriteAttribute("src", " src=\"", 873, "\"", 890, 1);
#nullable restore
#line 28 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 879, item.Image, 879, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"Avatar\" class=\"rounded-circle avatar avatar-s pull-up\" /></td>\r\n                        <td><i class=\"fab fa-angular fa-lg text-danger me-3\"></i> <strong>");
#nullable restore
#line 29 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                                                                                     Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></td>\r\n                        <td>");
#nullable restore
#line 30 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                       Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 31 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                         if (item.Status == true)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1275, "\"", 1322, 2);
            WriteAttributeValue("", 1282, "/Admin/Guide/ChangeToFalse/", 1282, 27, true);
#nullable restore
#line 34 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1309, item.GuideID, 1309, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-danger\">Pasif Yap!</a>\r\n                            </td>\r\n");
#nullable restore
#line 36 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <td>\r\n                                <a");
            BeginWriteAttribute("href", " href=\"", 1558, "\"", 1604, 2);
            WriteAttributeValue("", 1565, "/Admin/Guide/ChangeToTrue/", 1565, 26, true);
#nullable restore
#line 40 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 1591, item.GuideID, 1591, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-outline-info\">Aktif Yap!</a>\r\n                            </td>\r\n");
#nullable restore
#line 42 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        <td>
                            <div class=""dropdown"">
                                <button type=""button"" class=""btn p-0 dropdown-toggle hide-arrow"" data-bs-toggle=""dropdown"">
                                    <i class=""bx bx-plus""></i>
                                </button>
                                <div class=""dropdown-menu"">
                                    <a class=""dropdown-item""");
            BeginWriteAttribute("href", " href=\"", 2148, "\"", 2191, 2);
            WriteAttributeValue("", 2155, "/Admin/Guide/EditGuide/", 2155, 23, true);
#nullable restore
#line 49 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 2178, item.GuideID, 2178, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-edit-alt me-1\"></i> Düzenle</a>\r\n                                    <a class=\"dropdown-item\"");
            BeginWriteAttribute("href", " href=\"", 2302, "\"", 2347, 2);
            WriteAttributeValue("", 2309, "/Admin/Guide/DeleteGuide/", 2309, 25, true);
#nullable restore
#line 50 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
WriteAttributeValue("", 2334, item.GuideID, 2334, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><i class=\"bx bx-trash me-1\"></i> Sil</a>\r\n                                </div>\r\n                            </div>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 55 "C:\Users\efrun\OneDrive\Desktop\Yazılım\Murat Yücedağ MVC\TraversalCoreProje\TraversalCoreProje\Areas\Admin\Views\Guide\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n    <a href=\"/Admin/Guide/AddGuide/\" class=\"btn btn-outline-primary\">Yeni Rehber Oluştur!</a>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Guide>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591