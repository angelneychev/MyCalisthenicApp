#pragma checksum "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Identity\Pages\_ViewStart.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "45b8653fc55b04373c8c2644cd0cc9fd64842918"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages__ViewStart), @"mvc.1.0.view", @"/Areas/Identity/Pages/_ViewStart.cshtml")]
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
#line 1 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using MyCalisthenicApp.Web.Areas.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using MyCalisthenicApp.Web.Areas.Identity.Pages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using MyCalisthenicApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Identity\Pages\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Subscribes;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"45b8653fc55b04373c8c2644cd0cc9fd64842918", @"/Areas/Identity/Pages/_ViewStart.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6125d39bbc58e57fdd5d5d124db1694d5250b7b", @"/Areas/Identity/Pages/_ViewImports.cshtml")]
    public class Areas_Identity_Pages__ViewStart : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Identity\Pages\_ViewStart.cshtml"
  
    if (SignInManager.IsSignedIn(User) && User.IsInRole("Admin"))
    {

        Layout = "~/Views/Shared/Layouts/_LayoutAdmin.cshtml";
    }
    else
    {
        Layout = "~/Views/Shared/Layouts/_Layout.cshtml";

    }

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<ApplicationUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> SignInManager { get; private set; }
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