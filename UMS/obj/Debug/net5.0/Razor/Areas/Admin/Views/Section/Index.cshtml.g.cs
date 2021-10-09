#pragma checksum "E:\Project\UMS\UMS\Areas\Admin\Views\Section\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c8650687d55e7112051609a4d9842397fb3a3aa1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Section_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Section/Index.cshtml")]
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
#line 1 "E:\Project\UMS\UMS\Areas\Admin\Views\_ViewImports.cshtml"
using UMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\UMS\UMS\Areas\Admin\Views\_ViewImports.cshtml"
using UMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c8650687d55e7112051609a4d9842397fb3a3aa1", @"/Areas/Admin/Views/Section/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e50ace8fe3b4184cf126cd47ae178edfbfa883", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Section_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success form-control"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Upsert", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "E:\Project\UMS\UMS\Areas\Admin\Views\Section\Index.cshtml"
  
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<div class=\"container\" id=\"main-container\">\r\n    <span id=\"messageBox\" class=\"d-none\">");
#nullable restore
#line 6 "E:\Project\UMS\UMS\Areas\Admin\Views\Section\Index.cshtml"
                                    Write(TempData["message"]);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
    <h2 class=""text-primary text-center border-bottom"">Sections</h2>
    <div class=""row pt-4"">
        <div class=""col-6"">
            <div class=""input-group"">
                <input class=""form-control"" placeholder=""Search..."" id=""search"" />
                <div class=""input-group-prepend"">
                    <div class=""input-group-text""><i class=""fas fa-search""></i></div>
                </div>
            </div>
        </div>
        <div class=""col-3"">
            <input class=""btn btn-primary form-control"" type=""submit"" value=""Reset"" id=""resetBtn"" />
        </div>
        <div class=""col-3"">
            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c8650687d55e7112051609a4d9842397fb3a3aa14950", async() => {
                WriteLiteral("<i class=\"fas fa-plus\"></i> Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        </div>\r\n        <div id=\"table-container\" class=\"col-12\">\r\n\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n\r\n    <script>\r\n\r\n        $(document).ready(function () {\r\n            getData();\r\n        });\r\n        function getData() {\r\n            $.ajax({\r\n                url: \'");
#nullable restore
#line 38 "E:\Project\UMS\UMS\Areas\Admin\Views\Section\Index.cshtml"
                 Write(Url.Action("SectionTable", "Section"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: ""GET""
            }).done(function (response) {
                $("".loader"").fadeOut(1000);
                $("".wrapper"").fadeIn(1000);
                $(""#table-container"").html(response);
            }).fail(function (xhr) {
                $("".loader"").fadeOut(1000);
                $("".wrapper"").fadeIn(1000);
                toastr.error(""Something went wrong"");
            })
        }


        $(""#search"").keyup(function () {
            var searchValue = $(""#search"").val();
            $.ajax({
                url: '");
#nullable restore
#line 55 "E:\Project\UMS\UMS\Areas\Admin\Views\Section\Index.cshtml"
                 Write(Url.Action("SectionTable", "Section"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                type: ""GET"",
                data: {
                    searchValue: searchValue
                }
            }).done(function (response) {
                $("".loader"").fadeOut(1000);
                $("".wrapper"").fadeIn(1000);
                $(""#table-container"").html(response);
            }).fail(function (xhr) {
                $("".loader"").fadeOut(1000);
                $("".wrapper"").fadeIn(1000);
                toastr.error(""Something went error"");
            })
        });

        var messageText = $(""#messageBox"").text();
        if (messageText != """") {
            toastr.success(messageText);
            $(""#messageBox"").text('');
        }
        

        $(""#resetBtn"").click(function () {
            var searchValue = $(""#search"").val();
            $(""#search"").val('');
            if (searchValue != """") {
                $.ajax({
                    url: '");
#nullable restore
#line 83 "E:\Project\UMS\UMS\Areas\Admin\Views\Section\Index.cshtml"
                     Write(Url.Action("SectionTable", "Section"));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"',
                    type: ""GET""
                }).done(function (response) {
                    $("".loader"").fadeOut(1000);
                    $("".wrapper"").fadeIn(1000);
                    $(""#table-container"").html(response);
                }).fail(function (xhr) {
                    $("".loader"").fadeOut(1000);
                    $("".wrapper"").fadeIn(1000);
                    toastr.error(""Something went error"");
                })
            }
            else {
                $("".loader"").fadeOut(1000);
                $("".wrapper"").fadeIn(1000);
                toastr.error(""Nothing to Reset"");
            }

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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
