#pragma checksum "C:\Users\burha\OneDrive\Skrivebord\Lesson05_MbmStore_solution (1)\Lesson05_MbmStore_solution\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b7b2ec946ca73f83e8a793720d9e7716bf2900c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__ProductSummaryMovie), @"mvc.1.0.view", @"/Views/Shared/_ProductSummaryMovie.cshtml")]
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
#line 2 "C:\Users\burha\OneDrive\Skrivebord\Lesson05_MbmStore_solution (1)\Lesson05_MbmStore_solution\MbmStore\Views\_ViewImports.cshtml"
using MbmStore.Models.ViewModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\burha\OneDrive\Skrivebord\Lesson05_MbmStore_solution (1)\Lesson05_MbmStore_solution\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
using MbmStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b7b2ec946ca73f83e8a793720d9e7716bf2900c", @"/Views/Shared/_ProductSummaryMovie.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3396235712e6e09768ab549336312d18e557bac4", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__ProductSummaryMovie : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MbmStore.Models.Movie>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"row\">\r\n    <div class=\"col-md-2\">\r\n        <img");
            BeginWriteAttribute("src", " src=\"", 115, "\"", 144, 2);
            WriteAttributeValue("", 121, "/Images/", 121, 8, true);
#nullable restore
#line 5 "C:\Users\burha\OneDrive\Skrivebord\Lesson05_MbmStore_solution (1)\Lesson05_MbmStore_solution\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
WriteAttributeValue("", 129, Model.ImageUrl, 129, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 145, "\"", 163, 1);
#nullable restore
#line 5 "C:\Users\burha\OneDrive\Skrivebord\Lesson05_MbmStore_solution (1)\Lesson05_MbmStore_solution\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
WriteAttributeValue("", 151, Model.Title, 151, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"width:100px\" />\r\n    </div>\r\n    <div class=\"col-md-4\">\r\n        <strong>Title:</strong> ");
#nullable restore
#line 8 "C:\Users\burha\OneDrive\Skrivebord\Lesson05_MbmStore_solution (1)\Lesson05_MbmStore_solution\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
                           Write(Model.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /> <strong>Director:</strong> ");
#nullable restore
#line 8 "C:\Users\burha\OneDrive\Skrivebord\Lesson05_MbmStore_solution (1)\Lesson05_MbmStore_solution\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
                                                                         Write(Model.Director);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br /> <strong>Price:</strong> ");
#nullable restore
#line 8 "C:\Users\burha\OneDrive\Skrivebord\Lesson05_MbmStore_solution (1)\Lesson05_MbmStore_solution\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
                                                                                                                       Write(Model.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n    </div>\r\n    ");
#nullable restore
#line 10 "C:\Users\burha\OneDrive\Skrivebord\Lesson05_MbmStore_solution (1)\Lesson05_MbmStore_solution\MbmStore\Views\Shared\_ProductSummaryMovie.cshtml"
Write(await Html.PartialAsync("_AddToCartButton", (Product)Model));

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MbmStore.Models.Movie> Html { get; private set; }
    }
}
#pragma warning restore 1591
