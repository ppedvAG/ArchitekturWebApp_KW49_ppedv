#pragma checksum "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\ASPNETCore_MVC_HTML_CSS\Views\MyBootstrap\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dccd230539b4bbff977ed389f7eb0edb3d65e9c5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MyBootstrap_Index), @"mvc.1.0.view", @"/Views/MyBootstrap/Index.cshtml")]
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
#line 1 "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\ASPNETCore_MVC_HTML_CSS\Views\_ViewImports.cshtml"
using ASPNETCore_MVC_HTML_CSS;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\ASPNETCore_MVC_HTML_CSS\Views\_ViewImports.cshtml"
using ASPNETCore_MVC_HTML_CSS.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dccd230539b4bbff977ed389f7eb0edb3d65e9c5", @"/Views/MyBootstrap/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"653622c245ccb1394aecf8d97083eb62d3b94fea", @"/Views/_ViewImports.cshtml")]
    public class Views_MyBootstrap_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Aktueller Kurs\ArchitekturWebApp_KW49_ppedv\ArchitketurModernerWebAnwendungen\ASPNETCore_MVC_HTML_CSS\Views\MyBootstrap\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Index</h1>


<div class=""container-sm"">100% wide until small breakpoint</div>
<div class=""container-md"">100% wide until medium breakpoint</div>
<div class=""container-lg"">100% wide until large breakpoint</div>
<div class=""container-xl"">100% wide until extra large breakpoint</div>
<div class=""container-xxl"">100% wide until extra extra large breakpoint</div>


<div class=""container"">
  <h2>Modal Example</h2>
  <!-- Button to Open the Modal -->
  <button type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"">Open modal</button>

  <!-- The Modal -->
  <div class=""modal"" id=""myModal"">
    <div class=""modal-dialog"">
      <div class=""modal-content"">
      
        <!-- Modal Header -->
        <div class=""modal-header"">
          <h4 class=""modal-title"">Modal Heading</h4>
          <button type=""button"" class=""close"" data-dismiss=""modal"">&times;</button>
        </div>
        
        <!-- Modal body -->
        <div class=""modal-body"">
          Modal bo");
            WriteLiteral(@"dy..
        </div>
        
        <!-- Modal footer -->
        <div class=""modal-footer"">
          <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal"">Close</button>
        </div>
        
      </div>

    </div>
    </div>
</div>

<div class=""toast"" data-autohide=""false"">
    <div class=""toast-header"">
      <strong class=""mr-auto text-primary"">Toast Header</strong>
      <small class=""text-muted"">5 mins ago</small>
      <button type=""button"" class=""ml-2 mb-1 close"" data-dismiss=""toast"">&times;</button>
    </div>
    <div class=""toast-body"">
      Some text inside the toast body
    </div>
  </div>


<script type=""text/javascript"">
    $(document).ready(function(){
      $('#toast').toast('show');
    });
</script>");
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
