#pragma checksum "C:\Users\benkh\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14858f659e0652fc457b36a36cf9574969294e62"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_Details), @"mvc.1.0.razor-page", @"/Pages/Restaurants/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Restaurants/Details.cshtml", typeof(OdeToFood.Pages.Restaurants.Pages_Restaurants_Details), @"{id:int?}")]
namespace OdeToFood.Pages.Restaurants
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\benkh\source\repos\OdeToFood\OdeToFood\Pages\_ViewImports.cshtml"
using OdeToFood;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("RouteTemplate", "{id:int?}")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14858f659e0652fc457b36a36cf9574969294e62", @"/Pages/Restaurants/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd7a9498867045fbda097e3208cbd1c6a5a509f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Restaurants_Details : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "./list", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("glyphicon glyphicon-arrow-left"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "C:\Users\benkh\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
   
    ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(112, 8, true);
            WriteLiteral("\r\n<div> ");
            EndContext();
            BeginContext(121, 21, false);
#line 7 "C:\Users\benkh\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
 Write(Model.Restaurant.Name);

#line default
#line hidden
            EndContext();
            BeginContext(142, 14, true);
            WriteLiteral("</div>\r\n<div> ");
            EndContext();
            BeginContext(157, 25, false);
#line 8 "C:\Users\benkh\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
 Write(Model.Restaurant.Location);

#line default
#line hidden
            EndContext();
            BeginContext(182, 14, true);
            WriteLiteral("</div>\r\n<div> ");
            EndContext();
            BeginContext(197, 24, false);
#line 9 "C:\Users\benkh\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
 Write(Model.Restaurant.Cuisine);

#line default
#line hidden
            EndContext();
            BeginContext(221, 10, true);
            WriteLiteral("</div>\r\n\r\n");
            EndContext();
#line 11 "C:\Users\benkh\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
 if(Model.Message != null) { 

#line default
#line hidden
            BeginContext(262, 33, true);
            WriteLiteral("  <div class=\"aleert alert-info\">");
            EndContext();
            BeginContext(296, 13, false);
#line 12 "C:\Users\benkh\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
                            Write(Model.Message);

#line default
#line hidden
            EndContext();
            BeginContext(309, 8, true);
            WriteLiteral("</div>\r\n");
            EndContext();
#line 13 "C:\Users\benkh\source\repos\OdeToFood\OdeToFood\Pages\Restaurants\Details.cshtml"
}

#line default
#line hidden
            BeginContext(320, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(322, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14858f659e0652fc457b36a36cf9574969294e626072", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OdeToFood.Pages.Restaurants.DetailsModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.DetailsModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<OdeToFood.Pages.Restaurants.DetailsModel>)PageContext?.ViewData;
        public OdeToFood.Pages.Restaurants.DetailsModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
