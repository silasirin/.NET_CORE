#pragma checksum "C:\Users\Sıla Şirin\Desktop\NetCoreFakeRepository\NetCoreFakeRepository\Views\Employee\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "76010b1b46101add8e7501e802aa863a3a3004a8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Employee_Index), @"mvc.1.0.view", @"/Views/Employee/Index.cshtml")]
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
#line 1 "C:\Users\Sıla Şirin\Desktop\NetCoreFakeRepository\NetCoreFakeRepository\Views\_ViewImports.cshtml"
using NetCoreFakeRepository.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"76010b1b46101add8e7501e802aa863a3a3004a8", @"/Views/Employee/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abfbf72baf508f62fd35fd1b16a6cc2e1227866e", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_Employee_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Employee>>
    #nullable disable
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\Sıla Şirin\Desktop\NetCoreFakeRepository\NetCoreFakeRepository\Views\Employee\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<table class=\"table table-striped\">\r\n    <thread>\r\n        <tr>\r\n            <th>#</th>\r\n            <th>ID</th>\r\n            <th>Title</th>\r\n            <th>FirstName</th>\r\n            <th>LastName</th>\r\n        </tr>\r\n    </thread>\r\n    <tbody>\r\n");
#nullable restore
#line 18 "C:\Users\Sıla Şirin\Desktop\NetCoreFakeRepository\NetCoreFakeRepository\Views\Employee\Index.cshtml"
         foreach (var employee in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("          <tr>\n              <td>#</td>\n              <td>");
#nullable restore
#line 22 "C:\Users\Sıla Şirin\Desktop\NetCoreFakeRepository\NetCoreFakeRepository\Views\Employee\Index.cshtml"
             Write(employee.ID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 23 "C:\Users\Sıla Şirin\Desktop\NetCoreFakeRepository\NetCoreFakeRepository\Views\Employee\Index.cshtml"
             Write(employee.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 24 "C:\Users\Sıla Şirin\Desktop\NetCoreFakeRepository\NetCoreFakeRepository\Views\Employee\Index.cshtml"
             Write(employee.FirstName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n              <td>");
#nullable restore
#line 25 "C:\Users\Sıla Şirin\Desktop\NetCoreFakeRepository\NetCoreFakeRepository\Views\Employee\Index.cshtml"
             Write(employee.LastName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n          </tr>\n");
#nullable restore
#line 27 "C:\Users\Sıla Şirin\Desktop\NetCoreFakeRepository\NetCoreFakeRepository\Views\Employee\Index.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n\r\n");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Employee>> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
