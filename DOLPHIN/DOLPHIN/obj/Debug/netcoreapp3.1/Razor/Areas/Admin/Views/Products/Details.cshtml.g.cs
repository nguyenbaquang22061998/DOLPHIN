#pragma checksum "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b34daf06da95db95a890f92fb93adc9ccf885a6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Products_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Products/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b34daf06da95db95a890f92fb93adc9ccf885a6c", @"/Areas/Admin/Views/Products/Details.cshtml")]
    public class Areas_Admin_Views_Products_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.Products>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2 style=\" margin-left:20px\">Chi tiết</h2>\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h4>Sản phẩm: ");
#nullable restore
#line 11 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
                 Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 16 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 19 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.CategoryId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 22 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 25 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 28 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 31 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 34 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Desciption));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 37 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Desciption));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 40 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 43 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 46 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 49 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 52 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 55 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.UpdatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 58 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 61 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 64 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 67 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
           Write(Html.DisplayFor(model => model.CreatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 2521, "\"", 2558, 2);
            WriteAttributeValue("", 2528, "/Admin/Products/Edit/", 2528, 21, true);
#nullable restore
#line 72 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Products\Details.cshtml"
WriteAttributeValue("", 2549, Model.Id, 2549, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" style=\"margin-left:20px\">Chỉnh sửa</a>\r\n<a href=\"/Admin/Products/Index\" class=\"btn btn-primary\" style=\"margin-left:20px\">Quay lại</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOLPHIN.Model.Products> Html { get; private set; }
    }
}
#pragma warning restore 1591
