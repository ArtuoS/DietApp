#pragma checksum "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\Forms\Markdown.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "36aa4a13289f090362aaa36ddea067373523af9d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Forms_Markdown), @"mvc.1.0.view", @"/Views/Forms/Markdown.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Forms/Markdown.cshtml", typeof(AspNetCore.Views_Forms_Markdown))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"36aa4a13289f090362aaa36ddea067373523af9d", @"/Views/Forms/Markdown.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3ab1a3ff43760fcc2127914d0c3d050c712654", @"/Views/_ViewImports.cshtml")]
    public class Views_Forms_Markdown : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap-markdown/css/bootstrap-markdown.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("names", "Development,Staging,Productio", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap-markdown/js/bootstrap-markdown.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/markdown/lib/markdown.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\Forms\Markdown.cshtml"
  
    ViewData["Title"] = "Markdown";

#line default
#line hidden
            BeginContext(42, 208, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-10\">\n        <h2>Markdown</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 250, "\"", 297, 1);
#line 11 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\Forms\Markdown.cshtml"
WriteAttributeValue("", 257, Url.Action("Dashboard_1", "Dashboards"), 257, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(298, 8987, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>Forms</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Markdown</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>

<div class=""wrapper wrapper-content"">

    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Bootstrap markdown <small>http://www.codingdrama.com/bootstrap-markdown/</small></h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>");
            WriteLiteral(@"
                                <a href=""#"" class=""dropdown-item"">Config option 1</a>
                            </li>
                            <li>
                                <a href=""#"" class=""dropdown-item"">Config option 2</a>
                            </li>
                        </ul>
                        <a class=""close-link"">
                            <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">
                    <p>
                        Bootstrap-Markdown designed to be easily integrated with your bootstrap project. It exposes useful API that allow you to fully hook-in into the plugin
                    </p>
                    <p>
                        Switch regular textarea within your form into Bootstrap-Markdown editor seamlessly by adding <code>data-provide=""markdown""</code> attribute
                    </p>

                    <textarea name=""content"" data-provide");
            WriteLiteral(@"=""markdown"" rows=""10"">
h1 header
============

Paragraphs are separated by a blank line.

2nd paragraph. *Italic*, **bold**, and `monospace`. Itemized lists
look like:

* this one
* that one
* the other one
                    </textarea>
                </div>
            </div>
        </div>
    </div>
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">

                <div class=""ibox-content"">

                    <h2>
                        Usage
                    </h2>
                    <p>
                        Beside using above data-attributes, you could call it via code
                    </p>
                    <pre>
$(""#some-textarea"").markdown({autofocus:false,savable:false}) </pre>
                    <h4>
                        Available options are:
                    </h4>

                    <table class=""table table-striped"">
                        <thead>
                            <tr>
                                <th>Option Name</th>
 ");
            WriteLiteral(@"                               <th>Type</th>
                                <th>Description</th>
                            </tr>
                        </thead>
                        <tbody>
                            <tr>
                                <td>
                                    <code>autofocus</code>
                                </td>
                                <td><code>boolean</code></td>
                                <td>Indicates that editor will focused after instantiated. Default to <code>false</code></td>
                            </tr>
                            <tr>
                                <td>
                                    <code>savable</code>
                                </td>
                                <td><code>boolean</code></td>
                                <td>Indicates that editor will have save button and action. Default to <code>false</code></td>
                            </tr>
                            <tr>
                 ");
            WriteLiteral(@"               <td>
                                    <code>hideable</code>
                                </td>
                                <td><code>boolean</code></td>
                                <td>If set to <code>true</code> then the editor will be hidden on <code>blur</code> event. Default to <code>false</code></td>
                            </tr>
                            <tr>
                                <td>
                                    <code>width</code>
                                </td>
                                <td><code>mixed</code></td>
                                <td>The editor width. Default to <code>inherit</code>. You could supply any numerical value (that will be set as css), or supply valid Bootstrap class (something like <code>span2</code>)</td>
                            </tr>
                            <tr>
                                <td>
                                    <code>height</code>
                                </td>
         ");
            WriteLiteral(@"                       <td><code>mixed</code></td>
                                <td>The editor height. Default to <code>inherit</code></td>
                            </tr>
                            <tr>
                                <td>
                                    <code>resize</code>
                                </td>
                                <td><code>string</code></td>
                                <td>
                                    Option to disable or change the resize property, possible values <code>none</code>,<code>both</code>,<code>horizontal</code>,<code>vertical</code>. Default <code>none</code><br>
                                    If this option is enabled, the user will be able to resize the editor and preview screen.<br><br>
                                    <div class=""alert alert-warning"">
                                        <strong>Browser support</strong>
                                        <p>This is currently only supported on limited browser");
            WriteLiteral(@"s. See <a href=""http://caniuse.com/css-resize"" target=""_blank"">Can you run it: Resize</a> for all supported browsers</p>
                                    </div>
                                </td>
                            </tr>
                            <tr>
                                <td>
                                    <code>iconlibrary</code>
                                </td>
                                <td><code>string</code></td>
                                <td>The icon library to use. Glyphicons (<code>glyph</code>) and Font Awesome (<code>fa</code>) are supported. In order to use Font Awesome properly, you'll need to <a href=""http://fontawesome.io/get-started/"">include Font Awesome stylesheet</a> yourself. Default to <code>glyph</code></td>
                            </tr>
                            <tr>
                                <td>
                                    <code>language</code>
                                </td>
                                <td");
            WriteLiteral(@"><code>string</code></td>
                                <td>Localization setting. Default to <code>en</code></td>
                            </tr>

                            <tr>
                                <td>
                                    <code>footer</code>
                                </td>
                                <td><code>mixed</code></td>
                                <td>Footer dom. Can be string or callback. Default is empty string</td>
                            </tr>

                            <tr>
                                <td>
                                    <code>fullscreen</code>
                                </td>
                                <td><code>object</code></td>
                                <td>Contains <code>enable</code> (<code>bool</code>) and <code>icons</code> (<code>object</code>) keys.</td>
                            </tr>



                            <tr>
                                <td>
                                 ");
            WriteLiteral(@"   <code>hiddenButtons</code>
                                </td>
                                <td><code>mixed</code></td>
                                <td>Array or string of button names to be hidden. Default is empty string</td>
                            </tr>

                            <tr>
                                <td>
                                    <code>disabledButtons</code>
                                </td>
                                <td><code>mixed</code></td>
                                <td>Array or string of button names to be disabled. Default is empty string</td>
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
            DefineSection("Styles", async() => {
                BeginContext(9302, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(9307, 167, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "feb27a9182c945c3b1399c4fd94fd2d5", async() => {
                    BeginContext(9358, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(9367, 88, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "29a0be51621e4cf5bd0e2b6571e66955", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
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
                    BeginContext(9455, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9474, 2, true);
                WriteLiteral("\n\n");
                EndContext();
            }
            );
            BeginContext(9478, 1, true);
            WriteLiteral("\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(9497, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(9502, 215, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("environment", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f44fe3d54c494aafb7ff610157cb9d7e", async() => {
                    BeginContext(9553, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(9562, 73, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1aa4828e00a845febdc26e0c00acb35c", async() => {
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
                    BeginContext(9635, 9, true);
                    WriteLiteral("\n        ");
                    EndContext();
                    BeginContext(9644, 54, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "131e04252c424161b127ea012c6e7494", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                    __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(9698, 5, true);
                    WriteLiteral("\n    ");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.EnvironmentTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_EnvironmentTagHelper.Names = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(9717, 2, true);
                WriteLiteral("\n\n");
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
