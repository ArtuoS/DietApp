#pragma checksum "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\UIElements\TablesPanels.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6e1e0f38e4640ea05491fd011d4398967e831d09"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_UIElements_TablesPanels), @"mvc.1.0.view", @"/Views/UIElements/TablesPanels.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/UIElements/TablesPanels.cshtml", typeof(AspNetCore.Views_UIElements_TablesPanels))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6e1e0f38e4640ea05491fd011d4398967e831d09", @"/Views/UIElements/TablesPanels.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bf3ab1a3ff43760fcc2127914d0c3d050c712654", @"/Views/_ViewImports.cshtml")]
    public class Views_UIElements_TablesPanels : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 2 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\UIElements\TablesPanels.cshtml"
  
    ViewData["Title"] = "TablesPanels";

#line default
#line hidden
            BeginContext(46, 213, true);
            WriteLiteral("\n<div class=\"row wrapper border-bottom white-bg page-heading\">\n    <div class=\"col-lg-10\">\n        <h2>Tabs & Panels</h2>\n        <ol class=\"breadcrumb\">\n            <li class=\"breadcrumb-item\">\n                <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 259, "\"", 306, 1);
#line 11 "C:\Users\Joana.DESKTOP-1T5I4G0\Desktop\ASPNET_Core_2_1_Full_Project\ASPNET_Core_2_1\Views\UIElements\TablesPanels.cshtml"
WriteAttributeValue("", 266, Url.Action("Dashboard_1", "Dashboards"), 266, 40, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(307, 20321, true);
            WriteLiteral(@">Home</a>
            </li>
            <li class=""breadcrumb-item"">
                <a>UI Elements</a>
            </li>
            <li class=""active breadcrumb-item"">
                <strong>Tabs & Panels</strong>
            </li>
        </ol>
    </div>
    <div class=""col-lg-2"">

    </div>
</div>
<div class=""wrapper wrapper-content animated fadeIn"">
    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Basic IN+ Panel <small class=""m-l-sm"">This is custom panel</small></h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                     ");
            WriteLiteral(@"       <li>
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
                    <h2>
                        This is standard IN+ Panel<br />
                    </h2>
                    <p>
                        <strong>Lorem ipsum dolor</strong>
                        Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim.
                    </p>
        ");
            WriteLiteral(@"            <p>
                        <small>
                            Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi.
                        </small>
                    </p>
                </div>
                <div class=""ibox-footer"">
                    <span class=""float-right"">
                        The righ side of the footer
                    </span>
                    This is simple footer example
                </div>
            </div>
        </div>
        <div class=""col-lg-12"">
            <div class=""ibox collapsed"">
                <div class=""ibox-title"">
                    <h5>Example of <small>initial</small> collapsed panel</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
  ");
            WriteLiteral(@"                      </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
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
                        Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ");
            WriteLiteral(@"ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim.
                    </p>
                    <p>
                        Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi.
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-lg-12"">
            <div class=""ibox"">
                <div class=""ibox-title"">
                    <h5>Example with fullscreen option</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""fullscreen-link"">
                            <i class=""fa fa-expand""></i>
                        </a>
                        <a class=""close-link"">
           ");
            WriteLiteral(@"                 <i class=""fa fa-times""></i>
                        </a>
                    </div>
                </div>
                <div class=""ibox-content"">

                    <p>
                        Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec, pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim.
                    </p>
                    <p>
                        Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo, rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi.
                    </p>
                </div>
            </div>
        </div>
        <div class=""col-lg-12"">
            <div class=""ibox"">
                <div class=""ibox-title"">
                    <h5>Example of constant height with scroll</h5>
     ");
            WriteLiteral(@"               <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#"">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
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
                    <div class=""scroll_content"">");
            WriteLiteral(@"
                        <p>
                            Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis
                            dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec,
                            pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim.
                            Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis
                            dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec,
                            pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim.
                            Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis
                            dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec,
                            pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim.
                        </p>

     ");
            WriteLiteral(@"                   <p>
                            Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo,
                            rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis
                            pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi.
                            Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis
                            dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec,
                            pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim.
                            Aenean commodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis
                            dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec,
                            pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim.
                            Aenean co");
            WriteLiteral(@"mmodo ligula eget dolor. Aenean massa. Cum sociis natoque penatibus et magnis
                            dis parturient montes, nascetur ridiculus mus. Donec quam felis, ultricies nec,
                            pellentesque eu, pretium quis, sem. Nulla consequat massa quis enim.
                        </p>
                        <p>
                            Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo,
                            rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis
                            pretium. Integer tincidunt. Cras dapibus. Vivamus elementum semper nisi.
                        </p>
                        <p>
                            Donec pede justo, fringilla vel, aliquet nec, vulputate eget, arcu. In enim justo,
                            rhoncus ut, imperdiet a, venenatis vitae, justo. Nullam dictum felis eu pede mollis
                            pretium. Integer tincidunt. Cras dapibus. Vivamus el");
            WriteLiteral(@"ementum semper nisi.
                        </p>
                    </div>
                </div>
            </div>
        </div>
    </div>


    <div class=""row"">
        <div class=""col-lg-12"">
            <div class=""ibox"">
                <div class=""ibox-title"">
                    <h5>Bootstrap 3.3.x Panels <small>Custom background colors.</small></h5>
                </div>
                <div class=""ibox-content"">

                    <div class=""row"">
                        <div class=""col-lg-4"">
                            <div class=""panel panel-default"">
                                <div class=""panel-heading"">
                                    Default Panel
                                </div>
                                <div class=""panel-body"">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                   ");
            WriteLiteral(@"             </div>

                            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""panel panel-primary"">
                                <div class=""panel-heading"">
                                    Primary Panel
                                </div>
                                <div class=""panel-body"">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""panel panel-success"">
                                <div class=""panel-heading"">
                                    Success Panel
                                </div>
                                <div cla");
            WriteLiteral(@"ss=""panel-body"">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                                </div>
                            </div>
                        </div>
                    </div>
                    <div class=""row"">
                        <div class=""col-lg-4"">
                            <div class=""panel panel-info"">
                                <div class=""panel-heading"">
                                    <i class=""fa fa-info-circle""></i> Info Panel
                                </div>
                                <div class=""panel-body"">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                                </div>

                ");
            WriteLiteral(@"            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""panel panel-warning"">
                                <div class=""panel-heading"">
                                    <i class=""fa fa-warning""></i> Warning Panel
                                </div>
                                <div class=""panel-body"">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                                </div>
                            </div>
                        </div>
                        <div class=""col-lg-4"">
                            <div class=""panel panel-danger"">
                                <div class=""panel-heading"">
                                    Danger Panel with Footer
                                </div>
                                <div ");
            WriteLiteral(@"class=""panel-body"">
                                    <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue.</p>
                                </div>
                                <div class=""panel-footer"">
                                    Panel Footer
                                </div>
                            </div>
                        </div>
                    </div>

                </div>
            </div>
        </div>
    </div>

    <div class=""row"">
        <div class=""col-lg-6"">
            <div class=""ibox "">
                <div class=""ibox-title"">
                    <h5>Collaps panels</h5>
                    <div class=""ibox-tools"">
                        <a class=""collapse-link"">
                            <i class=""fa fa-chevron-up""></i>
                        </a>
                        <a class=""dropdown-toggle"" data-toggle=""dropdown"" href=""#");
            WriteLiteral(@""">
                            <i class=""fa fa-wrench""></i>
                        </a>
                        <ul class=""dropdown-menu dropdown-user"">
                            <li>
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
                    <div class=""panel-body"">
                        <div class=""panel-group"" id=""accordion"">
                            <div class=""panel panel-default"">
                                <div class=""panel-heading"">
                                    <h5 class=""panel-title"">
                ");
            WriteLiteral(@"                        <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseOne"">Collapsible Group Item #1</a>
                                    </h5>
                                </div>
                                <div id=""collapseOne"" class=""panel-collapse collapse in"">
                                    <div class=""panel-body"">
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                                    </div>
                                </div>
                            </div>
                            <div class=""panel panel-default"">
 ");
            WriteLiteral(@"                               <div class=""panel-heading"">
                                    <h4 class=""panel-title"">
                                        <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseTwo"">Collapsible Group Item #2</a>
                                    </h4>
                                </div>
                                <div id=""collapseTwo"" class=""panel-collapse collapse"">
                                    <div class=""panel-body"">
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaecat cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                                    </div>
    ");
            WriteLiteral(@"                            </div>
                            </div>
                            <div class=""panel panel-default"">
                                <div class=""panel-heading"">
                                    <h4 class=""panel-title"">
                                        <a data-toggle=""collapse"" data-parent=""#accordion"" href=""#collapseThree"">Collapsible Group Item #3</a>
                                    </h4>
                                </div>
                                <div id=""collapseThree"" class=""panel-collapse collapse"">
                                    <div class=""panel-body"">
                                        Lorem ipsum dolor sit amet, consectetur adipisicing elit, sed do eiusmod tempor incididunt ut labore et dolore magna aliqua. Ut enim ad minim veniam, quis nostrud exercitation ullamco laboris nisi ut aliquip ex ea commodo consequat. Duis aute irure dolor in reprehenderit in voluptate velit esse cillum dolore eu fugiat nulla pariatur. Excepteur sint occaec");
            WriteLiteral(@"at cupidatat non proident, sunt in culpa qui officia deserunt mollit anim id est laborum.
                                    </div>
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <div class=""col-lg-6"">
            <div class=""jumbotron"">
                <h1>Jumbotron</h1>
                <p>Lorem ipsum dolor sit amet, consectetur adipiscing elit. Vestibulum tincidunt est vitae ultrices accumsan. Aliquam ornare lacus adipiscing, posuere lectus et, fringilla augue. Lorem ipsum dolor sit amet, consectetur adipiscing elit.</p>
                <p>
                    <a href="""" role=""button"" class=""btn btn-primary btn-lg"">Learn more</a>
                </p>
            </div>
        </div>
    </div>
</div>

");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(20646, 240, true);
                WriteLiteral("\n\n    <script type=\"text/javascript\">\n        $(document).ready(function () {\n\n            // Add slimscroll to element\n            $(\'.scroll_content\').slimscroll({\n                height: \'200px\'\n            })\n\n        });\n    </script>\n");
                EndContext();
            }
            );
            BeginContext(20888, 3, true);
            WriteLiteral("\n\n\n");
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
