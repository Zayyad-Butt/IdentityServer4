#pragma checksum "C:\Users\zayya\Documents\6th Semester\EAD\Practice work\IdentityServerPractice\WebClient\Views\Home\Weather.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b1463d92cb6f100871a8cffea7f2b703806ab2fe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Weather), @"mvc.1.0.view", @"/Views/Home/Weather.cshtml")]
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
#line 1 "C:\Users\zayya\Documents\6th Semester\EAD\Practice work\IdentityServerPractice\WebClient\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\zayya\Documents\6th Semester\EAD\Practice work\IdentityServerPractice\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1463d92cb6f100871a8cffea7f2b703806ab2fe", @"/Views/Home/Weather.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Weather : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<WeatherModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\zayya\Documents\6th Semester\EAD\Practice work\IdentityServerPractice\WebClient\Views\Home\Weather.cshtml"
  
    ViewData["Title"] = "Weather";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h1>Weather</h1>\r\n<table class=\"table table-striped\">\r\n    <tr>\r\n        <th>Date</th>\r\n        <th>Summary</th>\r\n        <th>Temperature in C</th>\r\n        <th>Temperature in F</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Users\zayya\Documents\6th Semester\EAD\Practice work\IdentityServerPractice\WebClient\Views\Home\Weather.cshtml"
     foreach (var weather in Model)
    {


#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 17 "C:\Users\zayya\Documents\6th Semester\EAD\Practice work\IdentityServerPractice\WebClient\Views\Home\Weather.cshtml"
           Write(weather.Date);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\zayya\Documents\6th Semester\EAD\Practice work\IdentityServerPractice\WebClient\Views\Home\Weather.cshtml"
           Write(weather.Summary);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\zayya\Documents\6th Semester\EAD\Practice work\IdentityServerPractice\WebClient\Views\Home\Weather.cshtml"
           Write(weather.TemperatureC);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\zayya\Documents\6th Semester\EAD\Practice work\IdentityServerPractice\WebClient\Views\Home\Weather.cshtml"
           Write(weather.TemperatureF);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\zayya\Documents\6th Semester\EAD\Practice work\IdentityServerPractice\WebClient\Views\Home\Weather.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<WeatherModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
