#pragma checksum "C:\Users\benkh\source\repos\OdeToFood\OdeToFood\Pages\Shared\Components\RestaurantCount\default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "300b7a5cba8e267328d441afda82b5f2d480afe8"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(OdeToFood.Pages.Shared.Components.RestaurantCount.Pages_Shared_Components_RestaurantCount_default), @"mvc.1.0.view", @"/Pages/Shared/Components/RestaurantCount/default.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Pages/Shared/Components/RestaurantCount/default.cshtml", typeof(OdeToFood.Pages.Shared.Components.RestaurantCount.Pages_Shared_Components_RestaurantCount_default))]
namespace OdeToFood.Pages.Shared.Components.RestaurantCount
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"300b7a5cba8e267328d441afda82b5f2d480afe8", @"/Pages/Shared/Components/RestaurantCount/default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5bd7a9498867045fbda097e3208cbd1c6a5a509f", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Shared_Components_RestaurantCount_default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<int>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(14, 35, true);
            WriteLiteral("\r\n<div class=\"well\">\r\n    there is ");
            EndContext();
            BeginContext(50, 5, false);
#line 5 "C:\Users\benkh\source\repos\OdeToFood\OdeToFood\Pages\Shared\Components\RestaurantCount\default.cshtml"
        Write(Model);

#line default
#line hidden
            EndContext();
            BeginContext(55, 25, true);
            WriteLiteral(" restaurants \r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<int> Html { get; private set; }
    }
}
#pragma warning restore 1591
