#pragma checksum "C:\Users\Koray\Desktop\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "91aae8ed8e03c968a0080a6cca2b668f6210c552"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"91aae8ed8e03c968a0080a6cca2b668f6210c552", @"/Views/Product/GetProduct.cshtml")]
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
#line 2 "C:\Users\Koray\Desktop\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
  
    ViewData["Title"] = "GetProduct";

#line default
#line hidden
            BeginContext(106, 12, true);
            WriteLiteral("\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(118, 42, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e0932d00e82f4104b0258d9c705fac36", async() => {
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
            BeginContext(162, 467, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8c87c92d4c3a4a2b9699d8f7ab2a62d7", async() => {
                BeginContext(168, 175, true);
                WriteLiteral("\r\n    <div>\r\n        <table>\r\n            <tr>\r\n                <td>Product Code </td>\r\n                <td>Price </td>\r\n                <td>Stock </td>\r\n            </tr>\r\n\r\n");
                EndContext();
#line 21 "C:\Users\Koray\Desktop\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
             foreach(var item in Model.product)
            {

#line default
#line hidden
                BeginContext(407, 38, true);
                WriteLiteral("            <tr>\r\n                <td>");
                EndContext();
                BeginContext(446, 16, false);
#line 24 "C:\Users\Koray\Desktop\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
               Write(item.ProductCode);

#line default
#line hidden
                EndContext();
                BeginContext(462, 28, true);
                WriteLiteral(" </td>\r\n                <td>");
                EndContext();
                BeginContext(491, 10, false);
#line 25 "C:\Users\Koray\Desktop\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
               Write(item.Price);

#line default
#line hidden
                EndContext();
                BeginContext(501, 36, true);
                WriteLiteral(" &#8378; </td>\r\n                <td>");
                EndContext();
                BeginContext(538, 10, false);
#line 26 "C:\Users\Koray\Desktop\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
               Write(item.Stock);

#line default
#line hidden
                EndContext();
                BeginContext(548, 27, true);
                WriteLiteral(" </td>\r\n            </tr>\r\n");
                EndContext();
#line 28 "C:\Users\Koray\Desktop\ECommerce\eCommerce.Campaign.MvcWebUI\Views\Product\GetProduct.cshtml"
            }

#line default
#line hidden
                BeginContext(590, 32, true);
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
            BeginContext(629, 13, true);
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
