#pragma checksum "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\Shared\Partials\_IdentityFooterPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9d9da527bfb708132f31fac2b363f6ed71d41dd3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Partials__IdentityFooterPartial), @"mvc.1.0.view", @"/Views/Shared/Partials/_IdentityFooterPartial.cshtml")]
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
using MyCalisthenicApp.Web.Common;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Services.MessageSender;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Memberships;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Categories;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Programs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Contacts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Posts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Comments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Subscribes;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Addresses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Coupons;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Home;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.OrderProducts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Suppliers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Models.ShopEntities.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 22 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Models.BlogEntities.Enums;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9d9da527bfb708132f31fac2b363f6ed71d41dd3", @"/Views/Shared/Partials/_IdentityFooterPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"528ff86fbad13798d15e283cfce9fdfcdf7327e2", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Partials__IdentityFooterPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<!-- footer area start -->
<footer class=""footer-area footer-style-1 black-bg "">
    <div class=""footer-top padding-top-30 padding-bottom-0"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-lg-6 col-xl-4 col-md-6"">
                    <div class=""footer-widget widget"">
                        <ul class=""contact_info_list"">
                            <li class=""single-info-item"">
                                <div class=""icon"">
                                    <i class=""flaticon-phone-call""></i>
                                </div>
                                <div class=""details"">
                                    +359888414232
                                </div>
                            </li>
                            <li class=""single-info-item"">
                                <div class=""icon"">
                                    <i class=""flaticon-placeholder""></i>
                                </div>
               ");
            WriteLiteral(@"                 <div class=""details"">
                                    9 Kapitan Raicho street, Dryanovo
                                </div>
                            </li>
                            <li class=""single-info-item"">
                                <div class=""icon"">
                                    <i class=""flaticon-email""></i>
                                </div>
                                <div class=""details"">
                                    svetoslav.kazakov@outlook.com
                                </div>
                            </li>
                        </ul>
                    </div>
                </div>
                <div class=""container"">
                    <div class=""col-lg-12"">
                        <div class=""copyright-area-inner copyright-sm margin-top-30 "">
                            © MyCalisthenicApp 2019 All rights reserved. Powered with <i class=""fa fa-heart""></i>  by <a href=""https://github.com/svetlyoek"" target=""");
            WriteLiteral("_blank\">svetlyoek</a>\r\n                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</footer>\r\n<!-- footer area end -->");
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
