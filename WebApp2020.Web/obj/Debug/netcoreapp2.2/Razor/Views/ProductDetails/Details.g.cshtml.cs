#pragma checksum "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a319b376d66dbb8829f08c9c763964cb628b8fb6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ProductDetails_Details), @"mvc.1.0.view", @"/Views/ProductDetails/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ProductDetails/Details.cshtml", typeof(AspNetCore.Views_ProductDetails_Details))]
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
#line 3 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a319b376d66dbb8829f08c9c763964cb628b8fb6", @"/Views/ProductDetails/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1722f40bf290952bc7491d9e83ac5eb3292e42a", @"/Views/_ViewImports.cshtml")]
    public class Views_ProductDetails_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebApp2020.Shared.Models.ProductDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-warning"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "OrderDetails", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(48, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(145, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 6 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
  
	ViewData["Title"] = "Details";

#line default
#line hidden
            BeginContext(187, 74, true);
            WriteLiteral("\r\n<div>\r\n\t<hr />\r\n\t<div class=\"row\">\r\n\t\t<h1 class=\"col-12 col-md-10\">\r\n\t\t\t");
            EndContext();
            BeginContext(262, 43, false);
#line 14 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
       Write(Html.DisplayFor(model => model.ProductName));

#line default
#line hidden
            EndContext();
            BeginContext(305, 103, true);
            WriteLiteral("\r\n\t\t</h1>\r\n\t</div>\r\n\t<hr />\r\n\t<div class=\"row\">\r\n\t\t<div class=\"col-12 col-md-8 col-lg-4 mb-2\">\r\n\t\t\t<img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 408, "\"", 461, 1);
#line 20 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
WriteAttributeValue("", 414, Url.Content($"~/Images/{@Model.ProductImage}"), 414, 47, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(462, 41, true);
            WriteLiteral(" class=\"img-fluid\" style=\"height: 300px;\"");
            EndContext();
            BeginWriteAttribute("alt", " alt=\"", 503, "\"", 567, 3);
#line 20 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
WriteAttributeValue("", 509, Html.DisplayFor(model => model.ProductName), 509, 44, false);

#line default
#line hidden
            WriteAttributeValue(" ", 553, "Product", 554, 8, true);
            WriteAttributeValue(" ", 561, "Image", 562, 6, true);
            EndWriteAttribute();
            BeginContext(568, 156, true);
            WriteLiteral(" />\r\n\t\t</div>\r\n\t\t<div class=\"col-6 col-sm-6 col-lg-2 order-lg-3\">\r\n\t\t\t<dl class=\"row\" style=\"background-color: #c6f1f5;\">\r\n\t\t\t\t<dt class=\"col-sm-10\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(725, 43, false);
#line 25 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.BagType));

#line default
#line hidden
            EndContext();
            BeginContext(768, 46, true);
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(815, 48, false);
#line 28 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
               Write(Html.DisplayFor(model => model.BagType.BagType1));

#line default
#line hidden
            EndContext();
            BeginContext(863, 46, true);
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-10\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(910, 42, false);
#line 31 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Colour));

#line default
#line hidden
            EndContext();
            BeginContext(952, 46, true);
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(999, 49, false);
#line 34 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
               Write(Html.DisplayFor(model => model.Colour.ColourName));

#line default
#line hidden
            EndContext();
            BeginContext(1048, 46, true);
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t\t<dt class=\"col-sm-10\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1095, 41, false);
#line 37 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
               Write(Html.DisplayNameFor(model => model.Range));

#line default
#line hidden
            EndContext();
            BeginContext(1136, 46, true);
            WriteLiteral("\r\n\t\t\t\t</dt>\r\n\t\t\t\t<dd class=\"col-sm-10\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1183, 47, false);
#line 40 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
               Write(Html.DisplayFor(model => model.Range.RangeName));

#line default
#line hidden
            EndContext();
            BeginContext(1230, 95, true);
            WriteLiteral("\r\n\t\t\t\t</dd>\r\n\t\t\t</dl>\r\n\t\t</div>\r\n\t\t<div class=\"col-12 col-sm-6 order-lg-2\">\r\n\t\t\t<div>\r\n\t\t\t\t<h4>");
            EndContext();
            BeginContext(1326, 37, false);
#line 46 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
               Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(1363, 14, true);
            WriteLiteral("</h4>\r\n\t\t\t\t<p>");
            EndContext();
            BeginContext(1378, 43, false);
#line 47 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
              Write(Html.DisplayFor(model => model.Description));

#line default
#line hidden
            EndContext();
            BeginContext(1421, 52, true);
            WriteLiteral("</p>\r\n\t\t\t\t<br />\r\n\t\t\t\t<p class=\"text-center\">\r\n\t\t\t\t\t");
            EndContext();
            BeginContext(1473, 131, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a319b376d66dbb8829f08c9c763964cb628b8fb611867", async() => {
                BeginContext(1593, 7, true);
                WriteLiteral("Buy now");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ProductCode", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 50 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
                                                                                                            WriteLiteral(Model.ProductCode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductCode"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ProductCode", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ProductCode"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1604, 107, true);
            WriteLiteral("\r\n\t\t\t\t</p>\r\n\t\t\t\t<br />\r\n\t\t\t\t<p>Eligible for free UK delivery.</p>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n</div>\r\n\r\n");
            EndContext();
            BeginContext(2928, 9, true);
            WriteLiteral("\r\n<div>\r\n");
            EndContext();
#line 105 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
     if ((await AuthorisationService.AuthorizeAsync(User, "IsAdmin")).Succeeded)
	{

#line default
#line hidden
            BeginContext(3020, 2, true);
            WriteLiteral("\t\t");
            EndContext();
            BeginContext(3022, 33, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a319b376d66dbb8829f08c9c763964cb628b8fb615289", async() => {
                BeginContext(3045, 6, true);
                WriteLiteral("Create");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3055, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3062, 1, true);
            WriteLiteral("|");
            EndContext();
            BeginContext(3070, 4, true);
            WriteLiteral("\r\n\t\t");
            EndContext();
            BeginContext(3074, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a319b376d66dbb8829f08c9c763964cb628b8fb616868", async() => {
                BeginContext(3129, 4, true);
                WriteLiteral("Edit");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 108 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
                               WriteLiteral(Model.ProductCode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3137, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3144, 1, true);
            WriteLiteral("|");
            EndContext();
            BeginContext(3152, 4, true);
            WriteLiteral("\r\n\t\t");
            EndContext();
            BeginContext(3156, 67, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a319b376d66dbb8829f08c9c763964cb628b8fb619464", async() => {
                BeginContext(3213, 6, true);
                WriteLiteral("Delete");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 109 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
                                 WriteLiteral(Model.ProductCode);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3223, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(3230, 1, true);
            WriteLiteral("|");
            EndContext();
#line 109 "E:\Uni\Year 2\Semester 2\Application Development\AssignmentProject\WebApp2020\WebApp2020\WebApp2020.Web\Views\ProductDetails\Details.cshtml"
                                                                                          
	}

#line default
#line hidden
            BeginContext(3244, 1, true);
            WriteLiteral("\t");
            EndContext();
            BeginContext(3245, 38, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a319b376d66dbb8829f08c9c763964cb628b8fb622338", async() => {
                BeginContext(3267, 12, true);
                WriteLiteral("Back to List");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3283, 10, true);
            WriteLiteral("\r\n</div>\r\n");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService AuthorisationService { get; private set; }
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
