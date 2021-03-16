#pragma checksum "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "faf27278631d09246c303b3290b20457a5c365a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Endpoints), @"mvc.1.0.view", @"/Views/Home/Endpoints.cshtml")]
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
#line 1 "D:\Learning\TestNUnit\TestNUnit\Views\_ViewImports.cshtml"
using TestNUnit;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Learning\TestNUnit\TestNUnit\Views\_ViewImports.cshtml"
using TestNUnit.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
using Microsoft.AspNetCore.Mvc.ApplicationModels;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
using Microsoft.AspNetCore.Mvc.RazorPages;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
using Microsoft.AspNetCore.Routing;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"faf27278631d09246c303b3290b20457a5c365a9", @"/Views/Home/Endpoints.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8935919d5dd3a1d19fff757d9d171882bf16dfcf", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Endpoints : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
  
    ViewData["Title"] = "Endpoints";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 10 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
  
    var endpoints = EndpointsDataSource.Endpoints.ToList();

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<table class=""table"">
    <thead class=""thead-dark"">
    <tr>
        <th scope=""col"">Order</th>
        <th scope=""col"">Display Name</th>
        <th scope=""col"">Route Pattern</th>
        <th scope=""col"">Metadata</th>
    </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 24 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
     foreach (var endpoint in endpoints)
    {
        var routeEndpoint = endpoint as RouteEndpoint;

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 28 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
           Write(routeEndpoint?.Order);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 29 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
           Write(endpoint.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 30 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
           Write(routeEndpoint?.RoutePattern.RawText);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>\r\n                <ul>\r\n");
#nullable restore
#line 33 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                     foreach (var md in endpoint.Metadata)
                    {
                        switch (md)
                        {
                            case PageRouteMetadata prm:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <p>");
#nullable restore
#line 39 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                  Write(nameof(PageRouteMetadata));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <ul>\r\n                                        <li>Page Route: ");
#nullable restore
#line 41 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                                   Write(prm.PageRoute);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li>Route Template: ");
#nullable restore
#line 42 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                                       Write(prm.RouteTemplate);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </li>\r\n");
#nullable restore
#line 45 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                break;
                            case PageActionDescriptor pad:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    <p>");
#nullable restore
#line 48 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                  Write(nameof(PageActionDescriptor));

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                    <ul>\r\n                                        <li>Id: ");
#nullable restore
#line 50 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                           Write(pad.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li>Area: ");
#nullable restore
#line 51 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                             Write(pad.AreaName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li>Display Name: ");
#nullable restore
#line 52 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                                     Write(pad.DisplayName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li>View Engine Path: ");
#nullable restore
#line 53 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                                         Write(pad.ViewEnginePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                        <li>Relative Path: ");
#nullable restore
#line 54 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                                      Write(pad.RelativePath);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n                                    </ul>\r\n                                </li>\r\n");
#nullable restore
#line 57 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                break;
                            case RouteNameMetadata rnm:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    Route Name Metadata: ");
#nullable restore
#line 60 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                                    Write(rnm.RouteName);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                                </li>\r\n");
#nullable restore
#line 62 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                break;
                            case SuppressLinkGenerationMetadata slg:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>\r\n                                    suppress link: ");
#nullable restore
#line 65 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                              Write(slg.SuppressLinkGeneration);

#line default
#line hidden
#nullable disable
            WriteLiteral(";\r\n                                </li>\r\n");
#nullable restore
#line 67 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                break;
                            default:

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <li>");
#nullable restore
#line 69 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                               Write(md.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 70 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
                                break;
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </ul>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 76 "D:\Learning\TestNUnit\TestNUnit\Views\Home\Endpoints.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public EndpointDataSource EndpointsDataSource { get; private set; }
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