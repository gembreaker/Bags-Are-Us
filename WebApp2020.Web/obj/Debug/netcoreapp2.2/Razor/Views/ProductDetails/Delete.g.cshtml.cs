#pragma checksum "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5a92dda6c23a5f65391d16486f980c94efddc54a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetails_Delete), @"mvc.1.0.view", @"/Views/ProductDetails/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductDetails/Delete.cshtml", typeof(AspNetCore.Views_ProductDetails_Delete))]
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
#line 1 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\_ViewImports.cshtml"
using WebApp2020.Web;

#line default
#line hidden
#line 2 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\_ViewImports.cshtml"
using WebApp2020.Web.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5a92dda6c23a5f65391d16486f980c94efddc54a", @"/Views/ProductDetails/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1722f40bf290952bc7491d9e83ac5eb3292e42a", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductDetails_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp2020.Shared.Models.ProductDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(92, 176, true);
            WriteLiteral("\r\n<h1>Delete</h1>\r\n\r\n<h3>Are you sure you want to delete this from Product Details?</h3>\r\n<div>\r\n    <hr />\r\n    <dl class=\"row\">\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(269, 47, false);
#line 14 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(316, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(380, 43, false);
#line 17 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(423, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(486, 47, false);
#line 20 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(533, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(597, 43, false);
#line 23 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(640, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(703, 48, false);
#line 26 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.ProductImage));

#line default
#line hidden
            EndContext();
            BeginContext(751, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(815, 44, false);
#line 29 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.ProductImage));

#line default
#line hidden
            EndContext();
            BeginContext(859, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(922, 41, false);
#line 32 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(963, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1027, 37, false);
#line 35 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1064, 62, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1127, 43, false);
#line 38 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.BagType));

#line default
#line hidden
            EndContext();
            BeginContext(1170, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1234, 48, false);
#line 41 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.BagType.BagType1));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1351, 42, false);
#line 44 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Colour));

#line default
#line hidden
            EndContext();
            BeginContext(1393, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1457, 49, false);
#line 47 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Colour.ColourName));

#line default
#line hidden
            EndContext();
            BeginContext(1506, 68, true);
            WriteLiteral("\r\n        </dd class>\r\n        <dt class = \"col-sm-2\">\r\n            ");
            EndContext();
            BeginContext(1575, 41, false);
#line 50 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Range));

#line default
#line hidden
            EndContext();
            BeginContext(1616, 63, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd class = \"col-sm-10\">\r\n            ");
            EndContext();
            BeginContext(1680, 47, false);
#line 53 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Range.RangeName));

#line default
#line hidden
            EndContext();
            BeginContext(1727, 44, true);
            WriteLiteral("\r\n        </dd class>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1771, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a92dda6c23a5f65391d16486f980c94efddc54a12041", async() => {
                BeginContext(1797, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1807, 45, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5a92dda6c23a5f65391d16486f980c94efddc54a12434", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 58 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.ProductCode);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1852, 83, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-danger\" /> |\r\n        ");
                EndContext();
                BeginContext(1935, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a92dda6c23a5f65391d16486f980c94efddc54a14408", async() => {
                    BeginContext(1957, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
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
                BeginContext(1973, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1986, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebApp2020.Shared.Models.ProductDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591