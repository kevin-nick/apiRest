#pragma checksum "C:\Users\kevin\source\repos\prueba_empleo\prueba_empleo\Views\Home\loby.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f709d506b0edfc09c7f6569f5943147739f31f07"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_loby), @"mvc.1.0.view", @"/Views/Home/loby.cshtml")]
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
#line 1 "C:\Users\kevin\source\repos\prueba_empleo\prueba_empleo\Views\_ViewImports.cshtml"
using prueba_empleo;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kevin\source\repos\prueba_empleo\prueba_empleo\Views\_ViewImports.cshtml"
using prueba_empleo.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f709d506b0edfc09c7f6569f5943147739f31f07", @"/Views/Home/loby.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"858c5af20543f92317d8eaf7eae6bda7bbf7c84b", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_loby : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f709d506b0edfc09c7f6569f5943147739f31f073241", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Login</title>
    <link href=""https://cdn.jsdelivr.net/npm/bootstrap@5.0.0-beta3/dist/css/bootstrap.min.css"" rel=""stylesheet"" />
    <script src=""https://cdnjs.cloudflare.com/ajax/libs/jquery/3.6.0/jquery.min.js"" referrerpolicy=""no-referrer""></script>
    <link href=""./StyleSheet.css"" rel=""stylesheet"" type=""text/css"" />
");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f709d506b0edfc09c7f6569f5943147739f31f074589", async() => {
                WriteLiteral(@"
    <div>
        <div class='menujohanes'>
            <ul class='dark_menu'>
                <li>
                    <a class='selected' expr:href='data:blog.homepageUrl' title='Home'>
                        Home
                    </a>
                </li>

                <li data-role='dropdown'>
                    <a href='#'>
                        Categories
                    </a>
                    <ul>
                        <li id='sub'>
                            <a href='#'>
                                Lorem ipsum
                            </a>
                            <ul>
                                <li>
                                    <a href='#'>
                                        Categories2
                                    </a>
                                </li>
                                <li>
                                    <a href='#'>
                                        Categories3
                          ");
                WriteLiteral(@"          </a>
                                </li>
                            </ul>

                        </li>

                        <li>
                            <a href='#'>
                                Lorem ipsum
                            </a>
                        </li>
                        <li>
                            <a href='#'>
                                Lorem ipsum
                            </a>
                        </li>
                        <li>
                            <a href='#'>
                                Lorem ipsum
                            </a>
                        </li>
                        <li>
                            <a href='#'>
                                Download
                            </a>
                        </li>
                        <li>
                            <a href='#'>
                                Lorem ipsum
                            </a>
                       ");
                WriteLiteral(" </li>\r\n                    </ul>\r\n                </li>\r\n            </ul>\r\n \r\n        </div>\r\n            \r\n    </div>\r\n\r\n    <script>\r\n        $(document).ready(function () {\r\n           \r\n        });\r\n\r\n    </script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
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
