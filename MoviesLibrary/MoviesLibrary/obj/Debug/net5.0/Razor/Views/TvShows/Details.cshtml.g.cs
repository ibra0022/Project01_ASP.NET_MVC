#pragma checksum "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\TvShows\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f75cb03d4f367f351939f652ec616b88e7a36cfd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TvShows_Details), @"mvc.1.0.view", @"/Views/TvShows/Details.cshtml")]
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
#line 1 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\_ViewImports.cshtml"
using MoviesLibrary;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\_ViewImports.cshtml"
using MoviesLibrary.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f75cb03d4f367f351939f652ec616b88e7a36cfd", @"/Views/TvShows/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f8ed328b0317bdcdaaecd6425e5eeefcf7b9c5f7", @"/Views/_ViewImports.cshtml")]
    public class Views_TvShows_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\TvShows\Details.cshtml"
  

    var tvShow = (TvShowModel) ViewData["TvShow"];

#line default
#line hidden
#nullable disable
            WriteLiteral("    <img");
            BeginWriteAttribute("src", " src=\"", 66, "\"", 85, 1);
#nullable restore
#line 4 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\TvShows\Details.cshtml"
WriteAttributeValue("", 72, tvShow.Image, 72, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" height=\"200px\" alt=\"Not supported\">\r\n    <h3 class=\"align-middle\" style=\"color: white\">ID: ");
#nullable restore
#line 5 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\TvShows\Details.cshtml"
                                                 Write(tvShow.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3 class=\"align-middle\" style=\"color: white\">Name: ");
#nullable restore
#line 6 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\TvShows\Details.cshtml"
                                                   Write(tvShow.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3 class=\"align-middle\" style=\"color: white\">Year: ");
#nullable restore
#line 7 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\TvShows\Details.cshtml"
                                                   Write(tvShow.Year);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n    <h3 class=\"align-middle\" style=\"color: white\">Summury: ");
#nullable restore
#line 8 "D:\Business\المعسكر\الاسبوع 6\DotNET Project\Project01_ASP.NET_MVC\MoviesLibrary\MoviesLibrary\Views\TvShows\Details.cshtml"
                                                      Write(tvShow.Summury);

#line default
#line hidden
#nullable disable
            WriteLiteral(". </h3>\r\n");
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
