#pragma checksum "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Shared/Header.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "68676588ef09ebb05a91cde176b86156c91eae26"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Header), @"mvc.1.0.view", @"/Views/Shared/Header.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Header.cshtml", typeof(AspNetCore.Views_Shared_Header))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"68676588ef09ebb05a91cde176b86156c91eae26", @"/Views/Shared/Header.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Header : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("input-group"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(0, 379, true);
            WriteLiteral(@"<header class=""navbar navbar-sticky"">
    <!-- Start Logo -->
    <div class=""site-branding"">
        <div class=""inner"">
            <a class=""site-logo"" href=""https://localhost:5001/""><img src=""/assets/images/logo/logo-2.png"" alt=""Inspina"" width=""200""></a>
        </div>
    </div>
    <!-- End Logo -->
    <!-- Start Search -->
    <nav class=""site-menu"">
        ");
            EndContext();
            BeginContext(379, 400, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1e16aea1fe464b7aaa39d29302300da6", async() => {
                BeginContext(405, 367, true);
                WriteLiteral(@"
            <input type=""text"" name=""site_search"" class=""form-control"" placeholder=""Tên sản phẩm, tên shop,..."" aria-label=""Recipient's username"" aria-describedby=""button-addon2"">
            <div class=""input-group-append"">
                <button class=""btn btn-outline-secondary"" type=""button"" id=""button-addon2"">Tìm kiếm</button>
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
            BeginContext(779, 4903, true);
            WriteLiteral(@"
    </nav>
    <!-- End Search -->
    <!-- Start Toolbar -->
    <div class=""toolbar"">
        <div class=""inner"">
            <div class=""tools"">
                <!-- Start Account -->
                <div class=""account"">
                    <a href=""account-profile.html""></a><i class=""icon-head""></i>
                    <ul class=""toolbar-dropdown"">
                        <li class=""sub-menu-user"">
                            <div class=""user-ava"">
                                <img src=""/assets/images/account/user-ava-sm.jpg"" alt=""Tony Stark"">
                            </div>
                            <div class=""user-info"">
                                <h6 class=""user-name"">Tony Stark</h6>
                                <span class=""text-xs text-muted"">530 Điểm</span>
                            </div>
                        </li>
                        <li><a href=""account-profile.html"">Thông tin tài khoản</a></li>
                        <li><a href=""account-orders.h");
            WriteLiteral(@"tml"">Đơn hàng</a></li>
                        <li><a href=""account-wishlist.html"">Sản phẩm yêu thích</a></li>
                        <li class=""sub-menu-separator""></li>
                        <li><a href=""account-login.html""><i class=""fa fa-lock""></i> Đăng xuất</a></li>
                    </ul>
                </div>
                <!-- End Account -->
                <!-- Start Cart -->
                <div class=""cart"">
                    <a href=""cart.html""></a>
                    <i class=""icon-bag""></i>
                    <span class=""count"">3</span>
                    <div class=""toolbar-dropdown"">
                        <div class=""dropdown-product-item"">
                            <span class=""dropdown-product-remove""><i class=""icon-cross""></i></span>
                            <a class=""dropdown-product-thumb"" href=""shop-single-1.html"">
                                <img src=""/assets/images/cart-dropdown/01.jpg"" alt=""Product"">
                            </a>
        ");
            WriteLiteral(@"                    <div class=""dropdown-product-info"">
                                <a class=""dropdown-product-title"" href=""shop-single-1.html"">Samsung Galaxy A8</a>
                                <span class=""dropdown-product-details"">1 x $520</span>
                            </div>
                        </div>
                        <div class=""dropdown-product-item"">
                            <span class=""dropdown-product-remove""><i class=""icon-cross""></i></span>
                            <a class=""dropdown-product-thumb"" href=""shop-single-2.html"">
                                <img src=""/assets/images/cart-dropdown/02.jpg"" alt=""Product"">
                            </a>
                            <div class=""dropdown-product-info"">
                                <a class=""dropdown-product-title"" href=""shop-single-2.html"">Panasonic TX-32</a>
                                <span class=""dropdown-product-details"">2 x $400</span>
                            </div>
             ");
            WriteLiteral(@"           </div>
                        <div class=""dropdown-product-item"">
                            <span class=""dropdown-product-remove""><i class=""icon-cross""></i></span>
                            <a class=""dropdown-product-thumb"" href=""shop-single-3.html"">
                                <img src=""/assets/images/cart-dropdown/03.jpg"" alt=""Product"">
                            </a>
                            <div class=""dropdown-product-info"">
                                <a class=""dropdown-product-title"" href=""shop-single-3.html"">Acer Aspire 15.6 i3</a>
                                <span class=""dropdown-product-details"">1 x $600</span>
                            </div>
                        </div>
                        <div class=""toolbar-dropdown-group"">
                            <div class=""column"">
                                <span class=""text-lg"">Total:</span>
                            </div>
                            <div class=""column text-right"">
        ");
            WriteLiteral(@"                        <span class=""text-lg text-medium"">$1920 </span>
                            </div>
                        </div>
                        <div class=""toolbar-dropdown-group"">
                            <div class=""column"">
                                <a class=""btn btn-sm btn-block btn-secondary"" href=""cart.html"">Giỏ hàng</a>
                            </div>
                            <div class=""column"">
                                <a class=""btn btn-sm btn-block btn-success"" href=""checkout-address.html"">Thanh toán</a>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- End Cart -->
            </div>
        </div>
    </div>
    <!-- End Toolbar -->
</header>");
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
