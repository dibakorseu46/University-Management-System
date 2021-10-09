#pragma checksum "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "18bb7d5649c5b9c97eee3a612a7c1ce93457d833"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Student_Views_Registration_Index), @"mvc.1.0.view", @"/Areas/Student/Views/Registration/Index.cshtml")]
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
#line 1 "E:\Project\UMS\UMS\Areas\Student\Views\_ViewImports.cshtml"
using UMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\UMS\UMS\Areas\Student\Views\_ViewImports.cshtml"
using UMS.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"18bb7d5649c5b9c97eee3a612a7c1ce93457d833", @"/Areas/Student/Views/Registration/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e50ace8fe3b4184cf126cd47ae178edfbfa883", @"/Areas/Student/Views/_ViewImports.cshtml")]
    public class Areas_Student_Views_Registration_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UMS.Models.Models.Activity>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<div class=\"container\" id=\"main-container\">\r\n    <h2 class=\"text-center text-primary border-bottom\">Registration</h2>\r\n    <div class=\"row mt-4\">\r\n");
#nullable restore
#line 12 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
         if (User.IsInRole("Student"))
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"col-12 row border mb-4 py-3\">\r\n");
#nullable restore
#line 15 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
             if (Model.StartDate <= DateTime.Now && DateTime.Now <= Model.EndDate && Model.IsActive == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-12"">
                    <h2 class=""ml-2"">Registration Course</h2>
                </div>
                <div id=""RegisCourseList"" class=""col-12"">

                </div>
                <div class=""col-12 border py-5"">
                    <div class=""col-6"">
                        <div class=""input-group"">
                            <input class=""form-control"" placeholder=""Search..."" id=""search"" />
                            <div class=""input-group-prepend"">
                                <div class=""input-group-text""><i class=""fas fa-search""></i></div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-12"" id=""CourseList"">

                    </div>
                </div>
");
#nullable restore
#line 36 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
              
            }
            else if (Model.IsActive == true)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"col-12 border py-5\">\r\n                    <div class=\"alert alert-success\" role=\"alert\">\r\n                        <p class=\"text-center\">Your registratoion start form ");
#nullable restore
#line 42 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
                                                                        Write(Model.StartDate);

#line default
#line hidden
#nullable disable
            WriteLiteral(" to ");
#nullable restore
#line 42 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
                                                                                            Write(Model.EndDate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                    </div>\r\n                </div>\r\n");
#nullable restore
#line 45 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <div class=\"alert alert-danger\" role=\"alert\">\r\n                    <p class=\"text-center\">Info: Your registration start time is not yet declared. For more information contact your coordinator. </p>\r\n                </div>\r\n");
#nullable restore
#line 51 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </div>\r\n");
#nullable restore
#line 53 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
         }
         else
         {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                <div class=""col-12 border py-5"">
                    <div class=""col-6"">
                        <div class=""input-group"">
                            <input class=""form-control"" placeholder=""Search..."" id=""search"" />
                            <div class=""input-group-prepend"">
                                <div class=""input-group-text""><i class=""fas fa-search""></i></div>
                            </div>
                        </div>
                    </div>
                    <div class=""col-4""></div>
                    <div class=""col-12"" id=""CourseList"">

                    </div>
                </div>
");
#nullable restore
#line 70 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n");
#nullable restore
#line 80 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
           
            bool isTrue = (Model.StartDate <= DateTime.Now && DateTime.Now <= Model.EndDate && Model.IsActive == true);
        

#line default
#line hidden
#nullable disable
                WriteLiteral("        \r\n        var execute =\'");
#nullable restore
#line 84 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
                 Write(isTrue);

#line default
#line hidden
#nullable disable
                WriteLiteral("\';\r\n            \r\n        if (\'");
#nullable restore
#line 86 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
        Write(User.IsInRole("Student"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"')
        {
            if (execute == 'True') {
                
                getCourseData();
                getRegisCourseData();
                $("".loader"").fadeOut(1000);
                $("".wrapper"").fadeIn(1000);
            }
            else {
               
                $("".loader"").fadeOut(1000);
                $("".wrapper"").fadeIn(1000);

            }
        }

        function getRegisCourseData() {
                $.ajax({
                    url: '");
#nullable restore
#line 105 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
                     Write(Url.Action("SelectRegisCourseTable", "Registration"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    type: ""GET""
                }).done(function (response) {
                    $("".loader"").fadeOut(1000);
                    $("".wrapper"").fadeIn(1000);
                    $(""#RegisCourseList"").html(response);
                }).fail(function (xhr) {
                    $("".loader"").fadeOut(1000);
                    $("".wrapper"").fadeIn(1000);
                    toastr.error(""Something went wrong"");
                });
            }

            function getCourseData() {
                $.ajax({
                    url: '");
#nullable restore
#line 120 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
                     Write(Url.Action("CourseTable", "Registration"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    type: ""GET""
                }).done(function (response) {
                    $("".loader"").fadeOut(1000);
                    $("".wrapper"").fadeIn(1000);
                    $(""#CourseList"").html(response);
                }).fail(function (xhr) {
                    $("".loader"").fadeOut(1000);
                    $("".wrapper"").fadeIn(1000);
                    toastr.error(""Something went wrong"");
                })
            }
    






        $(""#search"").click(function () {
            var search = $(""#search"").val();
            $.ajax({
                url: '");
#nullable restore
#line 142 "E:\Project\UMS\UMS\Areas\Student\Views\Registration\Index.cshtml"
                 Write(Url.Action("CourseTable", "Registration"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: ""GET"",
                data: {
                    searchValue: search
                }
            }).done(function (response) {
                $("".loader"").fadeOut(1000);
                $("".wrapper"").fadeIn(1000);
                $(""#CourseList"").html(response);
            }).fail(function (xhr) {
                $("".loader"").fadeOut(1000);
                $("".wrapper"").fadeIn(1000);
                toastr.error(""Something went wrong"");
            })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UMS.Models.Models.Activity> Html { get; private set; }
    }
}
#pragma warning restore 1591