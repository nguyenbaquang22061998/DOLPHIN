#pragma checksum "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5695cd4c9e6561ecc8683d4c714375d0c19b0105"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_News_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/News/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5695cd4c9e6561ecc8683d4c714375d0c19b0105", @"/Areas/Admin/Views/News/Edit.cshtml")]
    public class Areas_Admin_Views_News_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.News>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\News\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>News</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
            <div class=""form-group"">
                <label asp-for=""Titile"" class=""control-label""></label>
                <input asp-for=""Titile"" class=""form-control"" />
                <span asp-validation-for=""Titile"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Images"" class=""control-label""></label>
                <input asp-for=""Images"" class=""form-control"" />
                <span asp-validation-for=""Images"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Description"" class=""control-label""></label>
                <input asp-for=""Description"" class=""form-control"" />
                <span asp-validation-f");
            WriteLiteral(@"or=""Description"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Refer"" class=""control-label""></label>
                <input asp-for=""Refer"" class=""form-control"" />
                <span asp-validation-for=""Refer"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdatedDate"" class=""control-label""></label>
                <input asp-for=""UpdatedDate"" class=""form-control"" />
                <span asp-validation-for=""UpdatedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""UpdatedById"" class=""control-label""></label>
                <select asp-for=""UpdatedById"" class=""form-control"" asp-items=""ViewBag.UpdatedById""></select>
                <span asp-validation-for=""UpdatedById"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=");
            WriteLiteral(@"""CreatedDate"" class=""control-label""></label>
                <input asp-for=""CreatedDate"" class=""form-control"" />
                <span asp-validation-for=""CreatedDate"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CreatedById"" class=""control-label""></label>
                <select asp-for=""CreatedById"" class=""form-control"" asp-items=""ViewBag.CreatedById""></select>
                <span asp-validation-for=""CreatedById"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOLPHIN.Model.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
