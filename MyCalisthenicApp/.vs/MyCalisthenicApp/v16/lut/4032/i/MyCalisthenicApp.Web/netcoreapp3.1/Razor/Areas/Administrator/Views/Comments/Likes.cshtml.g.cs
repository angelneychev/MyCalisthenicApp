#pragma checksum "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\Comments\Likes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a3fd18efd0b3e35c79169d615f48c798985bdbd5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Administrator_Views_Comments_Likes), @"mvc.1.0.view", @"/Areas/Administrator/Views/Comments/Likes.cshtml")]
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
#line 1 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Models.ShopEntities;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.OrderProducts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Addresses;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Users;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Orders;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Comments;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Products;

#line default
#line hidden
#nullable disable
#nullable restore
#line 10 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Posts;

#line default
#line hidden
#nullable disable
#nullable restore
#line 11 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Programs;

#line default
#line hidden
#nullable disable
#nullable restore
#line 12 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Exercises;

#line default
#line hidden
#nullable disable
#nullable restore
#line 13 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Requests;

#line default
#line hidden
#nullable disable
#nullable restore
#line 14 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Memberships;

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Models.ShopEntities.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 16 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Models.BlogEntities.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 17 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Models.TrainingEntities.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 18 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.Models.Enums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 19 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Suppliers;

#line default
#line hidden
#nullable disable
#nullable restore
#line 20 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Images;

#line default
#line hidden
#nullable disable
#nullable restore
#line 21 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\_ViewImports.cshtml"
using MyCalisthenicApp.ViewModels.Categories;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a3fd18efd0b3e35c79169d615f48c798985bdbd5", @"/Areas/Administrator/Views/Comments/Likes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e505f781c3d78a650fc44c23b7f8f52c4aafa74d", @"/Areas/Administrator/Views/_ViewImports.cshtml")]
    public class Areas_Administrator_Views_Comments_Likes : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IList<string>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-success ml-2"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Administrator", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"
<div style=""height:400px;overflow-x:scroll"">
    <table class=""table"">
        <thead>
            <tr>
                <th scope=""col"">#</th>
                <th scope=""col"">User name / id</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 12 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\Comments\Likes.cshtml"
              
                var counter = 0;
            

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\Comments\Likes.cshtml"
             foreach (var likes in Model)
            {
                counter++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 20 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\Comments\Likes.cshtml"
                               Write(counter);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 21 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\Comments\Likes.cshtml"
                   Write(likes);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 23 "E:\Soft Uni\CODES\MyCalisthenicApp\MyCalisthenicApp\MyCalisthenicApp.Web\Areas\Administrator\Views\Comments\Likes.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </tbody>\r\n    </table>\r\n</div>\r\n<br />\r\n<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a3fd18efd0b3e35c79169d615f48c798985bdbd511106", async() => {
                WriteLiteral("Back to admin home");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IList<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
