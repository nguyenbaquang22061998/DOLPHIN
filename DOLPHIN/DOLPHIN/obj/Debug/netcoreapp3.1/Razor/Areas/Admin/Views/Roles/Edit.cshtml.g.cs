#pragma checksum "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1ed4d4ef1c5dd65bc279fc33f0ce65511d6c424"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1ed4d4ef1c5dd65bc279fc33f0ce65511d6c424", @"/Areas/Admin/Views/Roles/Edit.cshtml")]
    public class Areas_Admin_Views_Roles_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.Roles>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Roles</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Name"" class=""control-label""></label>
                <input asp-for=""Name"" class=""form-control"" />
                <span asp-validation-for=""Name"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-for=""Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdatedDate"" class=""control-label""></label>
                <input asp-for=""UpdatedDate"" class=""form-control"" />
                <span asp-va");
            WriteLiteral(@"lidation-for=""UpdatedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdatedById"" class=""control-label""></label>
                <select asp-for=""UpdatedById"" class=""form-control"" asp-items=""ViewBag.UpdatedById""></select>
                <span asp-validation-for=""UpdatedById"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedDate"" class=""control-label""></label>
                <input asp-for=""CreatedDate"" class=""form-control"" />
                <span asp-validation-for=""CreatedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedById"" class=""control-label""></label>
                <select asp-for=""CreatedById"" class=""form-control"" asp-items=""ViewBag.CreatedById""></select>
                <span asp-validation-for=""CreatedById"" class=""text-danger""></span>
            </div>
 ");
            WriteLiteral("           <div class=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
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
