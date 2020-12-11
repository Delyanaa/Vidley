#pragma checksum "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "637a0aa4be448af6c0293cdc40059a877b34de6c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_MovieForm), @"mvc.1.0.view", @"/Views/Movies/MovieForm.cshtml")]
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
#line 1 "D:\VS_Projects\Vidley\Views\_ViewImports.cshtml"
using Vidley;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\VS_Projects\Vidley\Views\_ViewImports.cshtml"
using Vidley.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\VS_Projects\Vidley\Views\_ViewImports.cshtml"
using Vidley.ViewModels;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"637a0aa4be448af6c0293cdc40059a877b34de6c", @"/Views/Movies/MovieForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c2b4f99b887f4e631a95d0cadd5ed5d8e90588", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_MovieForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MovieFormViewModel>
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
#line 3 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
  
    ViewData["Title"] = "New";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 8 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
 if (Model == null)
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>New Movie</h1>\r\n");
#nullable restore
#line 11 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
}
else
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <h1>Edit Movie</h1>\r\n");
#nullable restore
#line 15 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<hr />\r\n");
#nullable restore
#line 18 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
 using (Html.BeginForm("Save", "Movies"))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 21 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 22 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 26 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 27 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.ReleaseDate, "{0: dd MMM yyyy}", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 31 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.DateAdded));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 32 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.DateAdded, "{0: dd MMM yyyy}", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 36 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.Movie.NumberInStock));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 37 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
   Write(Html.TextBoxFor(m => m.Movie.NumberInStock, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
            WriteLiteral("    <div class=\"form-group\">\r\n        ");
#nullable restore
#line 41 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
   Write(Html.LabelFor(m => m.GenresList));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        ");
#nullable restore
#line 42 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
   Write(Html.DropDownListFor(m=> m.Movie.GenreId, new SelectList(Model.GenresList, "Id", "Name"), "Select a Genre", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 44 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
Write(Html.HiddenFor(m => m.Movie.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("    <button type=\"submit\" class=\"btn btn-lg btn-primary my-2\">Submit</button>\r\n");
#nullable restore
#line 46 "D:\VS_Projects\Vidley\Views\Movies\MovieForm.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("<div>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "637a0aa4be448af6c0293cdc40059a877b34de6c7883", async() => {
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
            WriteLiteral("\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MovieFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591