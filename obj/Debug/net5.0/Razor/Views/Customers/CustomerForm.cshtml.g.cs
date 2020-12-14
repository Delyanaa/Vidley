#pragma checksum "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ed075e98e3347513439a9bede43912256b324c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_CustomerForm), @"mvc.1.0.view", @"/Views/Customers/CustomerForm.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ed075e98e3347513439a9bede43912256b324c5", @"/Views/Customers/CustomerForm.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c2b4f99b887f4e631a95d0cadd5ed5d8e90588", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_CustomerForm : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CustomerFormViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-validation/dist/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
  
    ViewData["Title"] = "New";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<h1>New Customer</h1>\r\n\r\n\r\n<div class=\"col-5\">\r\n");
#nullable restore
#line 13 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
     using (Html.BeginForm("Save", "Customers"))
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 15 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
   Write(Html.ValidationSummary(true, "Correct the fields"));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 17 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
       Write(Html.LabelFor(m => m.Customer.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("*\r\n            ");
#nullable restore
#line 18 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
       Write(Html.TextBoxFor(m => m.Customer.Name, new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 19 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
       Write(Html.ValidationMessageFor(m => m.Customer.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 22 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
       Write(Html.LabelFor(m => m.Customer.Birthday));

#line default
#line hidden
#nullable disable
            WriteLiteral("*\r\n            ");
#nullable restore
#line 23 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
       Write(Html.TextBoxFor(m => m.Customer.Birthday, "{0: d MMM yyyy}", new { @class = "form-control" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 24 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
       Write(Html.ValidationMessageFor(m => m.Customer.Birthday, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 27 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
       Write(Html.LabelFor(m => m.Customer.MembershipTypeId));

#line default
#line hidden
#nullable disable
            WriteLiteral("*\r\n            ");
#nullable restore
#line 28 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
       Write(Html.DropDownListFor(
               m => m.Customer.MembershipTypeId,
               new SelectList(Model.MembershipTypesList, "Id", "Name"),
               "Select Membership Type",
               new { @class = "form-control" }
           ));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            ");
#nullable restore
#line 34 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
       Write(Html.ValidationMessageFor(m => m.Customer.MembershipTypeId, "", new { @class = "text-danger" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n        <div class=\"checkbox\">\r\n            <label>\r\n                ");
#nullable restore
#line 38 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
           Write(Html.CheckBoxFor(m => m.Customer.IsSubscribeToNewsletter));

#line default
#line hidden
#nullable disable
            WriteLiteral(" Subscribe to NewsLetter?\r\n            </label>\r\n        </div>\r\n");
#nullable restore
#line 41 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
   Write(Html.HiddenFor(m => m.Customer.Id));

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
                                ;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <button type=\"submit\" class=\"btn btn-lg\">Submit</button>\r\n");
#nullable restore
#line 44 "D:\VS_Projects\Vidley\Views\Customers\CustomerForm.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ed075e98e3347513439a9bede43912256b324c58371", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CustomerFormViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
