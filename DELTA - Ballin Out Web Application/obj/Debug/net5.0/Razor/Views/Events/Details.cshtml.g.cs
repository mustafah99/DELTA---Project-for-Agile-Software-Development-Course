#pragma checksum "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\Events\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "26e4552ff9287ca482c7a9c2c74ed46dbf5c916b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Events_Details), @"mvc.1.0.view", @"/Views/Events/Details.cshtml")]
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
#line 1 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\_ViewImports.cshtml"
using DELTA___Ballin_Out_Web_Application;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\_ViewImports.cshtml"
using DELTA___Ballin_Out_Web_Application.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\Events\Details.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"26e4552ff9287ca482c7a9c2c74ed46dbf5c916b", @"/Views/Events/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"42a7f234c9c06680e74af71355fe97405c39b489", @"/Views/_ViewImports.cshtml")]
    public class Views_Events_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<DELTA___Ballin_Out_Web_Application.Models.Events>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("nav-link"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("display: inline-block; text-decoration: none; text-shadow: 1px 1px 8px black; padding: 20px; color: white; letter-spacing: 15px; font-weight: lighter; text-transform: uppercase;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 6 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\Events\Details.cshtml"
  
    ViewData["Title"] = "Details";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1 style=\"padding: 20px; padding-top: 150px; color: white; letter-spacing: 15px; text-align: center; font-weight: 400; text-transform: uppercase;\">");
#nullable restore
#line 10 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\Events\Details.cshtml"
                                                                                                                                               Write(Html.DisplayFor(model => model.EventName));

#line default
#line hidden
#nullable disable
            WriteLiteral("</h1>\r\n\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e4552ff9287ca482c7a9c2c74ed46dbf5c916b6036", async() => {
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "style", 10, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 454, "background:", 454, 11, true);
            AddHtmlAttributeValue(" ", 465, "url(\'", 466, 6, true);
#nullable restore
#line 13 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\Events\Details.cshtml"
AddHtmlAttributeValue("", 471, Html.DisplayFor(model => model.EventImage), 471, 43, false);

#line default
#line hidden
#nullable disable
            AddHtmlAttributeValue("", 514, "\')", 514, 2, true);
            AddHtmlAttributeValue(" ", 516, "no-repeat", 517, 10, true);
            AddHtmlAttributeValue(" ", 526, "center", 527, 7, true);
            AddHtmlAttributeValue(" ", 533, "center", 534, 7, true);
            AddHtmlAttributeValue(" ", 540, "fixed;", 541, 7, true);
            AddHtmlAttributeValue(" ", 547, "background-size:", 548, 17, true);
            AddHtmlAttributeValue(" ", 564, "cover;", 565, 7, true);
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n<div style=\"position: absolute; z-index: -1; top: 0; width: 100%; height: 100%; left: 0; opacity: 0.9; background-image: linear-gradient(to bottom right, #192347, #e65177);\">\r\n\r\n</div>\r\n");
            WriteLiteral("    <p style=\"color: white; letter-spacing: 2px; text-align: center; font-weight: lighter; text-transform: uppercase;\">\r\n        <strong>");
#nullable restore
#line 21 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\Events\Details.cshtml"
           Write(Html.DisplayFor(model => model.EventLocation));

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n    </p>\r\n    <p style=\"padding: 20px; color: white; font-size: 20px; text-align: left; font-weight: lighter; text-transform: none;\">\r\n        ");
#nullable restore
#line 24 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\Events\Details.cshtml"
   Write(Html.DisplayFor(model => model.EventDescription));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n    <p style=\"padding: 20px; color: white; letter-spacing: 2px; text-align: center; font-weight: 400; text-transform: uppercase;\">\r\n        <strong>Event Date -</strong> ");
#nullable restore
#line 27 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\Events\Details.cshtml"
                                 Write(Html.DisplayFor(model => model.EventDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </p>\r\n\r\n");
#nullable restore
#line 30 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\Events\Details.cshtml"
 if (SignInManager.IsSignedIn(User)) {

#line default
#line hidden
#nullable disable
            WriteLiteral("    <div style=\"color: white;\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e4552ff9287ca482c7a9c2c74ed46dbf5c916b10180", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 32 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\Events\Details.cshtml"
                                                                                                                                                                                                                                          WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "26e4552ff9287ca482c7a9c2c74ed46dbf5c916b12747", async() => {
                WriteLiteral("Back to List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n");
#nullable restore
#line 35 "C:\Workspace\ECUtbildning\C#\DELTA - Ballin Out Web Application\DELTA - Ballin Out Web Application\Views\Events\Details.cshtml"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public UserManager<IdentityUser> UserManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<IdentityUser> SignInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<DELTA___Ballin_Out_Web_Application.Models.Events> Html { get; private set; }
    }
}
#pragma warning restore 1591