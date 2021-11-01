#pragma checksum "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "eb0350686659e21a8de47278a3c36da95831bcc3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Section__SectionTable), @"mvc.1.0.view", @"/Areas/Admin/Views/Section/_SectionTable.cshtml")]
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
#line 1 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\_ViewImports.cshtml"
using UMS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\_ViewImports.cshtml"
using UMS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"eb0350686659e21a8de47278a3c36da95831bcc3", @"/Areas/Admin/Views/Section/_SectionTable.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"09e50ace8fe3b4184cf126cd47ae178edfbfa883", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Section__SectionTable : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<UMS.Models.ViewModels.SectionVM>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral(@"<div class=""table-responsive "">
    <table class=""table table-hover table-bordered"">
        <thead class=""table-secondary"">
            <tr>
                <th>#</th>
                <th>Name</th>
                <th>Initial</th>
                <th>Actions</th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 14 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
             if (Model.SectionList.Count() > 0)
            {
                int i = 0;
                foreach (var sectionObj in Model.SectionList)
                {
                    i++;


#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td>");
#nullable restore
#line 22 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                        Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 23 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                       Write(sectionObj.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>");
#nullable restore
#line 24 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                       Write(sectionObj.Initial);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                        <td>\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "eb0350686659e21a8de47278a3c36da95831bcc35462", async() => {
                WriteLiteral("<i class=\"fas fa-edit\"></i>");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 26 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                                                                             WriteLiteral(sectionObj.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            <button class=\"btn btn-danger deleteBtn\" data-id=\"");
#nullable restore
#line 27 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                                                                         Write(sectionObj.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("\"><i class=\"fas fa-trash-alt\"></i></button>\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 30 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td></td>\r\n                    <td ></td>\r\n                    <td class=\"text-danger\">No Sections Available</td>\r\n                    <td></td>\r\n                </tr>\r\n");
#nullable restore
#line 40 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n</div>\r\n\r\n<div class=\"text-center\">\r\n");
#nullable restore
#line 46 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
     if (Model.Pager != null && Model.Pager.TotalPages > 1)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 48 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
         if (Model.Pager.CurrentPage > 1)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-outline-info page-buttons\" data-pageNo=\"1\">First</button>\r\n            <button class=\"btn btn-outline-info page-buttons\" data-pageNo=\"");
#nullable restore
#line 51 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                                                                       Write(Model.Pager.CurrentPage-1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Previous</button>\r\n");
#nullable restore
#line 52 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 52 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
         
        for (int page = Model.Pager.StartPage; page <= Model.Pager.EndPage; page++)
        {
            string activeClass = Model.Pager.CurrentPage == page ? "active bg-info" : "";

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button");
            BeginWriteAttribute("class", " class=\"", 2023, "\"", 2077, 4);
            WriteAttributeValue("", 2031, "btn", 2031, 3, true);
            WriteAttributeValue(" ", 2034, "btn-outline-info", 2035, 17, true);
            WriteAttributeValue(" ", 2051, "page-buttons", 2052, 13, true);
#nullable restore
#line 56 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
WriteAttributeValue(" ", 2064, activeClass, 2065, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" data-pageNo=\"");
#nullable restore
#line 56 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                                                                                    Write(page);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">");
#nullable restore
#line 56 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                                                                                             Write(page);

#line default
#line hidden
#nullable disable
            WriteLiteral("</button>\r\n");
#nullable restore
#line 57 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
        }
        if (Model.Pager.CurrentPage < Model.Pager.EndPage)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <button class=\"btn btn-outline-info page-buttons\" data-pageNo=\"");
#nullable restore
#line 60 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                                                                       Write(Model.Pager.CurrentPage+1);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Next</button>\r\n            <button class=\"btn btn-outline-info page-buttons\" data-pageNo=\"");
#nullable restore
#line 61 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                                                                       Write(Model.Pager.EndPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("\">Last</button>\r\n");
#nullable restore
#line 62 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>

<script>
    $(document).ready(function () {

        $("".deleteBtn"").click(function () {
            swal({
                title: ""Are you sure that you want to delete this data"",
                text: ""If you once delete this you can not restore it!"",
                icon: ""warning"",
                dangerMode: true,
                buttons: true
            }).then((willDelete) => {
                if (willDelete) {
                    $.ajax({
                        url: '");
#nullable restore
#line 79 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                         Write(Url.Action("Delete", "Section"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                        type: ""POST"",
                        data: {
                            id: $(this).attr(""data-id"")
                        }
                    }).done(function (response) {
                        swal(""Successfully Deleted"", {
                            icon: ""success""
                        });
                        $("".loader"").fadeOut(1000);
                        $("".wrapper"").fadeIn(1000);
                        $(""#table-container"").html(response);
                    }).fail(function (xhr) {
                        $("".loader"").fadeOut(1000);
                        $("".wrapper"").fadeIn(1000);
                        toastr.error(""Something went wrong"");
                    })
                }
            })
        });

        $("".page-buttons"").click(function () {
            $.ajax({
                url: '");
#nullable restore
#line 102 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                 Write(Url.Action("SectionTable", "Section"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\',\r\n                data: {\r\n                    pageNo: $(this).attr(\"data-pageNo\"),\r\n                    searchValue: \'");
#nullable restore
#line 105 "E:\Project\New folder\UMS\UMS\Areas\Admin\Views\Section\_SectionTable.cshtml"
                             Write(Model.Search);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"'
                }
            }).done(function (response) {
                $("".loader"").fadeOut(1000);
                $("".wrapper"").fadeIn(1000);
                $(""#table-container"").html(response);
            }).fail(function (xhr) {
                $("".loader"").fadeOut(1000);
                $("".wrapper"").fadeIn(1000);
                toastr.error(""Something Went Wrong"");
            })
        })
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<UMS.Models.ViewModels.SectionVM> Html { get; private set; }
    }
}
#pragma warning restore 1591
