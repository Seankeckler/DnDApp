#pragma checksum "D:\Repos\DnDApp\DnDApp\Views\Home\Monsters.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "af383693ad48552209779cde67ea01f988fd58b7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Monsters), @"mvc.1.0.view", @"/Views/Home/Monsters.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Monsters.cshtml", typeof(AspNetCore.Views_Home_Monsters))]
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
#line 1 "D:\Repos\DnDApp\DnDApp\Views\_ViewImports.cshtml"
using DnDApp;

#line default
#line hidden
#line 2 "D:\Repos\DnDApp\DnDApp\Views\_ViewImports.cshtml"
using DnDApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"af383693ad48552209779cde67ea01f988fd58b7", @"/Views/Home/Monsters.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"61d903abbb4141698c7a8554b85dadd81a6c145b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Monsters : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Monster>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(29, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\Repos\DnDApp\DnDApp\Views\Home\Monsters.cshtml"
  
    //(System.Collections.Generic.List<string>)
    List<String> Monsters = (System.Collections.Generic.List<string>)ViewData["MonsterNames"];
    

#line default
#line hidden
#line 6 "D:\Repos\DnDApp\DnDApp\Views\Home\Monsters.cshtml"
     foreach (var M in Monsters)
    {

#line default
#line hidden
            BeginContext(221, 12, true);
            WriteLiteral("        <h2>");
            EndContext();
            BeginContext(234, 1, false);
#line 8 "D:\Repos\DnDApp\DnDApp\Views\Home\Monsters.cshtml"
       Write(M);

#line default
#line hidden
            EndContext();
            BeginContext(235, 7, true);
            WriteLiteral("</h2>\r\n");
            EndContext();
#line 9 "D:\Repos\DnDApp\DnDApp\Views\Home\Monsters.cshtml"
    }

#line default
#line hidden
            BeginContext(264, 5, true);
            WriteLiteral("\r\n   ");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Monster>> Html { get; private set; }
    }
}
#pragma warning restore 1591
