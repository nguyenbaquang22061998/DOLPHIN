#pragma checksum "D:\Đồ án - QUANG\DOLPHIN_v2_last_update\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Login\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02a91bca1b49ee719c507519c89dda996cf8e8ba"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Login_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Login/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02a91bca1b49ee719c507519c89dda996cf8e8ba", @"/Areas/Admin/Views/Login/Index.cshtml")]
    public class Areas_Admin_Views_Login_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DOLPHIN.DTO.AccountDto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\Đồ án - QUANG\DOLPHIN_v2_last_update\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Login\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_LayoutLogin.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 7 "D:\Đồ án - QUANG\DOLPHIN_v2_last_update\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Login\Index.cshtml"
 using (Html.BeginForm(FormMethod.Post))
{
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "D:\Đồ án - QUANG\DOLPHIN_v2_last_update\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Login\Index.cshtml"
Write(Html.EditorFor(model => model.UserName, new { htmlAttributes = new { placeholder = "Tài khoản" } }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "D:\Đồ án - QUANG\DOLPHIN_v2_last_update\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Login\Index.cshtml"
Write(Html.EditorFor(model => model.PassWord, new { htmlAttributes = new { placeholder = "Mật khẩu" } }));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button>Đăng nhập</button>\r\n    <p class=\"message\">Quên mật khẩu? <a href=\"#\">Tạo tài khoản mới</a></p>\r\n");
#nullable restore
#line 13 "D:\Đồ án - QUANG\DOLPHIN_v2_last_update\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Login\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DOLPHIN.DTO.AccountDto> Html { get; private set; }
    }
}
#pragma warning restore 1591