#pragma checksum "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\ShoppingCarts\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2a1040341cbc2c0fa3a014c5238a1c63f098967a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCarts_Index), @"mvc.1.0.view", @"/Views/ShoppingCarts/Index.cshtml")]
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
#nullable restore
#line 1 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Blogs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Programs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Services.MessageSender;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2a1040341cbc2c0fa3a014c5238a1c63f098967a", @"/Views/ShoppingCarts/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dff7a0426a8bf6117b8c3299c99e8690b8a23961", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCarts_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "ShoppingCarts", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\ShoppingCarts\Index.cshtml"
  
    ViewData["Title"] = "Shopping Cart";

#line default
#line hidden
#nullable disable
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a1040341cbc2c0fa3a014c5238a1c63f098967a6548", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\" />\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"ie=edge\">\r\n    <title> ");
#nullable restore
#line 11 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\ShoppingCarts\Index.cshtml"
       Write(ViewData["Title"]);

#line default
#line hidden
#nullable disable
                WriteLiteral(@"</title>
    <!-- favicon -->
    <link rel=icon href=/assets/img/favicon.png sizes=""20x20"" type=""image/png"">
    <!-- animate -->
    <link rel=""stylesheet"" href=""/assets/css/animate.css"">
    <!-- bootstrap -->
    <link rel=""stylesheet"" href=""/assets/css/bootstrap.min.css"">
    <!-- magnific popup -->
    <link rel=""stylesheet"" href=""/assets/css/magnific-popup.css"">
    <!-- Slick -->
    <link rel=""stylesheet"" href=""/assets/css/slick.css"" />
    <link rel=""stylesheet"" href=""/assets/css/slick-theme.css"" />
    <!-- nice select -->
    <link rel=""stylesheet"" href=""/assets/css/nice-select.css"">
    <!-- owl carousel -->
    <link rel=""stylesheet"" href=""/assets/css/owl.carousel.min.css"">
    <!-- fontawesome -->
    <link rel=""stylesheet"" href=""/assets/css/font-awesome.min.css"">
    <!-- flaticon -->
    <link rel=""stylesheet"" href=""/assets/css/flaticon.css"">
    <!-- hamburgers -->
    <link rel=""stylesheet"" href=""/assets/css/hamburgers.min.css"">
    <!-- Main Stylesheet -->
    <link ");
                WriteLiteral("rel=\"stylesheet\" href=\"/assets/css/style.css\">\r\n    <!-- responsive Stylesheet -->\r\n    <link rel=\"stylesheet\" href=\"/assets/css/responsive.css\">\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a1040341cbc2c0fa3a014c5238a1c63f098967a9293", async() => {
                WriteLiteral(@"

    <!-- breadcrumb area -->
    <div class=""breadcrumb-style-1 shopping-cart-breadcrumb-overlay"" style=""background-image:url(/assets/img/bg/shopping-cart.png);"">
        <div class=""breadcrumb-inner"">
            <h1 class=""page-title"">Payment Method</h1>
            <ul class=""page-list margin-bottom-7"">
                <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a1040341cbc2c0fa3a014c5238a1c63f098967a9895", async() => {
                    WriteLiteral("Home");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n                <li>");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a1040341cbc2c0fa3a014c5238a1c63f098967a11351", async() => {
                    WriteLiteral("Payment method");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("</li>\r\n            </ul>\r\n        </div>\r\n    </div>\r\n    <!-- breadcrumb area end -->\r\n    <!-- payment start -->\r\n");
                WriteLiteral(@"
    <div class=""payment-area"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-7"">
                    <div class=""payment-content"">
                        <div class=""title"">
                            <h2>Payment Method</h2>
                        </div>
                        <div class=""payment-tab"">
                            <ul class=""nav nav-pills"">
                                <li>
                                    <a data-toggle=""pill"" href=""#home"" class=""active"">
                                        <div class=""tab-item"">
                                            <h1>Credit Card</h1>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a data-toggle=""pill"" href=""#menu1"">
                                        <div class=""tab-item"">
                                     ");
                WriteLiteral(@"       <h1>EasyPay</h1>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a data-toggle=""pill"" href=""#menu2"">
                                        <div class=""tab-item"">
                                            <h1>EPay</h1>
                                        </div>
                                    </a>
                                </li>
                                <li>
                                    <a data-toggle=""pill"" href=""#menu3"">
                                        <div class=""tab-item"">
                                            <h1>Cash on delivery</h1>
                                        </div>
                                    </a>
                                </li>
                            </ul>

");
                WriteLiteral("\r\n                            <div class=\"tab-content\">\r\n\r\n                                ");
#nullable restore
#line 98 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\ShoppingCarts\Index.cshtml"
                           Write(await Component.InvokeAsync("CreditCard"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

                                <div id=""menu1"" class=""tab-pane fade"">
                                    <div class=""all-tab-content"">
                                        <h2>Payment Details</h2>
                                        <div class=""card-option"">
                                            <div  class=""form-group"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a1040341cbc2c0fa3a014c5238a1c63f098967a15826", async() => {
                    WriteLiteral(@"
                                                    <div class=""form-row"">
                                                        <div class=""form-group col-md-7"">
                                                            <label for=""email"">Enter email</label>
                                                            <input type=""email"" class=""form-control"" id=""email"" placeholder=""demo@gmail.com"">
                                                        </div>
                                                        <div class=""form-group col-md-5 d-none d-md-block"">
                                                            <img src=""/assets/img/bg/easypay-logo.jpg"" height=""100"" width=""300"" alt=""easypay-logo"" />
                                                        </div>
                                                    </div>
                                                    <div class=""form-row"">
                                                        <div class=""form-group col-md-9 ");
                    WriteLiteral(@"offset-md-1"">
                                                            <div class=""btn-wrapper"">
                                                                <a href=""#"" class=""btn btn-block btn-element btn-lg-size btn-main-color btn-rounded"">Checkout</a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id=""menu2"" class=""tab-pane fade"">
                                    <div class=""all-tab-content"">
                                        <h2>Payment Details</h2>
                                        <div class=""card-option"">
                                            <div  class=""form-group"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a1040341cbc2c0fa3a014c5238a1c63f098967a19514", async() => {
                    WriteLiteral(@"
                                                    <div class=""form-row"">
                                                        <div class=""form-group col-md-7"">
                                                            <label for=""email"">Enter email</label>
                                                            <input type=""email"" class=""form-control"" id=""email"" placeholder=""demo@gmail.com"">
                                                        </div>
                                                        <div class=""form-group col-md-5 d-none d-md-block"">
                                                            <img src=""/assets/img/bg/epay-logo.png"" height=""100"" width=""300"" alt=""epay-logo"" />
                                                        </div>
                                                    </div>
                                                    <div class=""form-row"">
                                                        <div class=""form-group col-md-9 offset");
                    WriteLiteral(@"-md-1"">
                                                            <div class=""btn-wrapper"">
                                                                <a href=""#"" class=""btn btn-block btn-element btn-lg-size btn-main-color btn-rounded"">Checkout</a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                </div>
                                <div id=""menu3"" class=""tab-pane fade"">
                                    <div class=""all-tab-content"">
                                        <h2>Payment Details</h2>
                                        <div class=""card-option"">
                                            <div  class=""form-group"">
                                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2a1040341cbc2c0fa3a014c5238a1c63f098967a23196", async() => {
                    WriteLiteral(@"
                                                    <img src=""/assets/img/bg/on-delivery.jpeg"" height=""180"" width=""350"" alt=""epay-logo"" />
                                                    <div class=""form-row"">
                                                        <div class=""form-group col-md-9 offset-md-1"">
                                                            <div class=""btn-wrapper"">
                                                                <a href=""#"" class=""btn btn-block btn-element btn-lg-size btn-main-color btn-rounded"">Checkout</a>
                                                            </div>
                                                        </div>
                                                    </div>
                                                ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
                                            </div>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>

                ");
#nullable restore
#line 178 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\ShoppingCarts\Index.cshtml"
           Write(await Component.InvokeAsync("InvoiceSummary"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"

            </div>
        </div>
    </div>
    <!-- payment end -->
    
    <!-- jquery -->
    <script src=""/assets/js/jquery-2.2.4.min.js""></script>
    <!-- popper -->
    <script src=""/assets/js/popper.min.js""></script>
    <!-- bootstrap -->
    <script src=""/assets/js/bootstrap.min.js""></script>
    <!-- magnific popup -->
    <script src=""/assets/js/jquery.magnific-popup.js""></script>
    <!-- wow -->
    <script src=""/assets/js/wow.min.js""></script>
    <!-- nice select -->
    <script src=""/assets/js/nice-select.js""></script>
    <!-- counter up -->
    <script src=""/assets/js/counter-up.js""></script>
    <!-- owl carousel -->
    <script src=""/assets/js/owl.carousel.min.js""></script>
    <!-- Slick -->
    <script src=""/assets/js/slick.min.js""></script>
    <!-- Slick Animation -->
    <script src=""/assets/js/slick-animation.js""></script>
    <!-- waypoint -->
    <script src=""/assets/js/waypoints.min.js""></script>
    <!-- counterup -->
    <script src=""/assets/js");
                WriteLiteral(@"/jquery.counterup.min.js""></script>
    <!-- imageloaded -->
    <script src=""/assets/js/imagesloaded.pkgd.min.js""></script>
    <!-- isotope -->
    <script src=""/assets/js/isotope.pkgd.min.js""></script>
    <!-- rProgressbar -->
    <script src=""/assets/js/jQuery.rProgressbar.min.js""></script>
    <!-- main js -->
    <script src=""/assets/js/main.js""></script>
    <script src=""/assets/js/script.js""></script>
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
