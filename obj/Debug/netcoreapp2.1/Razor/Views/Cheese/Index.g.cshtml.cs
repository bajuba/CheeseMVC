#pragma checksum "/home/bajuba/itt075/CheeseMVC/Views/Cheese/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "92222998f1714d607a4f25f13b895c621956c492"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cheese_Index), @"mvc.1.0.view", @"/Views/Cheese/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Cheese/Index.cshtml", typeof(AspNetCore.Views_Cheese_Index))]
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
#line 1 "/home/bajuba/itt075/CheeseMVC/Views/_ViewImports.cshtml"
using CheeseMVC;

#line default
#line hidden
#line 2 "/home/bajuba/itt075/CheeseMVC/Views/_ViewImports.cshtml"
using CheeseMVC.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"92222998f1714d607a4f25f13b895c621956c492", @"/Views/Cheese/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1df004408d806d9392a0a9a6c4f5cc57111ca8b1", @"/Views/_ViewImports.cshtml")]
    public class Views_Cheese_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<CheeseMVC.Models.Cheese>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Cheese", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Add", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.SingleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(37, 22, true);
            WriteLiteral("\n<h1>My Cheeses</h1>\n\n");
            EndContext();
            BeginContext(59, 58, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b50a4ccb0fe5410cb6500de870c1d5c3", async() => {
                BeginContext(103, 10, true);
                WriteLiteral("Add Cheese");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(117, 2, true);
            WriteLiteral("\n\n");
            EndContext();
#line 7 "/home/bajuba/itt075/CheeseMVC/Views/Cheese/Index.cshtml"
 if (Model.Count == 0)
{

#line default
#line hidden
            BeginContext(144, 22, true);
            WriteLiteral("    <p>No Cheeses</p>\n");
            EndContext();
#line 10 "/home/bajuba/itt075/CheeseMVC/Views/Cheese/Index.cshtml"
}

#line default
#line hidden
            BeginContext(168, 83, true);
            WriteLiteral("\n<table>\n    <tr>\n        <th>Name</th><th>Description</th><th>Type</th>\n    </tr>\n");
            EndContext();
#line 16 "/home/bajuba/itt075/CheeseMVC/Views/Cheese/Index.cshtml"
     foreach (Cheese cheese in Model)
    {

#line default
#line hidden
            BeginContext(295, 29, true);
            WriteLiteral("        <tr>\n            <td>");
            EndContext();
            BeginContext(325, 11, false);
#line 19 "/home/bajuba/itt075/CheeseMVC/Views/Cheese/Index.cshtml"
           Write(cheese.Name);

#line default
#line hidden
            EndContext();
            BeginContext(336, 10, true);
            WriteLiteral("</td> <td>");
            EndContext();
            BeginContext(347, 18, false);
#line 19 "/home/bajuba/itt075/CheeseMVC/Views/Cheese/Index.cshtml"
                                 Write(cheese.Description);

#line default
#line hidden
            EndContext();
            BeginContext(365, 9, true);
            WriteLiteral("</td><td>");
            EndContext();
            BeginContext(375, 11, false);
#line 19 "/home/bajuba/itt075/CheeseMVC/Views/Cheese/Index.cshtml"
                                                             Write(cheese.Type);

#line default
#line hidden
            EndContext();
            BeginContext(386, 20, true);
            WriteLiteral("</td>\n        </tr>\n");
            EndContext();
#line 21 "/home/bajuba/itt075/CheeseMVC/Views/Cheese/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(412, 8, true);
            WriteLiteral("</table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<CheeseMVC.Models.Cheese>> Html { get; private set; }
    }
}
#pragma warning restore 1591
