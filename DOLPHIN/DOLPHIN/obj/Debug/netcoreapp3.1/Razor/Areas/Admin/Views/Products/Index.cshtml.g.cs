#pragma checksum "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9b07046b8ea2331c4cf51fcc8a0a2993ab6f6f06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9b07046b8ea2331c4cf51fcc8a0a2993ab6f6f06", @"/Areas/Admin/Views/Products/Index.cshtml")]
    public class Areas_Admin_Views_Products_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOLPHIN.Model.Products>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 style=""margin-left:20px"">Quản lý Sản phẩm</h2>
<span class=""badge bg-primary"" style=""font-size:20px ; margin-left:20px""><a href=""/Admin/Products/Create"">Thêm sản phẩm mới</a></span>
<div class=""card"">
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th class=""text-center"">
                        Danh mục
                    </th>
                    <th class=""text-center"">
                        Tên sản phẩm
                    </th>
                    <th class=""text-center"">
                        Giá
                    </th>
                    <th class=""text-center"">
                        Màu sắc
                    </th>
                    <th class=""text-center"">
                        Size
                    </th>
                    <th class=""text-center"">
                        Mô tả
                    </th>
                    <th class=""text-center"">
                 ");
            WriteLiteral(@"       Ảnh
                    </th>
                    <th class=""text-center"">
                        Trạng thái
                    </th>
                    <th class=""text-center"">
                        Ngày tạo
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
#line 51 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 55 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 58 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 61 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 64 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Color));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 67 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Size));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 70 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Desciption));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        <div>\r\n                            <img");
            BeginWriteAttribute("src", " src=\"", 2755, "\"", 2798, 1);
#nullable restore
#line 74 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 2761, Url.Content("~/images/"+item.Images), 2761, 37, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" width=\"110\" height=\"110\">\r\n                        </div>\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 78 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 81 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        ");
#nullable restore
#line 84 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.CreatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td class=\"text-center\">\r\n                        <span class=\"badge bg-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 3426, "\"", 3462, 2);
            WriteAttributeValue("", 3433, "/Admin/Products/Edit/", 3433, 21, true);
#nullable restore
#line 87 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 3454, item.Id, 3454, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a></span>\r\n                        <span class=\"badge bg-success\"><a");
            BeginWriteAttribute("href", " href=\"", 3537, "\"", 3576, 2);
            WriteAttributeValue("", 3544, "/Admin/Products/Details/", 3544, 24, true);
#nullable restore
#line 88 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 3568, item.Id, 3568, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chi tiết</a></span>\r\n                        <span class=\"badge bg-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 3655, "\"", 3693, 2);
            WriteAttributeValue("", 3662, "/Admin/Products/Delete/", 3662, 23, true);
#nullable restore
#line 89 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
WriteAttributeValue("", 3685, item.Id, 3685, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a></span>\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 92 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOLPHIN.Model.Products>> Html { get; private set; }
    }
}
#pragma warning restore 1591
