#pragma checksum "/Users/LamHan/ProjectASP/CamPhoneShop/WebMobileMVC/Views/Checkout/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1b1140dffd4453ee41df632076add4cb3951dfc2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Checkout_Index), @"mvc.1.0.view", @"/Views/Checkout/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Checkout/Index.cshtml", typeof(AspNetCore.Views_Checkout_Index))]
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
#line 1 "/Users/LamHan/ProjectASP/CamPhoneShop/WebMobileMVC/Views/_ViewImports.cshtml"
using WebMobileMVC;

#line default
#line hidden
#line 2 "/Users/LamHan/ProjectASP/CamPhoneShop/WebMobileMVC/Views/_ViewImports.cshtml"
using WebMobileMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1b1140dffd4453ee41df632076add4cb3951dfc2", @"/Views/Checkout/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Checkout_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "/Users/LamHan/ProjectASP/CamPhoneShop/WebMobileMVC/Views/Checkout/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 3726, true);
            WriteLiteral(@"
<!-- Start Page Title -->
<div class=""page-title"">
    <div class=""container"">
        <div class=""column"">
            <h1>Tiến hành đặt hàng</h1>
        </div>
        <div class=""column"">
            <ul class=""breadcrumbs"">
                <li><a href=""index-1.html"">Trang chủ</a></li>
                <li class=""separator"">&nbsp;</li>
                <li>Tiến hành đặt hàng</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Title -->
<!-- Start Checkout Content -->
<div class=""container padding-top-1x padding-bottom-3x"">
    <div class=""row"">
        <div class=""col-lg-1""></div>
        <!-- Start Checkout Address -->
        <div class=""col-lg-10"">
            <div class=""checkout-steps"">
                <a href=""#"">4. Hoàn tất</a>
                <a href=""#""><span class=""angle""></span>3. Vận chuyển</a>
                <a href=""#""><span class=""angle""></span>2. Thông tin đơn hàng</a>
                <a class=""active"" href=""checkout-address.html""><span class=""a");
            WriteLiteral(@"ngle""></span>1. Thông tin người nhận</a>
            </div>
            <h4>Hãy nhập thông tin nhận hàng</h4>
            <hr class=""padding-bottom-1x"">
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label for=""checkout-fn"">Họ</label>
                        <input class=""form-control"" type=""text"" id=""checkout-fn"">
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label for=""checkout-ln"">Tên</label>
                        <input class=""form-control"" type=""text"" id=""checkout-ln"">
                    </div>
                </div>
            </div>
            <div class=""row"">
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label for=""checkout-email"">Địa chỉ E-Mail</label>
                        <input class=""form-control"" type=""");
            WriteLiteral(@"email"" id=""checkout-email"">
                    </div>
                </div>
                <div class=""col-sm-6"">
                    <div class=""form-group"">
                        <label for=""checkout-phone"">Số điện thoại</label>
                        <input class=""form-control"" type=""text"" id=""checkout-phone"">
                    </div>
                </div>
            </div>
            <div class=""row padding-bottom-1x"">
                <div class=""col-sm-12"">
                    <div class=""form-group"">
                        <label for=""checkout-address1"">Địa chỉ nhận hàng</label>
                        <input class=""form-control"" type=""text"" id=""checkout-address1"">
                    </div>
                </div>
            </div>
            <div class=""form-group"">
                <div class=""custom-control custom-checkbox"">
                    <input class=""custom-control-input"" type=""checkbox"" id=""same_address"" checked>
                    <label class=""custom-cont");
            WriteLiteral(@"rol-label"" for=""same_address"">Sử dụng thông tin tài khoản</label>
                </div>
            </div>
            <div class=""checkout-footer"">
                <div class=""column""><a class=""btn btn-outline-secondary"" href=""cart.html""><i class=""icon-arrow-left""></i><span class=""hidden-xs-down"">&nbsp;Quay lại giỏ hàng</span></a></div>
                <div class=""column""><a class=""btn btn-primary"" href=""checkout-review.html""><span class=""hidden-xs-down"">Tiếp tục&nbsp;</span><i class=""icon-arrow-right""></i></a></div>
            </div>
        </div>
        <!-- End Checkout Address -->
    </div>
</div>
<!-- End Product Content -->");
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