#pragma checksum "C:\Users\Lenovo\source\repos\T1708E_Website\T1708E_Website\Views\Student\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d38af6ff002d289fa7d4762365f0ac6f93ded222"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Student_Index), @"mvc.1.0.view", @"/Views/Student/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Student/Index.cshtml", typeof(AspNetCore.Views_Student_Index))]
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
#line 1 "C:\Users\Lenovo\source\repos\T1708E_Website\T1708E_Website\Views\_ViewImports.cshtml"
using T1708E_Website;

#line default
#line hidden
#line 2 "C:\Users\Lenovo\source\repos\T1708E_Website\T1708E_Website\Views\_ViewImports.cshtml"
using T1708E_Website.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d38af6ff002d289fa7d4762365f0ac6f93ded222", @"/Views/Student/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8f30d32c44222d4152b236aaa719f517ceff274c", @"/Views/_ViewImports.cshtml")]
    public class Views_Student_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Lenovo\source\repos\T1708E_Website\T1708E_Website\Views\Student\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(63, 47, true);
            WriteLiteral("\r\n<h2>Student</h2>\r\n<div class=\"alert-success\">");
            EndContext();
            BeginContext(111, 19, false);
#line 7 "C:\Users\Lenovo\source\repos\T1708E_Website\T1708E_Website\Views\Student\Index.cshtml"
                      Write(TempData["message"]);

#line default
#line hidden
            EndContext();
            BeginContext(130, 48, true);
            WriteLiteral("</div>\r\n<div class=\"alert-danger\"></div>\r\n<ul>\r\n");
            EndContext();
#line 10 "C:\Users\Lenovo\source\repos\T1708E_Website\T1708E_Website\Views\Student\Index.cshtml"
     foreach (var student in Model)
    {

#line default
#line hidden
            BeginContext(222, 18, true);
            WriteLiteral("    <li>\r\n        ");
            EndContext();
            BeginContext(241, 18, false);
#line 13 "C:\Users\Lenovo\source\repos\T1708E_Website\T1708E_Website\Views\Student\Index.cshtml"
   Write(student.RollNumber);

#line default
#line hidden
            EndContext();
            BeginContext(259, 3, true);
            WriteLiteral(" - ");
            EndContext();
            BeginContext(263, 12, false);
#line 13 "C:\Users\Lenovo\source\repos\T1708E_Website\T1708E_Website\Views\Student\Index.cshtml"
                         Write(student.Name);

#line default
#line hidden
            EndContext();
            BeginContext(275, 12, true);
            WriteLiteral("\r\n        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 287, "\"", 322, 2);
            WriteAttributeValue("", 294, "/Student/Edit?id=", 294, 17, true);
#line 14 "C:\Users\Lenovo\source\repos\T1708E_Website\T1708E_Website\Views\Student\Index.cshtml"
WriteAttributeValue("", 311, student.Id, 311, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(323, 44, true);
            WriteLiteral(">Edit</a>\r\n        <button class=\"btnDelete\"");
            EndContext();
            BeginWriteAttribute("id", " id=\"", 367, "\"", 383, 1);
#line 15 "C:\Users\Lenovo\source\repos\T1708E_Website\T1708E_Website\Views\Student\Index.cshtml"
WriteAttributeValue("", 372, student.Id, 372, 11, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(384, 29, true);
            WriteLiteral(">Delete</button>\r\n    </li>\r\n");
            EndContext();
#line 17 "C:\Users\Lenovo\source\repos\T1708E_Website\T1708E_Website\Views\Student\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(420, 13, true);
            WriteLiteral("</ul>\r\n\r\n\r\n\r\n");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
