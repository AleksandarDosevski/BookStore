#pragma checksum "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "53a1d8b8a1b89e088a46b9f33a0f8cc01eccaaa3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_WishList_Details), @"mvc.1.0.view", @"/Views/WishList/Details.cshtml")]
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
#line 1 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\_ViewImports.cshtml"
using BookStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\_ViewImports.cshtml"
using BookStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"53a1d8b8a1b89e088a46b9f33a0f8cc01eccaaa3", @"/Views/WishList/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"970ad2232b60c18355d1b72e2ff9366751045b67", @"/Views/_ViewImports.cshtml")]
    public class Views_WishList_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BookStore.Data.Entities.Book>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
  
    ViewData["Title"] = "Details";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"custom-container\">\r\n    <h1>Details</h1>\r\n\r\n    <div>\r\n        <h4>Book</h4>\r\n        <hr />\r\n        <dl class=\"row\">\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 16 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 19 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 22 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 25 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.AuthorName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 28 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Author));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 31 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Author.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 34 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.YearOfIssue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 37 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.YearOfIssue));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 40 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.NumberOfPages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 43 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.NumberOfPages));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 46 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 49 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.PublisherName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 52 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Publisher));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 55 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Publisher.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 58 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 61 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.UserId));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 64 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 67 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 70 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 73 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Category.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 76 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 79 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.CategoryName));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 82 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 85 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 88 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.BookType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 91 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.BookType));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 94 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 97 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 100 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 103 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Language));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 106 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 109 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 112 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Edition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 115 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Edition));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 118 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Dimensions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 121 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Dimensions));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 124 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 127 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Weight));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 130 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Copies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 133 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Copies));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 136 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.Shipping));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 139 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.Shipping));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 142 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.PhotoURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 145 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.PhotoURL));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n            <dt class=\"col-sm-2\">\r\n                ");
#nullable restore
#line 148 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayNameFor(model => model.SoldItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dt>\r\n            <dd class=\"col-sm-10\">\r\n                ");
#nullable restore
#line 151 "D:\Developer\ASP.NET Core\BookStore - Jorgos\BookStore\Views\WishList\Details.cshtml"
           Write(Html.DisplayFor(model => model.SoldItems));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </dd>\r\n        </dl>\r\n    </div>\r\n    <div>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "53a1d8b8a1b89e088a46b9f33a0f8cc01eccaaa319606", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BookStore.Data.Entities.Book> Html { get; private set; }
    }
}
#pragma warning restore 1591
