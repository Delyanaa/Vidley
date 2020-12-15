#pragma checksum "D:\VS_Projects\Vidley\Views\Customers\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ace12d64f0a55ca20aea9e7140abccbf1dfdf580"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Customers_Index), @"mvc.1.0.view", @"/Views/Customers/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ace12d64f0a55ca20aea9e7140abccbf1dfdf580", @"/Views/Customers/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a5c2b4f99b887f4e631a95d0cadd5ed5d8e90588", @"/Views/_ViewImports.cshtml")]
    public class Views_Customers_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Customer>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\VS_Projects\Vidley\Views\Customers\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Customers</h1>\r\n\r\n");
#nullable restore
#line 10 "D:\VS_Projects\Vidley\Views\Customers\Index.cshtml"
Write(Html.ActionLink("New", "New", "Customers", null, new { @class = "btn btn-default my-3" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-hover\" id=\"customersTable\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 15 "D:\VS_Projects\Vidley\Views\Customers\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                Membership\r\n            </th>\r\n            <th></th>\r\n            <th>Delete</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 25 "D:\VS_Projects\Vidley\Views\Customers\Index.cshtml"
         foreach (var item in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
#nullable restore
#line 29 "D:\VS_Projects\Vidley\Views\Customers\Index.cshtml"
               Write(Html.ActionLink(item.Name, "Details", "Customers", new { id = item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 32 "D:\VS_Projects\Vidley\Views\Customers\Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.MembershipType.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
#nullable restore
#line 35 "D:\VS_Projects\Vidley\Views\Customers\Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", "Customers", new { id = item.Id }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    <button class=\"btn-link js-deleteBtn\" data-customer-id =\"");
#nullable restore
#line 38 "D:\VS_Projects\Vidley\Views\Customers\Index.cshtml"
                                                                        Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Delete</button>\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 41 "D:\VS_Projects\Vidley\Views\Customers\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@" 
<script>
    $(document).ready(function () {
        $('#customersTable .js-deleteBtn').click(function () {
            var button = $(this);
            if (confirm(""Are you sure you want to delete this customer?"")) {
                $.ajax({
                    url: ""api/customers/"" + button.attr(""data-customer-id""),
                    method: ""DELETE"",
                    success: function () {
                        button.parents(""tr"").remove();
                    }
                });
            }
        });
    });
</script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Customer>> Html { get; private set; }
    }
}
#pragma warning restore 1591
