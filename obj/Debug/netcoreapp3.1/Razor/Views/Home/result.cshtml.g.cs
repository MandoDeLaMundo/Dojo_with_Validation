#pragma checksum "C:\Users\armti\Desktop\coding_dojo\c#\asp.netcore\Dojo_with_Validation\Views\Home\result.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "14a429fe79e2ec0a2011c9981c89d324bb0763d3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_result), @"mvc.1.0.view", @"/Views/Home/result.cshtml")]
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
#line 1 "C:\Users\armti\Desktop\coding_dojo\c#\asp.netcore\Dojo_with_Validation\Views\_ViewImports.cshtml"
using Dojo_with_Validation;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\armti\Desktop\coding_dojo\c#\asp.netcore\Dojo_with_Validation\Views\_ViewImports.cshtml"
using Dojo_with_Validation.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 1 "C:\Users\armti\Desktop\coding_dojo\c#\asp.netcore\Dojo_with_Validation\Views\Home\result.cshtml"
using Dojo_Survey.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"14a429fe79e2ec0a2011c9981c89d324bb0763d3", @"/Views/Home/result.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f5f86817991e4db166ad4fefea9f5d6c35ab725d", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_result : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<User>
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
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a429fe79e2ec0a2011c9981c89d324bb0763d33526", async() => {
                WriteLiteral("\r\n    <meta charset=\"UTF-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\">\r\n    <title>Document</title>\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "14a429fe79e2ec0a2011c9981c89d324bb0763d34702", async() => {
                WriteLiteral("\r\n    <h1>Submitted Info</h1>\r\n    <p>Your Name: ");
#nullable restore
#line 14 "C:\Users\armti\Desktop\coding_dojo\c#\asp.netcore\Dojo_with_Validation\Views\Home\result.cshtml"
             Write(Model.NameField);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Dojo Location: ");
#nullable restore
#line 15 "C:\Users\armti\Desktop\coding_dojo\c#\asp.netcore\Dojo_with_Validation\Views\Home\result.cshtml"
                 Write(Model.DojoField);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Favorite Language: ");
#nullable restore
#line 16 "C:\Users\armti\Desktop\coding_dojo\c#\asp.netcore\Dojo_with_Validation\Views\Home\result.cshtml"
                     Write(Model.LanguageField);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <p>Comment: ");
#nullable restore
#line 17 "C:\Users\armti\Desktop\coding_dojo\c#\asp.netcore\Dojo_with_Validation\Views\Home\result.cshtml"
           Write(Model.CommentField);

#line default
#line hidden
#nullable disable
                WriteLiteral("</p>\r\n    <br>\r\n    <a href=\"/\">Go back</a>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<User> Html { get; private set; }
    }
}
#pragma warning restore 1591