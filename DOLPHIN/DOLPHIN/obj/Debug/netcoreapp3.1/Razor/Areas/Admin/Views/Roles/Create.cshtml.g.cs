#pragma checksum "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e5d458640a9f1ea4fff657502d3f8411066f82f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Roles_Create), @"mvc.1.0.view", @"/Areas/Admin/Views/Roles/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e5d458640a9f1ea4fff657502d3f8411066f82f", @"/Areas/Admin/Views/Roles/Create.cshtml")]
    public class Areas_Admin_Views_Roles_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.Roles>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\h\Desktop\DAI HOC\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Roles\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Roles</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
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
                <span asp-validation-for=""UpdatedDate"" class=""text-danger""");
            WriteLiteral(@"></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdatedById"" class=""control-label""></label>
                <select asp-for=""UpdatedById"" class =""form-control"" asp-items=""ViewBag.UpdatedById""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedDate"" class=""control-label""></label>
                <input asp-for=""CreatedDate"" class=""form-control"" />
                <span asp-validation-for=""CreatedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedById"" class=""control-label""></label>
                <select asp-for=""CreatedById"" class =""form-control"" asp-items=""ViewBag.CreatedById""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Bac");
            WriteLiteral("k to List</a>\r\n</div>\r\n\r\n");
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
