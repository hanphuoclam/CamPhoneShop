#pragma checksum "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7e703fc4639db2fbacc2dda097cf58d4b9cb5ffd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_Index), @"mvc.1.0.view", @"/Views/Product/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/Index.cshtml", typeof(AspNetCore.Views_Product_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7e703fc4639db2fbacc2dda097cf58d4b9cb5ffd", @"/Views/Product/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5017ced2044ad011c8781c1b1e0d43fefebf6a45", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "sortby=ten&order=asc", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "sortby=ten", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
  
    Layout = "_Layout";

#line default
#line hidden
            BeginContext(34, 1082, true);
            WriteLiteral(@"
<!-- Start Page Title -->
<div class=""page-title"">
    <div class=""container"">
        <div class=""column"">
            <h1>Tất cả sản phẩm</h1>
        </div>
        <div class=""column"">
            <ul class=""breadcrumbs"">
                <li>
                    <a href=""index-1.html"">Trang chủ</a>
                </li>
                <li class=""separator"">&nbsp;</li>
                <li>Tất cả sản phẩm</li>
            </ul>
        </div>
    </div>
</div>
<!-- End Page Title -->
<!-- Start Page Content -->
<div class=""container padding-top-1x padding-bottom-3x"">
    <div class=""row"">
        <!-- Start Categories Content -->
        <div class=""col-lg-9 order-lg-2"">
            <!-- Start Toolbar -->
            <div class=""shop-toolbar mb-30"">
                <div class=""column"">
                    <div class=""shop-sorting"">
                        <label for=""sorting"">Sắp xếp:</label>
                        <select class=""form-control"" id=""sorting"" name=""forma"" onchan");
            WriteLiteral("ge=\"location = this.value;\">\r\n                            ");
            EndContext();
            BeginContext(1116, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9889326049ec438e833dbcb3ef0e7b32", async() => {
                BeginContext(1136, 8, true);
                WriteLiteral("Mặc định");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1153, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1183, 55, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "d8d697dd857848889018ccfbec6e97f8", async() => {
                BeginContext(1220, 9, true);
                WriteLiteral("Tên A - Z");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1238, 30, true);
            WriteLiteral("\r\n                            ");
            EndContext();
            BeginContext(1268, 45, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "63a409eff49946838803cc5a0442afbd", async() => {
                BeginContext(1295, 9, true);
                WriteLiteral("Tên Z - A");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1313, 200, true);
            WriteLiteral("\r\n                        </select>\r\n                    </div>\r\n                </div>\r\n                <div class=\"column\">\r\n                    <span class=\"text-muted\">Hiển thị: </span><span> 1 - ");
            EndContext();
            BeginContext(1514, 27, false);
#line 42 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                                                                    Write(Model.danhSachSanPham.total);

#line default
#line hidden
            EndContext();
            BeginContext(1541, 283, true);
            WriteLiteral(@" sản phẩm</span>
                </div>
            </div>
            <!-- End Toolbar -->
            <!-- Start Products Grid -->
            <div class=""isotope-grid cols-3"">
                <div class=""gutter-sizer""></div>
                <div class=""grid-sizer""></div>
");
            EndContext();
#line 50 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                 foreach (SanPham i in Model.danhSachSanPham.content)
                {

#line default
#line hidden
            BeginContext(1914, 193, true);
            WriteLiteral("                    <!-- Start Product -->\r\n                    <div class=\"grid-item\">\r\n                        <div class=\"product-card\">\r\n                            <a class=\"product-thumb\"");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2107, "\"", 2157, 2);
            WriteAttributeValue("", 2114, "https://localhost:5001/product/detail/", 2114, 38, true);
#line 55 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
WriteAttributeValue("", 2152, i.ID, 2152, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2158, 45, true);
            WriteLiteral(">\r\n                                <img src= ");
            EndContext();
            BeginContext(2204, 6, false);
#line 56 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                                     Write(i.Hinh);

#line default
#line hidden
            EndContext();
            BeginContext(2210, 107, true);
            WriteLiteral(" alt=\"Product\">\r\n                            </a>\r\n                            <h3 class=\"product-title\"><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 2317, "\"", 2367, 2);
            WriteAttributeValue("", 2324, "https://localhost:5001/product/detail/", 2324, 38, true);
#line 58 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
WriteAttributeValue("", 2362, i.ID, 2362, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(2368, 1, true);
            WriteLiteral(">");
            EndContext();
            BeginContext(2370, 5, false);
#line 58 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                                                                                                       Write(i.Ten);

#line default
#line hidden
            EndContext();
            BeginContext(2375, 67, true);
            WriteLiteral("</a></h3>\r\n                            <h4 class=\"product-price\">\r\n");
            EndContext();
#line 60 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                                 if(!i.PhanLoaiSP[0].GiaKM.Equals(null))
                                {

#line default
#line hidden
            BeginContext(2551, 41, true);
            WriteLiteral("                                    <del>");
            EndContext();
            BeginContext(2593, 22, false);
#line 62 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                                    Write(i.PhanLoaiSP[0].GiaBan);

#line default
#line hidden
            EndContext();
            BeginContext(2615, 6, true);
            WriteLiteral("</del>");
            EndContext();
            BeginContext(2622, 21, false);
#line 62 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                                                                 Write(i.PhanLoaiSP[0].GiaKM);

#line default
#line hidden
            EndContext();
#line 62 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                                                                                            
                                }
                                else
                                {
                                    

#line default
#line hidden
            BeginContext(2789, 22, false);
#line 66 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                               Write(i.PhanLoaiSP[0].GiaBan);

#line default
#line hidden
            EndContext();
#line 66 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                                                           
                                }

#line default
#line hidden
            BeginContext(2845, 560, true);
            WriteLiteral(@" Đ
                            </h4>
                            <div class=""product-buttons"">
                                <a class=""btn btn-outline-primary btn-sm"" 
                                        data-toast data-toast-type=""success"" 
                                        data-toast-position=""topRight"" 
                                        data-toast-icon=""icon-circle-check"" 
                                        data-toast-title=""Product"" 
                                        data-toast-message=""successfuly added to cart!""");
            EndContext();
            BeginWriteAttribute("href", "\r\n                                        href=\"", 3405, "\"", 3490, 2);
            WriteAttributeValue("", 3453, "https://localhost:5001/cart/add/", 3453, 32, true);
#line 76 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
WriteAttributeValue("", 3485, i.ID, 3485, 5, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3491, 229, true);
            WriteLiteral(">\r\n                                    Thêm vào giỏ\r\n                                </a>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <!-- End Product -->\r\n");
            EndContext();
#line 83 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3739, 1539, true);
            WriteLiteral(@"            </div>
            <!-- End Products Grid -->
            <!-- Start Pagination -->
            <nav class=""pagination"">
                <div class=""column text-left"">
                    <a class=""btn btn-outline-secondary btn-sm"" href=""#""><i class=""icon-arrow-left""></i> Trang trước</a>
                </div>
                <div class=""column"">
                    <ul class=""pages"">
                        <li class=""active""><a href=""#"">1</a></li>
                        <li><a href=""#"">2</a></li>
                        <li><a href=""#"">3</a></li>
                        <li>...</li>
                        <li><a href=""#"">10</a></li>
                        <li><a href=""#"">20</a></li>
                        <li><a href=""#"">30</a></li>
                    </ul>
                </div>
                <div class=""column text-right hidden-xs-down"">
                    <a class=""btn btn-outline-secondary btn-sm"" href=""#"">Trang sau <i class=""icon-arrow-right""></i></a>
           ");
            WriteLiteral(@"     </div>
            </nav>
            <!-- End Pagination -->
        </div>
        <!-- End Categories Content -->
        <!-- Start Sidebar -->
        <div class=""col-lg-3 order-lg-1 hidden-md-down"">
            <aside class=""sidebar"">
                <div class=""padding-top-2x hidden-lg-up""></div>
                <!-- Start Categories Widget -->
                <section class=""widget widget-categories"">
                    <h3 class=""widget-title"">Danh mục</h3>
                    <ul>
");
            EndContext();
#line 117 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                          foreach (DanhMucSP i in Model.danhSachDanhMuc.content)
                         {

#line default
#line hidden
            BeginContext(5386, 66, true);
            WriteLiteral("                             <li class=\"has-children\"><a href=\"#\">");
            EndContext();
            BeginContext(5453, 5, false);
#line 119 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                                                             Write(i.Ten);

#line default
#line hidden
            EndContext();
            BeginContext(5458, 10, true);
            WriteLiteral("</a></li>\n");
            EndContext();
#line 120 "/Users/vlamtu/Projects/hanphuoclam/CamPhoneShop.git/WebMobileMVC/Views/Product/Index.cshtml"
                         }

#line default
#line hidden
            BeginContext(5496, 4149, true);
            WriteLiteral(@"                    </ul>
                </section>
                <!-- End Categories Widget -->
                <!--  Start Price Range Widget -->
                <section class=""widget widget-categories"">
                    <h3 class=""widget-title"">Lọc theo gía</h3>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""<3.5tr"">
                        <label class=""custom-control-label"" for=""<3.5tr"">0 - 3.500.000 VND</label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""3.5-10tr"">
                        <label class=""custom-control-label"" for=""3.5-10tr"">3.500.000 - 10.000.000 VND</label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id="">10tr"">
         ");
            WriteLiteral(@"               <label class=""custom-control-label"" for="">10tr"">10.000.000 - 20.000.000 VND</label>
                    </div>
                </section>
                <!--  End Price Range Widget -->
                <!-- Start Brand Filter Widget -->
                <section class=""widget"">
                    <h3 class=""widget-title"">Lọc theo hãng</h3>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""apple"">
                        <label class=""custom-control-label"" for=""apple"">Apple <span class=""text-muted"">(197)</span></label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""samsung"">
                        <label class=""custom-control-label"" for=""samsung"">Samsung <span class=""text-muted"">(123)</span></label>
                    </div>
                    <div class=""custo");
            WriteLiteral(@"m-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""sony"">
                        <label class=""custom-control-label"" for=""sony"">Sony <span class=""text-muted"">(148)</span></label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""nokia"">
                        <label class=""custom-control-label"" for=""nokia"">Nokia <span class=""text-muted"">(164)</span></label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""oppo"">
                        <label class=""custom-control-label"" for=""oppo"">Oppo <span class=""text-muted"">(139)</span></label>
                    </div>
                </section>
                <!-- End Brand Filter Widget -->
                <!-- Start Size Filter Widget -->
              ");
            WriteLiteral(@"  <section class=""widget"">
                    <h3 class=""widget-title"">Lọc theo màu</h3>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""trang"">
                        <label class=""custom-control-label"" for=""trang"">Trắng</label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""den"">
                        <label class=""custom-control-label"" for=""den"">Đen</label>
                    </div>
                    <div class=""custom-control custom-checkbox"">
                        <input class=""custom-control-input"" type=""checkbox"" id=""do"">
                        <label class=""custom-control-label"" for=""do"">Đỏ</label>
                    </div>
                </section>
                <!-- End Size Filter Widget -->
            </aside>
        </div>
        <!-- End Sideb");
            WriteLiteral("ar -->\r\n    </div>\r\n</div>\r\n<!-- End Page Content -->");
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
