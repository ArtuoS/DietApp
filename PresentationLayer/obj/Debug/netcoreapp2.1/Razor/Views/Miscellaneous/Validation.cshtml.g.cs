#pragma checksum "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\Miscellaneous\Validation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "72ff8c678832ca3156e1b343311cf6d4511f7af4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Miscellaneous_Validation), @"mvc.1.0.view", @"/Views/Miscellaneous/Validation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Miscellaneous/Validation.cshtml", typeof(AspNetCore.Views_Miscellaneous_Validation))]
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
#line 1 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\_ViewImports.cshtml"
using ASPNET_Core_2_1;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"72ff8c678832ca3156e1b343311cf6d4511f7af4", @"/Views/Miscellaneous/Validation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3ab1a3ff43760fcc2127914d0c3d050c712654", @"/Views/_ViewImports.cshtml")]
    public class Views_Miscellaneous_Validation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("id", new global::Microsoft.AspNetCore.Html.HtmlString("form"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-ui/jquery-ui.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/validate/jquery.validate.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Production", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\Miscellaneous\Validation.cshtml"
  
    ViewData["Title"] = "Validation";

#line default
#line hidden
            BeginContext(44, 210, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-10\">\n        <h2>Validation</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 254, "\"", 301, 1);
#line 11 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\Miscellaneous\Validation.cshtml"
WriteAttributeValue("", 261, Url.Action("Dashboard_1", "Dashboards"), 261, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(302, 1074, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Tables</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Validation</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content  animated fadeInRight"">
    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Validation</h5>
                </div>
                <div class=""ibox-content"">
                    <h2>
                        jQuery Validation Plugin - Form validation made easy
                    </h2>
                    <p>
                        The jQuery Validation Plugin provides drop-in validation for your existing forms, while making all kinds of customizations to fit your application really easy.
                    </p>

                    <p class=""font-bold"">Example form with custom valida");
            WriteLiteral("tion on each form control</p>\n                    ");
            EndContext();
            BeginContext(1376, 1173, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ddef09f5bce24973a2a14dba2d16905c", async() => {
                BeginContext(1404, 1138, true);
                WriteLiteral(@"
                        <div class=""form-group""><label>Email</label> <input type=""email"" placeholder=""Enter email"" class=""form-control"" required></div>
                        <div class=""form-group""><label>Password</label> <input type=""password"" placeholder=""Password"" class=""form-control"" name=""password""></div>
                        <div class=""form-group""><label>Url</label> <input type=""text"" placeholder=""Enter URL"" class=""form-control"" name=""url""></div>
                        <div class=""form-group""><label>Number</label> <input type=""text"" placeholder=""Enter Number"" class=""form-control"" name=""number""></div>
                        <div class=""form-group""><label>MinLength</label> <input type=""text"" placeholder=""Enter text"" class=""form-control"" name=""min""></div>
                        <div class=""form-group""><label>MaxLength</label> <input type=""text"" placeholder=""Enter text"" class=""form-control"" name=""max""></div>
                        <div>
                            <button class=""btn btn-sm btn-pr");
                WriteLiteral("imary m-t-n-xs\" type=\"submit\"><strong>Submit</strong></button>\n                        </div>\n                    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2549, 4014, true);
            WriteLiteral(@"
                </div>
            </div>


        </div>
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Methods</h5>
                </div>
                <div class=""ibox-content"">
                    <h2>
                        List of built-in Validation methods
                    </h2>
                    <p>
                        A set of standard validation methods is provided:
                    </p>

                    <table class=""table table-bordered"">
                        <thead>
                            <tr>
                                <th>Method</th>
                                <th>Description</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>remote</td>
                                <td>Requests a resource to check the element for validity.</td>
                       ");
            WriteLiteral(@"     </tr>
                            <tr>
                                <td>minlength</td>
                                <td>Makes the element require a given minimum length.</td>
                            </tr>
                            <tr>
                                <td>   maxlength</td>
                                <td>Makes the element require a given maxmimum length.</td>
                            </tr>
                            <tr>
                                <td> rangelength</td>
                                <td> Makes the element require a given value range.</td>
                            </tr>
                            <tr>
                                <td>  min</td>
                                <td>  Makes the element require a given minimum.</td>
                            </tr>
                            <tr>
                                <td>   max</td>
                                <td> Makes the element require a given maximum.</td>
               ");
            WriteLiteral(@"             </tr>
                            <tr>
                                <td> range</td>
                                <td> Makes the element require a given value range.</td>
                            </tr>
                            <tr>
                                <td> email</td>
                                <td> Makes the element require a valid email</td>
                            </tr>
                            <tr>
                                <td>  url</td>
                                <td>  Makes the element require a valid url</td>
                            </tr>
                            <tr>
                                <td>   date</td>
                                <td> Makes the element require a date.</td>
                            </tr>
                            <tr>
                                <td> dateISO</td>
                                <td> Makes the element require an ISO date.</td>
                            </tr>
                   ");
            WriteLiteral(@"         <tr>
                                <td> number</td>
                                <td> Makes the element require a decimal number.</td>
                            </tr>
                            <tr>
                                <td> digits</td>
                                <td>  Makes the element require digits only.</td>
                            </tr>
                            <tr>
                                <td> creditcard</td>
                                <td> Makes the element require a credit card number.</td>
                            </tr>
                            <tr>
                                <td> equalTo</td>
                                <td> Requires the element to be the same as another one</td>
                            </tr>
                        </tbody>
                    </table>
                </div>
            </div>


        </div>
    </div>

</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(6581, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(6586, 202, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a9b6b8443d944da884160c36d208742", async() => {
                    BeginContext(6638, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(6647, 52, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "435a7de76378477ab736470b4cd42575", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(6699, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(6708, 61, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e09d78b3127c4ea9a0afbd2b6ecafac3", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(6769, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(6788, 838, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            $(""#form"").validate({
                rules: {
                    password: {
                        required: true,
                        minlength: 3
                    },
                    url: {
                        required: true,
                        url: true
                    },
                    number: {
                        required: true,
                        number: true
                    },
                    min: {
                        required: true,
                        minlength: 6
                    },
                    max: {
                        required: true,
                        maxlength: 4
                    }
                }
            });

        });
    </script>
");
                EndContext();
            }
            );
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
