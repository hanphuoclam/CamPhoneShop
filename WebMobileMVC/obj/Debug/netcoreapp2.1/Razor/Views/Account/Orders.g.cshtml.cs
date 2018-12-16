#pragma checksum "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Account/Orders.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5ec8381cd0dee7b57174db827bda479e89ae3f5f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Orders), @"mvc.1.0.view", @"/Views/Account/Orders.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Orders.cshtml", typeof(AspNetCore.Views_Account_Orders))]
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
#line 1 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/_ViewImports.cshtml"
using WebMobileMVC;

#line default
#line hidden
#line 2 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/_ViewImports.cshtml"
using WebMobileMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5ec8381cd0dee7b57174db827bda479e89ae3f5f", @"/Views/Account/Orders.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Orders : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Account/Orders.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 5441, true);
            WriteLiteral(@"
<!-- Start Page Title -->
<div class=""page-title"">
    <div class=""container"">
        <div class=""column"">
            <h1>Đơn hàng của tôi</h1>
        </div>
        <div class=""column"">
            <ul class=""breadcrumbs"">
                <li><a href=""index-1.html"">Trang chủ</a></li>
                <li class=""separator"">&nbsp;</li>
                <li>Đơn hàng của tôi</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Title -->
<!-- Start My Orders -->
<div class=""container padding-top-1x padding-bottom-3x"">
    <div class=""row"">
        <div class=""col-lg-4"">
            <aside class=""user-info-wrapper"">
                <div class=""user-cover account-details"">
                    <div class=""info-label"" data-toggle=""tooltip"" title=""You currently have 530 Reward Points to spend""><i class=""icon-medal""></i>530 Điểm</div>
                </div>
                <div class=""user-info"">
                    <div class=""user-avatar""><a class=""edit-avatar"" href=""#""></");
            WriteLiteral(@"a><img src=""/assets/images/account/user-ava.jpg"" alt=""User""></div>
                    <div class=""user-data"">
                        <h4>Tony Stark</h4><span>Joined February 06, 2018</span>
                    </div>
                </div>
            </aside>
            <nav class=""list-group"">
                <a class=""list-group-item"" href=""account-profile.html""><i class=""icon-head""></i>Thông tin tài khoản</a>
                <a class=""list-group-item"" href=""account-bank.html""><i class=""icon-columns""></i>Ngân hàng</a>
                <a class=""list-group-item with-badge  active"" href=""account-orders.html""><i class=""icon-bag""></i>Đơn hàng<span class=""badge badge-primary badge-pill"">6</span></a>
                <a class=""list-group-item with-badge"" href=""account-wishlist.html""><i class=""icon-heart""></i>Sản phẩm đã thích<span class=""badge badge-primary badge-pill"">3</span></a>
                <a class=""list-group-item with-badge"" href=""account-notification.html""><i class=""icon-bell""></i>Thông bá");
            WriteLiteral(@"o<span class=""badge badge-primary badge-pill"">4</span></a>
                <a class=""list-group-item"" href=""account-changepass.html""><i class=""icon-repeat""></i>Đổi mật khẩu</a>
            </nav>
        </div>
        <div class=""col-lg-8"">
            <div class=""padding-top-2x mt-2 hidden-lg-up""></div>
            <div class=""table-responsive"">
                <table class=""table table-hover margin-bottom-none"">
                    <thead>
                        <tr>
                            <th>Mã đơn hàng</th>
                            <th>Ngày đặt</th>
                            <th>Tình trạng</th>
                            <th>Tổng tiền</th>
                        </tr>
                    </thead>
                    <tbody>
                        <tr>
                            <td><a class=""text-medium navi-link"" href=""account-orderdetail.html"">78A643CD409</a></td>
                            <td>April 13, 2018</td>
                            <td><span class=""text-da");
            WriteLiteral(@"nger"">Canceled</span></td>
                            <td><span class=""text-medium"">$450.00</span></td>
                        </tr>
                        <tr>
                            <td><a class=""text-medium navi-link"" href=""#"" data-toggle=""modal"" data-target=""#orderDetails"">34VB5540K83</a></td>
                            <td>March 21, 2018</td>
                            <td><span class=""text-info"">In Progress</span></td>
                            <td><span class=""text-medium"">$125.99</span></td>
                        </tr>
                        <tr>
                            <td><a class=""text-medium navi-link"" href=""#"" data-toggle=""modal"" data-target=""#orderDetails"">112P45A90V2</a></td>
                            <td>March 09, 2018</td>
                            <td><span class=""text-warning"">Delayed</span></td>
                            <td><span class=""text-medium"">$230.00</span></td>
                        </tr>
                        <tr>
                     ");
            WriteLiteral(@"       <td><a class=""text-medium navi-link"" href=""#"" data-toggle=""modal"" data-target=""#orderDetails"">28BA67U0981</a></td>
                            <td>Febrary 19, 2018</td>
                            <td><span class=""text-success"">Delivered</span></td>
                            <td><span class=""text-medium"">$400.00</span></td>
                        </tr>
                        <tr>
                            <td><a class=""text-medium navi-link"" href=""#"" data-toggle=""modal"" data-target=""#orderDetails"">502TR872W2</a></td>
                            <td>Febrary 04, 2018</td>
                            <td><span class=""text-success"">Delivered</span></td>
                            <td><span class=""text-medium"">$560.00</span></td>
                        </tr>
                        <tr>
                            <td><a class=""text-medium navi-link"" href=""#"" data-toggle=""modal"" data-target=""#orderDetails"">47H76G09F33</a></td>
                            <td>January 23, 2018</td>
     ");
            WriteLiteral(@"                       <td><span class=""text-success"">Delivered</span></td>
                            <td><span class=""text-medium"">$360.00</span></td>
                        </tr>
                    </tbody>
                </table>
            </div>
        </div>
    </div>
</div>
<!-- End My Orders -->");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
