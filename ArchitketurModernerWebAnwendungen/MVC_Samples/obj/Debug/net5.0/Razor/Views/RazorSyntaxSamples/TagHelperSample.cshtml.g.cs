#pragma checksum "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\MVC_Samples\Views\RazorSyntaxSamples\TagHelperSample.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6e5dfb78680e2fa79bf214e55d3b8e59a6c3564"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_RazorSyntaxSamples_TagHelperSample), @"mvc.1.0.view", @"/Views/RazorSyntaxSamples/TagHelperSample.cshtml")]
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
#line 1 "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\MVC_Samples\Views\_ViewImports.cshtml"
using MVC_Samples;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\MVC_Samples\Views\_ViewImports.cshtml"
using MVC_Samples.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\MVC_Samples\Views\_ViewImports.cshtml"
using MVC_Samples.TagHelpers;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6e5dfb78680e2fa79bf214e55d3b8e59a6c3564", @"/Views/RazorSyntaxSamples/TagHelperSample.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ba98c1eeaeade38fe25af882fb2ae2a7932504ff", @"/Views/_ViewImports.cshtml")]
    public class Views_RazorSyntaxSamples_TagHelperSample : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
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
        private global::MVC_Samples.TagHelpers.WebsiteInformationTagHelper __MVC_Samples_TagHelpers_WebsiteInformationTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\MVC_Samples\Views\RazorSyntaxSamples\TagHelperSample.cshtml"
  
    ViewData["Title"] = "TagHelperSample";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>TagHelperSample</h1>\r\n\r\n");
#nullable restore
#line 8 "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\MVC_Samples\Views\RazorSyntaxSamples\TagHelperSample.cshtml"
Write(Html.HelloWorldWithHTML());

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 10 "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\MVC_Samples\Views\RazorSyntaxSamples\TagHelperSample.cshtml"
Write(Html.HelloWorldWithName("Mrs M."));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n");
#nullable restore
#line 13 "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\MVC_Samples\Views\RazorSyntaxSamples\TagHelperSample.cshtml"
  
    WebsiteContext websiteContext = new WebsiteContext
    {
        Version = new Version(1, 3),
        CopyrightYear = 2021,
        Approved = true,
        TagsToShow = 123
    };

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>CustomTagHelper</h1>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("website-information", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b6e5dfb78680e2fa79bf214e55d3b8e59a6c35644948", async() => {
            }
            );
            __MVC_Samples_TagHelpers_WebsiteInformationTagHelper = CreateTagHelper<global::MVC_Samples.TagHelpers.WebsiteInformationTagHelper>();
            __tagHelperExecutionContext.Add(__MVC_Samples_TagHelpers_WebsiteInformationTagHelper);
#nullable restore
#line 24 "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\MVC_Samples\Views\RazorSyntaxSamples\TagHelperSample.cshtml"
__MVC_Samples_TagHelpers_WebsiteInformationTagHelper.Info = websiteContext;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("info", __MVC_Samples_TagHelpers_WebsiteInformationTagHelper.Info, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591