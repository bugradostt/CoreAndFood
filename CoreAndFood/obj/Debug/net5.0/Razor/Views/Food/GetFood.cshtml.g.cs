#pragma checksum "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0d2e859e05b88ba517e2ab040959ba749bd4ae69"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Food_GetFood), @"mvc.1.0.view", @"/Views/Food/GetFood.cshtml")]
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
#line 2 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\_ViewImports.cshtml"
using CoreAndFood.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0d2e859e05b88ba517e2ab040959ba749bd4ae69", @"/Views/Food/GetFood.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9eca523975dc9d6067030284f78c87d6956189e8", @"/Views/_ViewImports.cshtml")]
    public class Views_Food_GetFood : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<CoreAndFood.Models.Food>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Food/EditFood"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<br />\r\n<div class=\"container-fluid\">\r\n    <h3>Gıda Güncelle</h3>\r\n    <hr />\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d2e859e05b88ba517e2ab040959ba749bd4ae694444", async() => {
                WriteLiteral("\r\n\r\n        <input hidden type=\"text\" name=\"FoodId\"");
                BeginWriteAttribute("value", " value=\"", 342, "\"", 377, 1);
#nullable restore
#line 14 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
WriteAttributeValue("", 350, Html.ValueFor(x=>x.FoodId), 350, 27, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />\r\n\r\n        <label>Gıda Adı</label>\r\n        <input type=\"text\" name=\"Name\"");
                BeginWriteAttribute("value", " value=\"", 456, "\"", 489, 1);
#nullable restore
#line 17 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
WriteAttributeValue("", 464, Html.ValueFor(x=>x.Name), 464, 25, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Gıda adını giriniz...\" class=\"form-control\" />\r\n        <br />\r\n\r\n        <label>Kategori Türü </label>\r\n        <select class=\"form-control\" name=\"CategoryId\">\r\n            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d2e859e05b88ba517e2ab040959ba749bd4ae695851", async() => {
                    WriteLiteral("Seçiniz");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n\r\n");
#nullable restore
#line 24 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
             for (int i = 0; i < ViewBag.CategoryList.Count; i++)
            {
               
                if (Html.ValueFor(x => x.CategoryId) == ViewBag.CategoryList[i].Value)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d2e859e05b88ba517e2ab040959ba749bd4ae697514", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 29 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
                                                                        Write(ViewBag.CategoryList[i].Text);

#line default
#line hidden
#nullable disable
                    WriteLiteral("  ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 29 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
                                WriteLiteral(ViewBag.CategoryList[i].Value);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 30 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"

                }
                else
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "0d2e859e05b88ba517e2ab040959ba749bd4ae6910172", async() => {
                    WriteLiteral(" ");
#nullable restore
#line 34 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
                                                                Write(ViewBag.CategoryList[i].Text);

#line default
#line hidden
#nullable disable
                    WriteLiteral("  ");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
                        WriteLiteral(ViewBag.CategoryList[i].Value);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 35 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
                }
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </select>\r\n        <br />\r\n\r\n        <label>Fiyatı</label>\r\n        <input type=\"number\" min=\"0\"");
                BeginWriteAttribute("value", " value=\"", 1356, "\"", 1390, 1);
#nullable restore
#line 43 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
WriteAttributeValue("", 1364, Html.ValueFor(x=>x.Price), 1364, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" name=\"Price\" placeholder=\"Ürün fiyatını giriniz...\" class=\"form-control\" />\r\n        <br />\r\n\r\n        <label>Stok</label>\r\n        <input type=\"number\" min=\"0\" name=\"Stock\"");
                BeginWriteAttribute("value", " value=\"", 1565, "\"", 1599, 1);
#nullable restore
#line 47 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
WriteAttributeValue("", 1573, Html.ValueFor(x=>x.Stock), 1573, 26, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Stok adetini giriniz...\" class=\"form-control\" />\r\n        <br />\r\n\r\n        <label>Ürün Fotoğraf Url</label>\r\n        <input type=\"text\" name=\"ImageUrl\"");
                BeginWriteAttribute("value", " value=\"", 1766, "\"", 1803, 1);
#nullable restore
#line 51 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
WriteAttributeValue("", 1774, Html.ValueFor(x=>x.ImageUrl), 1774, 29, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Fotoğraf url\'ini\' giriniz...\" class=\"form-control\" />\r\n        <br />\r\n\r\n\r\n        <label>Açıklama</label>\r\n        <textarea name=\"Description\" rows=\"3\" placeholder=\" Açıklamayı giriniz...\" class=\"form-control\">");
#nullable restore
#line 56 "C:\Users\bugra\Desktop\1- Dosya\1-Projeler\CoreAndFood\CoreAndFood\Views\Food\GetFood.cshtml"
                                                                                                   Write(Html.ValueFor(x=>x.Description));

#line default
#line hidden
#nullable disable
                WriteLiteral("</textarea>\r\n        <br />\r\n\r\n        <a href=\"/Food/Index\" class=\"btn btn-danger\">İptal</a>\r\n        <input type=\"submit\" class=\"btn btn-warning\" value=\"Güncelle\" />\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n</div>\r\n\r\n<br />");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CoreAndFood.Models.Food> Html { get; private set; }
    }
}
#pragma warning restore 1591