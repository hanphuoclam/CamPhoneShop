#pragma checksum "/Users/LamHan/ProjectASP/ThuongMaiDienTuAPI/WebMobileMVC/Views/Account/Bank.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4d3fec5bb93364c5df8dbf4c65525a54d2957201"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Account_Bank), @"mvc.1.0.view", @"/Views/Account/Bank.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Account/Bank.cshtml", typeof(AspNetCore.Views_Account_Bank))]
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
#line 1 "/Users/LamHan/ProjectASP/ThuongMaiDienTuAPI/WebMobileMVC/Views/_ViewImports.cshtml"
using WebMobileMVC;

#line default
#line hidden
#line 2 "/Users/LamHan/ProjectASP/ThuongMaiDienTuAPI/WebMobileMVC/Views/_ViewImports.cshtml"
using WebMobileMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4d3fec5bb93364c5df8dbf4c65525a54d2957201", @"/Views/Account/Bank.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Account_Bank : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("interactive-credit-card row"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "/Users/LamHan/ProjectASP/ThuongMaiDienTuAPI/WebMobileMVC/Views/Account/Bank.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 2396, true);
            WriteLiteral(@"
<!-- Start Page Title -->
<div class=""page-title"">
    <div class=""container"">
        <div class=""column"">
            <h1>Tài khoản ngân hàng</h1>
        </div>
        <div class=""column"">
            <ul class=""breadcrumbs"">
                <li><a href=""index-1.html"">Trang chủ</a></li>
                <li class=""separator"">&nbsp;</li>
                <li>Tài khoản ngân hàng</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Title -->
<!-- Start Contacts & Shipping Address -->
<div class=""container padding-top-1x padding-bottom-3x"">
    <div class=""row"">
        <div class=""col-lg-4"">
            <aside class=""user-info-wrapper"">
                <div class=""user-cover account-details"">
                    <div class=""info-label"" data-toggle=""tooltip"" title=""You currently have 530 Reward Points to spend""><i class=""icon-medal""></i>530 Điểm</div>
                </div>
                <div class=""user-info"">
                    <div class=""user-avatar""><a class=""");
            WriteLiteral(@"edit-avatar"" href=""#""></a><img src=""/assets/images/account/user-ava.jpg"" alt=""User""></div>
                    <div class=""user-data"">
                        <h4>Tony Stark</h4><span>Joined February 06, 2018</span>
                    </div>
                </div>
            </aside>
            <nav class=""list-group"">
                <a class=""list-group-item"" href=""account-profile.html""><i class=""icon-head""></i>Thông tin tài khoản</a>
                <a class=""list-group-item active"" href=""account-bank.html""><i class=""icon-columns""></i>Ngân hàng</a>
                <a class=""list-group-item with-badge"" href=""account-orders.html""><i class=""icon-bag""></i>Đơn hàng<span class=""badge badge-primary badge-pill"">6</span></a>
                <a class=""list-group-item with-badge"" href=""account-wishlist.html""><i class=""icon-heart""></i>Sản phẩm đã thích<span class=""badge badge-primary badge-pill"">3</span></a>
                <a class=""list-group-item with-badge"" href=""account-notification.html""><i class=""");
            WriteLiteral(@"icon-bell""></i>Thông báo<span class=""badge badge-primary badge-pill"">4</span></a>
                <a class=""list-group-item"" href=""account-changepass.html""><i class=""icon-repeat""></i>Đổi mật khẩu</a>
            </nav>
        </div>
        <div class=""col-lg-8"">
            <div class=""padding-top-2x mt-2 hidden-lg-up""></div>
            ");
            EndContext();
            BeginContext(2430, 1010, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c3067c22d2b34dddb821b9499a41b68e", async() => {
                BeginContext(2472, 961, true);
                WriteLiteral(@"
                <div class=""form-group col-sm-6"">
                    <input class=""form-control"" type=""text"" name=""number"" placeholder=""Card Number"" required="""">
                </div>
                <div class=""form-group col-sm-6"">
                    <input class=""form-control"" type=""text"" name=""name"" placeholder=""Full Name"" required="""">
                </div>
                <div class=""form-group col-sm-6"">
                    <input class=""form-control"" type=""text"" name=""expiry"" placeholder=""MM/YY"" required="""">
                </div>
                <div class=""form-group col-sm-6"">
                    <input class=""form-control"" type=""text"" name=""cvc"" placeholder=""CVC"" required="""">
                </div>
                <div class=""col-12"">
                    <hr class=""mt-2 mb-3"">
                    <center><button class=""btn btn-outline-primary"" type=""submit"">Thêm</button></center>
                </div>
            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3440, 78, true);
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<!-- End Contacts & Shipping Address -->");
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
