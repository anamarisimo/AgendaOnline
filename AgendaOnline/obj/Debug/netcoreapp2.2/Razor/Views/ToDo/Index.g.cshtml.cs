#pragma checksum "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5018c448d713aa48bf26b32c8c825aa913b675d2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDo_Index), @"mvc.1.0.view", @"/Views/ToDo/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDo/Index.cshtml", typeof(AspNetCore.Views_ToDo_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5018c448d713aa48bf26b32c8c825aa913b675d2", @"/Views/ToDo/Index.cshtml")]
    public class Views_ToDo_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<AgendaOnline.ViewModels.ToDoItemViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(62, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml"
  
    ViewData["Title"] = "Tasks";

#line default
#line hidden
            BeginContext(101, 5, true);
            WriteLiteral("\n<h2>");
            EndContext();
            BeginContext(107, 17, false);
#line 7 "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml"
Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(124, 107, true);
            WriteLiteral("</h2>\n\n<div class=\"jumbotron\">\n    <p><a asp-action=\"Create\">Create New</a></p>\n\n    <table class=\"table\">\n");
            EndContext();
            BeginContext(773, 17, true);
            WriteLiteral("\n        <tbody>\n");
            EndContext();
#line 24 "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml"
         foreach (var item in Model) {

#line default
#line hidden
            BeginContext(829, 37, true);
            WriteLiteral("            <tr>\n                <td>");
            EndContext();
            BeginContext(867, 40, false);
#line 26 "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
            EndContext();
            BeginContext(907, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(934, 46, false);
#line 27 "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Description));

#line default
#line hidden
            EndContext();
            BeginContext(980, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1007, 39, false);
#line 28 "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(1046, 26, true);
            WriteLiteral("</td>\n                <td>");
            EndContext();
            BeginContext(1073, 39, false);
#line 29 "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.Done));

#line default
#line hidden
            EndContext();
            BeginContext(1112, 67, true);
            WriteLiteral("</td>\n                <td>\n                    <a asp-action=\"Edit\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", "    asp-route-id=\"", 1179, "\"", 1205, 1);
#line 31 "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml"
WriteAttributeValue("", 1197, item.ID, 1197, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1206, 55, true);
            WriteLiteral(">Edit</a> |\n                    <a asp-action=\"Details\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 1261, "\"", 1284, 1);
#line 32 "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml"
WriteAttributeValue("", 1276, item.ID, 1276, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1285, 57, true);
            WriteLiteral(">Details</a> |\n                    <a asp-action=\"Delete\"");
            EndContext();
            BeginWriteAttribute("asp-route-id", "  asp-route-id=\"", 1342, "\"", 1366, 1);
#line 33 "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml"
WriteAttributeValue("", 1358, item.ID, 1358, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(1367, 52, true);
            WriteLiteral(">Delete</a>\n                </td>\n            </tr>\n");
            EndContext();
#line 36 "/home/ana/RiderProjects/AgendaOnline/AgendaOnline/Views/ToDo/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(1429, 31, true);
            WriteLiteral("        </tbody>\n    </table>\n\n");
            EndContext();
            BeginContext(1564, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<AgendaOnline.ViewModels.ToDoItemViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591