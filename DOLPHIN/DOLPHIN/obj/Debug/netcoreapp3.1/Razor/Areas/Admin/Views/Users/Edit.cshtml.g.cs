#pragma checksum "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "21bc5334860ac6cbb4ab5e87f3fc3b96639cb382"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Edit), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"21bc5334860ac6cbb4ab5e87f3fc3b96639cb382", @"/Areas/Admin/Views/Users/Edit.cshtml")]
    public class Areas_Admin_Views_Users_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.Model.Users>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\h\Desktop\DAI HOC\Đồ án tốt nghiệp\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 style=""margin:20px"">Chỉnh sửa</h2>
<div class=""card"">
    <div class=""card-body"">
        <div class=""row"">
            <div class=""col-md-4"">
                <form asp-action=""Edit"" method=""post"">
                    <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
                    <input type=""hidden"" asp-for=""Id"" />
                    <div class=""form-group"">
                        <label asp-for=""UserName"" class=""control-label""></label>
                        <input asp-for=""UserName"" class=""form-control"" />
                        <span asp-validation-for=""UserName"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label asp-for=""Password"" class=""control-label""></label>
                        <input asp-for=""Password"" class=""form-control"" />
                        <span asp-validation-for=""Password"" class=""text-danger""></span>
                    </div>
                    <div cla");
            WriteLiteral(@"ss=""form-group"">
                        <label asp-for=""Email"" class=""control-label""></label>
                        <input asp-for=""Email"" class=""form-control"" />
                        <span asp-validation-for=""Email"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label asp-for=""FullName"" class=""control-label""></label>
                        <input asp-for=""FullName"" class=""form-control"" />
                        <span asp-validation-for=""FullName"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label asp-for=""JoinDate"" class=""control-label""></label>
                        <input asp-for=""JoinDate"" class=""form-control"" />
                        <span asp-validation-for=""JoinDate"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <label asp-for=""Status"" class=""");
            WriteLiteral(@"control-label""></label>
                        <input asp-for=""Status"" class=""form-control"" />
                        <span asp-validation-for=""Status"" class=""text-danger""></span>
                    </div>
                    <div class=""form-group"">
                        <input type=""submit"" value=""Save"" class=""btn btn-primary"" />
                    </div>
                </form>
            </div>
        </div>
    </div>
</div>

<div>
    <a href=""/Admin/Users/Index"" class=""btn btn-primary"" style=""margin-left:10px"">Quay lại</a>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOLPHIN.Model.Users> Html { get; private set; }
    }
}
#pragma warning restore 1591
