#pragma checksum "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e2e7e993042b4bea090011b78b7b3614a421417"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Users_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Users/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e2e7e993042b4bea090011b78b7b3614a421417", @"/Areas/Admin/Views/Users/Index.cshtml")]
    public class Areas_Admin_Views_Users_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<DOLPHIN.Model.Users>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Areas/Admin/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2 style=""margin-left:20px"">Quản lý Tài khoản</h2>

<span class=""badge bg-primary"" style=""font-size:20px ; margin-left:20px""><a href=""/Admin/Users/Create"">Thêm mới tài khoản</a></span>
<div class=""card"">
    <div class=""card-header"">

    </div>
    <div class=""card-body"">
        <table class=""table table-bordered"">
            <thead>
                <tr>
                    <th class=""text-center"">
                        Tên đăng nhập
                    </th>
                    <th class=""text-center"">
                        Mật khẩu
                    </th>
                    <th class=""text-center"">
                        EMail
                    </th class=""text-center"">
                    <th class=""text-center"">
                        Chủ tài khoản
                    </th>
                    <th class=""text-center"">
                        Ngày tạo
                    </th>
                    <th class=""text-center"">
                        Trạng thái
      ");
            WriteLiteral("              </th>\r\n                    <th class=\"text-center\">\r\n                        Thao tác\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 43 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
                 foreach (var item in Model)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 47 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.UserName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 50 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Password));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 53 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 56 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.FullName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 59 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.JoinDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            ");
#nullable restore
#line 62 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
                       Write(Html.DisplayFor(modelItem => item.Status));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                        </td>\r\n                        <td class=\"text-center\">\r\n                            <span class=\"badge bg-warning\"><a");
            BeginWriteAttribute("href", " href=\"", 2488, "\"", 2521, 2);
            WriteAttributeValue("", 2495, "/Admin/Users/Edit/", 2495, 18, true);
#nullable restore
#line 65 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 2513, item.Id, 2513, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Sửa</a></span> \r\n                            <span class=\"badge bg-success\"><a");
            BeginWriteAttribute("href", " href=\"", 2601, "\"", 2637, 2);
            WriteAttributeValue("", 2608, "/Admin/Users/Details/", 2608, 21, true);
#nullable restore
#line 66 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 2629, item.Id, 2629, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Chi tiết</a></span> \r\n                            <span class=\"badge bg-danger\"><a");
            BeginWriteAttribute("href", " href=\"", 2721, "\"", 2756, 2);
            WriteAttributeValue("", 2728, "/Admin/Users/Delete/", 2728, 20, true);
#nullable restore
#line 67 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
WriteAttributeValue("", 2748, item.Id, 2748, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a></span>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 70 "D:\Đồ án - QUANG\DOLPHIN\DOLPHIN\DOLPHIN\Areas\Admin\Views\Users\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<DOLPHIN.Model.Users>> Html { get; private set; }
    }
}
#pragma warning restore 1591
