#pragma checksum "C:\Users\aidan\source\repos\CourseRegistration\CourseRegistration\Views\Home\Course.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f1792de86f45e1eda2f4d09cafa60216264ce7fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Course), @"mvc.1.0.view", @"/Views/Home/Course.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Course.cshtml", typeof(AspNetCore.Views_Home_Course))]
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
#line 1 "C:\Users\aidan\source\repos\CourseRegistration\CourseRegistration\Views\_ViewImports.cshtml"
using CourseRegistration;

#line default
#line hidden
#line 2 "C:\Users\aidan\source\repos\CourseRegistration\CourseRegistration\Views\_ViewImports.cshtml"
using CourseRegistration.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f1792de86f45e1eda2f4d09cafa60216264ce7fe", @"/Views/Home/Course.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3eb16f24ef85a29ef666c66fda47f537a0bb78eb", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Course : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 275, true);
            WriteLiteral(@"
<h2>Course</h2>

<table class=""table table-bordered"">
    <thead>
        <tr>
            <th>Course Id</th>
            <th>Course Number</th>
            <th>Course Name</th>
            <th>Course Description</th>

        </tr>
    </thead>
    <tbody>

");
            EndContext();
#line 16 "C:\Users\aidan\source\repos\CourseRegistration\CourseRegistration\Views\Home\Course.cshtml"
         foreach (var item in Model.Courses)
        {

#line default
#line hidden
            BeginContext(332, 50, true);
            WriteLiteral("            <tr>\r\n                <th scope=\"row\">");
            EndContext();
            BeginContext(383, 13, false);
#line 19 "C:\Users\aidan\source\repos\CourseRegistration\CourseRegistration\Views\Home\Course.cshtml"
                           Write(item.CourseId);

#line default
#line hidden
            EndContext();
            BeginContext(396, 27, true);
            WriteLiteral("</th>\r\n                <td>");
            EndContext();
            BeginContext(424, 17, false);
#line 20 "C:\Users\aidan\source\repos\CourseRegistration\CourseRegistration\Views\Home\Course.cshtml"
               Write(item.CourseNumber);

#line default
#line hidden
            EndContext();
            BeginContext(441, 152, true);
            WriteLiteral("</td>\r\n                <td><button type=\"button\" class=\"btn btn-primary btn-block btn-lg\" data-toggle=\"modal\" data-target=\"#myModal\">\r\n                 ");
            EndContext();
            BeginContext(594, 15, false);
#line 22 "C:\Users\aidan\source\repos\CourseRegistration\CourseRegistration\Views\Home\Course.cshtml"
            Write(item.CourseName);

#line default
#line hidden
            EndContext();
            BeginContext(609, 55, true);
            WriteLiteral("\r\n                 </button></td>\r\n                <td>");
            EndContext();
            BeginContext(665, 16, false);
#line 24 "C:\Users\aidan\source\repos\CourseRegistration\CourseRegistration\Views\Home\Course.cshtml"
               Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(681, 28, true);
            WriteLiteral("</td>\r\n\r\n            </tr>\r\n");
            EndContext();
#line 27 "C:\Users\aidan\source\repos\CourseRegistration\CourseRegistration\Views\Home\Course.cshtml"
        }

#line default
#line hidden
            BeginContext(720, 669, true);
            WriteLiteral(@"


    </tbody>

</table>

<div class=""modal"" id=""myModal"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">

            <!-- Modal Header -->
            <div class=""modal-header"">
                <h4 class=""modal-title"">Modal Heading</h4>
                <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>

            </div>

            <div class=""modal-body"">
                
            </div>


            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
            </div>

        </div>
    </div>
</div>


");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
