#pragma checksum "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7d871b3806fd2bd934c4c0c1f0e66a3bfd01fac2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payments_Edit), @"mvc.1.0.view", @"/Views/Payments/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Payments/Edit.cshtml", typeof(AspNetCore.Views_Payments_Edit))]
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
#line 1 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/_ViewImports.cshtml"
using HotelReservation.Application;

#line default
#line hidden
#line 2 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/_ViewImports.cshtml"
using HotelReservation.Application.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7d871b3806fd2bd934c4c0c1f0e66a3bfd01fac2", @"/Views/Payments/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beaf7bdd7101040862628f00d9f5d37499cfe8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Payments_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelReservation.ViewModels.PaymentViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(52, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
            BeginContext(86, 161, true);
            WriteLiteral("\n<div class=\"card\" style=\"margin-top: 20px;\">\n    <div class=\"card-body\">\r\n        <h2 class=\"card-title\">Edit</h2>\r\n\r\n        <h2 class=\"card-title\">Edit</h2>\r\n");
            EndContext();
#line 12 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
         using (Html.BeginForm())
        { 
            

#line default
#line hidden
            BeginContext(305, 23, false);
#line 14 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(332, 101, true);
            WriteLiteral("        <div class=\"form-horizontal\">\r\n            <h4>Payment</h4>\r\n            <hr />\r\n            ");
            EndContext();
            BeginContext(434, 64, false);
#line 19 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(498, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(513, 40, false);
#line 20 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
       Write(Html.HiddenFor(model => model.PaymentID));

#line default
#line hidden
            EndContext();
            BeginContext(553, 58, true);
            WriteLiteral("\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(612, 99, false);
#line 23 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
           Write(Html.LabelFor(model => model.CustomerID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(711, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(775, 122, false);
#line 25 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
               Write(Html.EditorFor(model => model.CustomerID, new { htmlAttributes = new { @class = "form-control", disabled = "disabled" } }));

#line default
#line hidden
            EndContext();
            BeginContext(897, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1014, 24, true);
            WriteLiteral("                </div>\r\n");
            EndContext();
            BeginContext(1451, 76, true);
            WriteLiteral("            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1528, 101, false);
#line 36 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
           Write(Html.LabelFor(model => model.CustomerName, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1629, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(1693, 124, false);
#line 38 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
               Write(Html.EditorFor(model => model.CustomerName, new { htmlAttributes = new { @class = "form-control", disabled = "disabled" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1817, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1840, 90, false);
#line 39 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.CustomerName, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1930, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2033, 129, false);
#line 44 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
           Write(Html.LabelFor(model => model.PaymentDescription, "PaymentDescription", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2162, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(2226, 120, false);
#line 46 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
               Write(Html.Editor("PaymentDescription", null, new { htmlAttributes = new { @class = "form-control", disabled = "disabled" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2346, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2369, 96, false);
#line 47 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.PaymentDescription, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2465, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2568, 102, false);
#line 52 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
           Write(Html.LabelFor(model => model.PaymentAmount, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2670, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(2734, 104, false);
#line 54 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
               Write(Html.TextAreaFor(model => model.PaymentAmount, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2838, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2861, 91, false);
#line 55 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.PaymentAmount, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2952, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(3055, 103, false);
#line 60 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
           Write(Html.LabelFor(model => model.PaymentDetails, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3158, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(3222, 126, false);
#line 62 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
               Write(Html.EditorFor(model => model.PaymentDetails, new { htmlAttributes = new { @class = "form-control", disabled = "disabled" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3348, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3371, 92, false);
#line 63 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.PaymentDetails, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3463, 247, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                <div class=\"col-md-offset-2 col-md-10\">\r\n                    <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3710, "\"", 3737, 1);
#line 70 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
WriteAttributeValue("", 3717, Url.Action("Index"), 3717, 20, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3738, 144, true);
            WriteLiteral(" class=\"btn btn-danger\">\r\n                        Cancel\r\n                    </a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 76 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Edit.cshtml"
        }

#line default
#line hidden
            BeginContext(3893, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(3985, 19, true);
            WriteLiteral("    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4022, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(4027, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "7d871b3806fd2bd934c4c0c1f0e66a3bfd01fac214495", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4071, 1, true);
                WriteLiteral("\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelReservation.ViewModels.PaymentViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
