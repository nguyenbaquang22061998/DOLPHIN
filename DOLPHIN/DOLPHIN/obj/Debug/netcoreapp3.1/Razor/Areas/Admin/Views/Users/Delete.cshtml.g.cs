#pragma checksum "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "75ff9f651e80ba0c21eb7a6acb587ebfb228d037"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Delete), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Delete.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"75ff9f651e80ba0c21eb7a6acb587ebfb228d037", @"/Areas/Admin/Views/Users/Delete.cshtml")]
    public class Areas_Admin_Views_Users_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
  
    ViewData["Title"] = "Delete";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Users</h4>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 16 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 19 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 22 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 25 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 28 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 31 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 34 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 37 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 40 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 43 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
#nullable restore
#line 46 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
#nullable restore
#line 49 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    <form asp-action=\"Delete\">\r\n        <input type=\"hidden\" asp-for=\"Id\" />\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        <a asp-action=\"Index\">Back to List</a>\r\n    </form>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOLPHIN.Model.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
