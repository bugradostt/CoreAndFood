#pragma checksum "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Vitrin\Components\GetAboutList\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1843f3063e09a39bc9e378592fb3e1090e9cec38"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Vitrin_Components_GetAboutList_Default), @"mvc.1.0.view", @"/Views/Vitrin/Components/GetAboutList/Default.cshtml")]
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
#line 1 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\_ViewImports.cshtml"
using CoreAndFood;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Vitrin\Components\GetAboutList\Default.cshtml"
using CoreAndFood.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1843f3063e09a39bc9e378592fb3e1090e9cec38", @"/Views/Vitrin/Components/GetAboutList/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eca523975dc9d6067030284f78c87d6956189e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Vitrin_Components_GetAboutList_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<AboutList>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n <div class=\"col-md-6 agile_about_grid_left\">\r\n    <ol>\r\n");
#nullable restore
#line 6 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Vitrin\Components\GetAboutList\Default.cshtml"
         foreach (var i in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>");
#nullable restore
#line 8 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Vitrin\Components\GetAboutList\Default.cshtml"
           Write(i.AboutListMadde);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 9 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Vitrin\Components\GetAboutList\Default.cshtml"
            
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        \r\n    </ol>\r\n</div>\r\n<div class=\"clearfix\"> </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<AboutList>> Html { get; private set; }
    }
}
#pragma warning restore 1591