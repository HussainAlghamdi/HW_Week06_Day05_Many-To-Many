#pragma checksum "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\Branches\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "07bbea64815850cd29e18e9aa8ab03a04af428ed"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Branches_Index), @"mvc.1.0.view", @"/Views/Branches/Index.cshtml")]
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
#line 1 "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\_ViewImports.cshtml"
using EF_Start;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\_ViewImports.cshtml"
using EF_Start.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"07bbea64815850cd29e18e9aa8ab03a04af428ed", @"/Views/Branches/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2b679840ed3cf4ee88eb9da42b4b6591dbeefc3c", @"/Views/_ViewImports.cshtml")]
    public class Views_Branches_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\Branches\Index.cshtml"
  
    var Branches = (List<BranchModels>)ViewData["Branches"];
    

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\Branches\Index.cshtml"
                                                            
var search2 = ViewData["searchAdreesById"];
var search3 = (List<BranchModels>)ViewData["searchGreatThanThree"];



#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>this is the branche index</h1>

<table class=""table"">
    <thead>
        <tr>
            <th scope=""col"">Id</th>
            <th scope=""col"">Address</th>
            <th scope=""col"">Name</th>
            <th scope=""col"">Area</th>
        </tr>
    </thead>
    <tbody>
");
#nullable restore
#line 22 "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\Branches\Index.cshtml"
          

            foreach (var item in Branches)
            {


#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <th scope=\"row\">");
#nullable restore
#line 28 "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\Branches\Index.cshtml"
                               Write(item.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                    <td>");
#nullable restore
#line 29 "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\Branches\Index.cshtml"
                   Write(item.Address);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 30 "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\Branches\Index.cshtml"
                   Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                    <td>");
#nullable restore
#line 31 "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\Branches\Index.cshtml"
                   Write(item.Area);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                </tr>\r\n");
#nullable restore
#line 33 "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\Branches\Index.cshtml"
            }
        

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </tbody>\r\n</table>\r\n\r\n");
            WriteLiteral("\r\n###\r\n\r\n<h1>Search By Id</h1>\r\n<h2>for Id 2 : ");
#nullable restore
#line 70 "C:\Users\hussa\source\repos\EF_Start\EF_Start\Views\Branches\Index.cshtml"
          Write(search2);

#line default
#line hidden
#nullable disable
            WriteLiteral(" </h2>\r\n\r\n###\r\n\r\n");
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