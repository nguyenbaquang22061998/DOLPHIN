#pragma checksum "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5fb3849fbb76195d28043cf01bdf82a980980df9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/News/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5fb3849fbb76195d28043cf01bdf82a980980df9", @"/Areas/Admin/Views/News/Index.cshtml")]
    public class Areas_Admin_Views_News_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOLPHIN.Model.News>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 style=""margin-left:20px"">Quản lý Bài viết</h2>
<span class=""badge bg-primary"" style=""font-size:20px ; margin-left:20px""><a href=""/Admin/News/Create"">Thêm bài viết mới</a></span>
<div class=""card"">
    <div class=""card-body"">
        <table class=""table"">
            <thead>
                <tr>
                    <th class=""text-center"">
                        Tiếu đề
                    </th>
                    <th class=""text-center"">
                        Ảnh
                    </th>
                    <th class=""text-center"">
                        Mô tả
                    </th>
                    <th class=""text-center"">
                        Nguồn dẫn
                    </th>
                    <th class=""text-center"">
                        Ngày cập nhật
                    </th>
                    <th class=""text-center"">
                        Cập nhật bởi
                    </th>
                    <th class=""text-center"">
                        Ng");
            WriteLiteral(@"ày xuất bản
                    </th>
                    <th class=""text-center"">
                        Tạo bởi
                    </th>
                    <th class=""text-center"">
                        Thao tác
                    </th>
                </tr>
            </thead>
            <tbody>
");
#nullable restore
#line 45 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 49 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Titile));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 52 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Images));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 55 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 58 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Refer));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 61 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 64 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UpdatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 67 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 70 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.CreatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            <span class=\"badge bg-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 2943, "\"", 2975, 2);
            WriteAttributeValue("", 2950, "/Admin/News/Edit/", 2950, 17, true);
#nullable restore
#line 73 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
WriteAttributeValue("", 2967, item.Id, 2967, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a></span>\r\n                            <span class=\"badge bg-success\"><a");
            BeginWriteAttribute("href", " href=\"", 3054, "\"", 3089, 2);
            WriteAttributeValue("", 3061, "/Admin/News/Details/", 3061, 20, true);
#nullable restore
#line 74 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
WriteAttributeValue("", 3081, item.Id, 3081, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chi tiết</a></span>\r\n                            <span class=\"badge bg-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 3172, "\"", 3206, 2);
            WriteAttributeValue("", 3179, "/Admin/News/Delete/", 3179, 19, true);
#nullable restore
#line 75 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
WriteAttributeValue("", 3198, item.Id, 3198, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a></span>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 78 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOLPHIN.Model.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
