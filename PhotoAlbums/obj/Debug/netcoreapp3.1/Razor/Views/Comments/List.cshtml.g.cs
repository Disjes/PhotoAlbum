#pragma checksum "C:\Users\david.robles\source\repos\PhotoAlbums\PhotoAlbums\Views\Comments\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3509ea8082aebc864f072e7a18a67e7d43ae08ef"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Comments_List), @"mvc.1.0.view", @"/Views/Comments/List.cshtml")]
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
#line 1 "C:\Users\david.robles\source\repos\PhotoAlbums\PhotoAlbums\Views\_ViewImports.cshtml"
using PhotoAlbums;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\david.robles\source\repos\PhotoAlbums\PhotoAlbums\Views\_ViewImports.cshtml"
using PhotoAlbums.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3509ea8082aebc864f072e7a18a67e7d43ae08ef", @"/Views/Comments/List.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bf09a14ab749e208e3697ea1a58cf6942bd5bf1", @"/Views/_ViewImports.cshtml")]
    public class Views_Comments_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Comment>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<table class=\"styled-table\">\r\n    <thead>\r\n        <tr>\r\n            <th>Name</th>\r\n            <th>Email</th>\r\n            <th>Body</th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 12 "C:\Users\david.robles\source\repos\PhotoAlbums\PhotoAlbums\Views\Comments\List.cshtml"
          
            bool active = false;
            foreach (var comment in Model)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr");
            BeginWriteAttribute("class", " class=\"", 329, "\"", 366, 1);
#nullable restore
#line 16 "C:\Users\david.robles\source\repos\PhotoAlbums\PhotoAlbums\Views\Comments\List.cshtml"
WriteAttributeValue("", 337, active ? "active-row" : "", 337, 29, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                    <td>");
#nullable restore
#line 17 "C:\Users\david.robles\source\repos\PhotoAlbums\PhotoAlbums\Views\Comments\List.cshtml"
                   Write(comment.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 18 "C:\Users\david.robles\source\repos\PhotoAlbums\PhotoAlbums\Views\Comments\List.cshtml"
                   Write(comment.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 19 "C:\Users\david.robles\source\repos\PhotoAlbums\PhotoAlbums\Views\Comments\List.cshtml"
                   Write(comment.body);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 21 "C:\Users\david.robles\source\repos\PhotoAlbums\PhotoAlbums\Views\Comments\List.cshtml"
                active = active ? false : true;
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("        <!-- and so on... -->\r\n    </tbody>\r\n</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Comment>> Html { get; private set; }
    }
}
#pragma warning restore 1591
