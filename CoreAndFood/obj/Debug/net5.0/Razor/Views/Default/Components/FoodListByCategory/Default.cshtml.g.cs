#pragma checksum "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListByCategory\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "83aff523d2d114093b7b4ded85d737b935cfd986"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Default_Components_FoodListByCategory_Default), @"mvc.1.0.view", @"/Views/Default/Components/FoodListByCategory/Default.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"83aff523d2d114093b7b4ded85d737b935cfd986", @"/Views/Default/Components/FoodListByCategory/Default.cshtml")]
    public class Views_Default_Components_FoodListByCategory_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<CoreAndFood.Data.Models.Food>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/web/single.html"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div class=\"agile_top_brands_grids\">\r\n");
#nullable restore
#line 4 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListByCategory\Default.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <div class=""col-md-3 top_brand_left"">
            <div class=""hover14 column"">
                <div class=""agile_top_brand_left_grid"">

                    <div class=""agile_top_brand_left_grid1"">
                        <figure>
                            <div class=""snipcart-item block"">
                                <div class=""snipcart-thumb"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "83aff523d2d114093b7b4ded85d737b935cfd9863844", async() => {
                WriteLiteral("<img style=\"width:250px; height:250px\" title=\" \" alt=\" \"");
                BeginWriteAttribute("src", " src=\"", 620, "\"", 640, 1);
#nullable restore
#line 14 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListByCategory\Default.cshtml"
WriteAttributeValue("", 626, item.ImageURL, 626, 14, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    <b>");
#nullable restore
#line 15 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListByCategory\Default.cshtml"
                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</b>\r\n                                    <h4>");
#nullable restore
#line 16 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListByCategory\Default.cshtml"
                                   Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ???</h4> <h6>Stok:");
#nullable restore
#line 16 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListByCategory\Default.cshtml"
                                                               Write(item.Stock);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h6>
                                </div>

                                <div class=""snipcart-details top_brand_home_details"">
                                    <form action=""checkout.html"" method=""post"">
                                        <fieldset>
                                            <input type=""hidden"" name=""cmd"" value=""_cart"" />
                                            <input type=""hidden"" name=""add"" value=""1"" />
                                            <input type=""hidden"" name=""business"" value="" "" />
                                            <input type=""hidden"" name=""item_name"" value=""Fortune Sunflower Oil"" />
                                            <input type=""hidden"" name=""amount"" value=""7.99"" />
                                            <input type=""hidden"" name=""discount_amount"" value=""1.00"" />
                                            <input type=""hidden"" name=""currency_code"" value=""USD"" />
                                            <input type=""");
            WriteLiteral(@"hidden"" name=""return"" value="" "" />
                                            <input type=""hidden"" name=""cancel_return"" value="" "" />
                                            <input type=""submit"" name=""submit"" value=""Sepete Ekle"" class=""button"" />
                                        </fieldset>

                                    </form>

                                </div>
                            </div>
                        </figure>
                    </div>
                </div>
            </div>
        </div>
");
#nullable restore
#line 43 "C:\Users\elifc\source\repos\CoreAndFood\CoreAndFood\Views\Default\Components\FoodListByCategory\Default.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    <div class=\"clearfix\"> </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<CoreAndFood.Data.Models.Food>> Html { get; private set; }
    }
}
#pragma warning restore 1591
