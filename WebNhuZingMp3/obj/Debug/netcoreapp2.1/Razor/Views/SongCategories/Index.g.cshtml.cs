#pragma checksum "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\SongCategories\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "37937c7fd64975f3f1a212ae5f590b2b04023c70"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_SongCategories_Index), @"mvc.1.0.view", @"/Views/SongCategories/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/SongCategories/Index.cshtml", typeof(AspNetCore.Views_SongCategories_Index))]
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
#line 1 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\_ViewImports.cshtml"
using WebNhuZingMp3;

#line default
#line hidden
#line 2 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\_ViewImports.cshtml"
using WebNhuZingMp3.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"37937c7fd64975f3f1a212ae5f590b2b04023c70", @"/Views/SongCategories/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7db3c84879ab993a1096de83c18c347d2657b01", @"/Views/_ViewImports.cshtml")]
    public class Views_SongCategories_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebNhuZingMp3.Models.SongCategory>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(55, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\SongCategories\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(98, 29, true);
            WriteLiteral("\r\n<h2>Index</h2>\r\n\r\n<p>\r\n    ");
            EndContext();
            BeginContext(127, 37, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "69d4d1bb25974ee995dd6de7e91f0005", async() => {
                BeginContext(150, 10, true);
                WriteLiteral("Create New");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(164, 92, true);
            WriteLiteral("\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(257, 40, false);
#line 16 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\SongCategories\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Song));

#line default
#line hidden
            EndContext();
            BeginContext(297, 55, true);
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
            EndContext();
            BeginContext(353, 44, false);
#line 19 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\SongCategories\Index.cshtml"
           Write(Html.DisplayNameFor(model => model.Category));

#line default
#line hidden
            EndContext();
            BeginContext(397, 86, true);
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
            EndContext();
#line 25 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\SongCategories\Index.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
            BeginContext(515, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(564, 46, false);
#line 28 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\SongCategories\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Song.SongId));

#line default
#line hidden
            EndContext();
            BeginContext(610, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(666, 54, false);
#line 31 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\SongCategories\Index.cshtml"
           Write(Html.DisplayFor(modelItem => item.Category.CategoryId));

#line default
#line hidden
            EndContext();
            BeginContext(720, 55, true);
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(776, 65, false);
#line 34 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\SongCategories\Index.cshtml"
           Write(Html.ActionLink("Edit", "Edit", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(841, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(862, 71, false);
#line 35 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\SongCategories\Index.cshtml"
           Write(Html.ActionLink("Details", "Details", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(933, 20, true);
            WriteLiteral(" |\r\n                ");
            EndContext();
            BeginContext(954, 69, false);
#line 36 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\SongCategories\Index.cshtml"
           Write(Html.ActionLink("Delete", "Delete", new { /* id=item.PrimaryKey */ }));

#line default
#line hidden
            EndContext();
            BeginContext(1023, 36, true);
            WriteLiteral("\r\n            </td>\r\n        </tr>\r\n");
            EndContext();
#line 39 "C:\Users\chunl\source\repos\WebNhuZingMp3\WebNhuZingMp3\Views\SongCategories\Index.cshtml"
}

#line default
#line hidden
            BeginContext(1062, 24, true);
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebNhuZingMp3.Models.SongCategory>> Html { get; private set; }
    }
}
#pragma warning restore 1591
