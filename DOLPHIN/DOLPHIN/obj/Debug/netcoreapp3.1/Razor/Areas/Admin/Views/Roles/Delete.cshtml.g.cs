#pragma checksum "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e3547d9f261a7dafdd744110f45ce0c5ba330b2d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e3547d9f261a7dafdd744110f45ce0c5ba330b2d", @"/Areas/Admin/Views/Roles/Delete.cshtml")]
    public class Areas_Admin_Views_Roles_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.Roles>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Roles</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UpdatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Delete.cshtml"
       Write(Html.DisplayFor(model => model.CreatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </dd class>
    </dl>
    
    <form asp-action=""Delete"">
        <input type=""hidden"" asp-for=""Id"" />
        <input type=""submit"" value=""Delete"" class=""btn btn-danger"" /> |
        <a asp-action=""Index"">Back to List</a>
    </form>
</div>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOLPHIN.Model.Roles> Html { get; private set; }
    }
}
#pragma warning restore 1591
