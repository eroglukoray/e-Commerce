#pragma checksum "C:\Users\Koray\Documents\Projeler\HepsiBurada Mulakat\ECommerce_TrendYol\ECommerce_TrendYol\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7fc4cfcc1084f1432a4ff77edbe8052752cf9bb8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_GetProduct), @"mvc.1.0.view", @"/Views/Product/GetProduct.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Product/GetProduct.cshtml", typeof(AspNetCore.Views_Product_GetProduct))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7fc4cfcc1084f1432a4ff77edbe8052752cf9bb8", @"/Views/Product/GetProduct.cshtml")]
    public class Views_Product_GetProduct : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<eCommerce.Campaign.MvcWebUI.Models.ProductViewModel>
    {
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 2 "C:\Users\Koray\Documents\Projeler\HepsiBurada Mulakat\ECommerce_TrendYol\ECommerce_TrendYol\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
  
    ViewData["Title"] = "GetProduct";

#line default
#line hidden
            BeginContext(106, 12, true);
            WriteLiteral("\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(118, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef78c3082e9e4bb3b0e7e87abf94f665", async() => {
                BeginContext(124, 29, true);
                WriteLiteral("\r\n    <h2>GetProduct</h2>\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(160, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(162, 505, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f64e1a62ce4c45d182231d783ed7f870", async() => {
                BeginContext(168, 214, true);
                WriteLiteral("\r\n    <div>\r\n        <table>\r\n            <tr>\r\n                <td>Product Code </td>\r\n                <td>Price </td>\r\n                <td>Stock </td>\r\n                <td>Kategori Id </td>\r\n            </tr>\r\n\r\n");
                EndContext();
#line 22 "C:\Users\Koray\Documents\Projeler\HepsiBurada Mulakat\ECommerce_TrendYol\ECommerce_TrendYol\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
             foreach(var item in Model.product)
            {

#line default
#line hidden
                BeginContext(446, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(485, 10, false);
#line 25 "C:\Users\Koray\Documents\Projeler\HepsiBurada Mulakat\ECommerce_TrendYol\ECommerce_TrendYol\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
               Write(item.Title);

#line default
#line hidden
                EndContext();
                BeginContext(495, 28, true);
                WriteLiteral(" </td>\r\n                <td>");
                EndContext();
                BeginContext(524, 10, false);
#line 26 "C:\Users\Koray\Documents\Projeler\HepsiBurada Mulakat\ECommerce_TrendYol\ECommerce_TrendYol\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
               Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(534, 36, true);
                WriteLiteral(" &#8378; </td>\r\n                <td>");
                EndContext();
                BeginContext(571, 15, false);
#line 27 "C:\Users\Koray\Documents\Projeler\HepsiBurada Mulakat\ECommerce_TrendYol\ECommerce_TrendYol\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
               Write(item.CategoryId);

#line default
#line hidden
                EndContext();
                BeginContext(586, 27, true);
                WriteLiteral(" </td>\r\n            </tr>\r\n");
                EndContext();
#line 29 "C:\Users\Koray\Documents\Projeler\HepsiBurada Mulakat\ECommerce_TrendYol\ECommerce_TrendYol\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
            }

#line default
#line hidden
                BeginContext(628, 32, true);
                WriteLiteral("\r\n        </table>\r\n    </div>\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(667, 13, true);
            WriteLiteral("\r\n\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<eCommerce.Campaign.MvcWebUI.Models.ProductViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
