#pragma checksum "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "84aa1af2149cc3d86625ac26ecc1a4ebeb7703ab"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84aa1af2149cc3d86625ac26ecc1a4ebeb7703ab", @"/Areas/Admin/Views/Roles/Index.cshtml")]
    public class Areas_Admin_Views_Roles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOLPHIN.Model.Roles>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Index</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.UpdatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.CreatedBy));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 38 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 41 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 44 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 47 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 50 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.UpdatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 53 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 56 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.CreatedBy.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1652, "\"", 1675, 1);
#nullable restore
#line 59 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
WriteAttributeValue("", 1667, item.Id, 1667, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1728, "\"", 1751, 1);
#nullable restore
#line 60 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
WriteAttributeValue("", 1743, item.Id, 1743, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1806, "\"", 1829, 1);
#nullable restore
#line 61 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
WriteAttributeValue("", 1821, item.Id, 1821, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 64 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOLPHIN.Model.Roles>> Html { get; private set; }
    }
}
#pragma warning restore 1591
