#pragma checksum "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "aa711d89552f3413732c881ff20713a161fccbef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Student_Views_PreRegistrationCourse__CourseTable), @"mvc.1.0.view", @"/Areas/Student/Views/PreRegistrationCourse/_CourseTable.cshtml")]
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
#line 1 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\_ViewImports.cshtml"
using UMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\_ViewImports.cshtml"
using UMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"aa711d89552f3413732c881ff20713a161fccbef", @"/Areas/Student/Views/PreRegistrationCourse/_CourseTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e50ace8fe3b4184cf126cd47ae178edfbfa883", @"/Areas/Student/Views/_ViewImports.cshtml")]
    public class Areas_Student_Views_PreRegistrationCourse__CourseTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UMS.Models.ViewModels.PreRegistrationVM>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"

<div class=""table-responsive"">
    <table class=""table table-hover table-bordered"">
        <thead class=""table-secondary "">
            <tr class=""table-head"">
                <th>#</th>
                <th>Code</th>
                <th>Title</th>
                <th>Credits</th>
                <th></th>
            </tr>
        </thead>
        <tbody class=""table-body"">
");
#nullable restore
#line 17 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
             if (Model.CourseList.Count() > 0)
            {
                var i = 0;
                foreach (var course in Model.CourseList)
                {
                    i++;

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>\r\n                <td>");
#nullable restore
#line 24 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
               Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n\r\n                <td>");
#nullable restore
#line 26 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
               Write(course.Initial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 27 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
               Write(course.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>");
#nullable restore
#line 28 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
               Write(course.CourseProtoType.Credit);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                <td>\r\n");
#nullable restore
#line 30 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
                     if (User.IsInRole("Student"))
                    {
                        if (course.IsTaken == true)
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input class=\"form-control select\" checked data-id=\"");
#nullable restore
#line 36 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
                                                                           Write(course.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"checkbox\" />\r\n");
#nullable restore
#line 37 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"


                        }
                        else
                        {



#line default
#line hidden
#nullable disable
            WriteLiteral("                            <input class=\"form-control select\" data-id=\"");
#nullable restore
#line 44 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
                                                                   Write(course.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\" type=\"checkbox\" />\r\n");
#nullable restore
#line 45 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"


                        }
                    }
                    else
                    {


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <label>");
#nullable restore
#line 52 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
                          Write(course.Count);

#line default
#line hidden
#nullable disable
            WriteLiteral("</label>\r\n");
#nullable restore
#line 53 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n\r\n                </tr>\r\n");
#nullable restore
#line 58 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <tr>
                    <td></td>
                    <td></td>                 
                    <td class=""text-danger"">No Course  Available</td>
                    <td></td>
                    <td></td>
                </tr>
");
#nullable restore
#line 69 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n\r\n\r\n<script>\r\n    $(document).ready(function () {\r\n        $(\".select\").click(function () {\r\n            if ($(this).is(\":checked\")) {\r\n                 $.ajax({\r\n                    url: \'");
#nullable restore
#line 81 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
                     Write(Url.Action("SelectPreregistationCourse", "PreRegistrationCourse"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                    type: \"POST\",\r\n                    data: {\r\n                        userId: \'");
#nullable restore
#line 84 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
                            Write(Model.User.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                        courseId: $(this).attr(""data-id"")
                    }
                }).done(function (response) {
                    $("".loader"").fadeOut(1000);
                    $("".wrapper"").fadeIn(1000);
                    toastr.success(""Successfully Added"");
                    $(""#PreCourseList"").html(response);
                    
                })
              
            }
           else{
                  $.ajax({
                    url: '");
#nullable restore
#line 98 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
                     Write(Url.Action("DeletePreregistationCourse", "PreRegistrationCourse"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                    type: \"POST\",\r\n                    data: {\r\n                        userId: \'");
#nullable restore
#line 101 "E:\Project\New folder\UMS\UMS\Areas\Student\Views\PreRegistrationCourse\_CourseTable.cshtml"
                            Write(Model.User.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                        courseId: $(this).attr(""data-id"")
                    }
                }).done(function (response) {
                    $("".loader"").fadeOut(1000);
                    $("".wrapper"").fadeIn(1000);
                    toastr.success(""Successfully Removed"");
                    $(""#PreCourseList"").html(response);
                    
                })
               
            }
        });
    });
</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UMS.Models.ViewModels.PreRegistrationVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
