#pragma checksum "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2c38c4d7c2f6fabf3915b9188d9085f5803230e3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Categories_Details), @"mvc.1.0.view", @"/Areas/Admin/Views/Categories/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2c38c4d7c2f6fabf3915b9188d9085f5803230e3", @"/Areas/Admin/Views/Categories/Details.cshtml")]
    public class Areas_Admin_Views_Categories_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.Categories>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h2 style=\" margin-left:20px\">Chi tiết</h2>\r\n\r\n<div class=\"card\">\r\n    <div class=\"card-header\">\r\n        <h4>Danh mục: ");
#nullable restore
#line 12 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h4>\r\n    </div>\r\n    <div class=\"card-body\">\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 17 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 20 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 23 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 26 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 29 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 32 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 35 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 38 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.UpdatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 41 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 44 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 47 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 50 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
           Write(Html.DisplayFor(model => model.CreatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n</div>\r\n<a");
            BeginWriteAttribute("href", " href=\"", 1819, "\"", 1858, 2);
            WriteAttributeValue("", 1826, "/Admin/Categories/Edit/", 1826, 23, true);
#nullable restore
#line 55 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Categories\Details.cshtml"
WriteAttributeValue("", 1849, Model.Id, 1849, 9, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\" style=\"margin-left:20px\">Chỉnh sửa</a>\r\n<a href=\"/Admin/Categories/Index\" class=\"btn btn-primary\" style=\"margin-left:20px\">Quay lại</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOLPHIN.Model.Categories> Html { get; private set; }
    }
}
#pragma warning restore 1591
