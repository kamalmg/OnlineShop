#pragma checksum "C:\Users\DC\source\repos\HerbsStore\HerbsStore\Views\Administration\Hospitals.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "78a71f0303e6d5500641a4b5f4c86130c87ec7d1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_Hospitals), @"mvc.1.0.view", @"/Views/Administration/Hospitals.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Administration/Hospitals.cshtml", typeof(AspNetCore.Views_Administration_Hospitals))]
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
#line 1 "C:\Users\DC\source\repos\HerbsStore\HerbsStore\Views\_ViewImports.cshtml"
using HerbsStore;

#line default
#line hidden
#line 2 "C:\Users\DC\source\repos\HerbsStore\HerbsStore\Views\_ViewImports.cshtml"
using HerbsStore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"78a71f0303e6d5500641a4b5f4c86130c87ec7d1", @"/Views/Administration/Hospitals.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"685927e3976194dea104db3d4ce893292e235875", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_Hospitals : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\DC\source\repos\HerbsStore\HerbsStore\Views\Administration\Hospitals.cshtml"
  
    ViewData["Title"] = "Hospitals";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(94, 1488, true);
            WriteLiteral(@"
<div class=""container"">
     
    <h2 class=""typoh2"">List of Hospitals</h2>
    <br/>
    <div class=""pull-right"">
        <button class=""btn btn-primary"">Add New</button>
    </div>
    <div class=""bs-docs-example"">
        <table class=""table table-striped"">
            <thead>
            <tr>
                <th>#</th>
                <th>Hospital Name</th>
                <th>Address</th>
                <th>Description</th>
                <th>Disease Name</th>
                <th></th>
            </tr>
            </thead>
            <tbody>
            <tr>
                <td>1</td>
                <td>Abc Hospital</td>
                <td>Magusa, salamis</td>
                <td>Well known for heart Surgery</td>
                <td>Cold</td>
                <td><button class=""btn btn-primary"">Edit</button> 
                    <button class=""btn btn-danger"">Delete</button>
                </td>
            </tr>     
            
            <tr>
                <");
            WriteLiteral(@"td>2</td>
                <td>Abc Hospital</td>
                <td>Magusa, salamis</td>
                <td>Well known for heart Surgery</td>
                <td>Cold</td>
                <td><button class=""btn btn-primary"">Edit</button> 
                    <button class=""btn btn-danger"">Delete</button>
                </td>
            </tr>    
        
            </tbody>
        </table>
    </div>
    <hr class=""bs-docs-separator"">
</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
