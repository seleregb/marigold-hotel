#pragma checksum "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4524353ba681a01b44f1551c1421ca20ffa1917b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Edit), @"mvc.1.0.view", @"/Views/Reservations/Edit.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservations/Edit.cshtml", typeof(AspNetCore.Views_Reservations_Edit))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4524353ba681a01b44f1551c1421ca20ffa1917b", @"/Views/Reservations/Edit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beaf7bdd7101040862628f00d9f5d37499cfe8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelReservation.ViewModels.ReservationViewModel>
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
            BeginContext(56, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
  
    ViewBag.Title = "Edit";

#line default
#line hidden
            BeginContext(90, 131, true);
            WriteLiteral("\n<div class=\"card\" style=\"margin-top: 20px;\">\n    <div class=\"card-body\">\r\n        <h2 class=\"card-title\">Edit Reservation</h2>\r\n\r\n");
            EndContext();
#line 11 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
         using (Html.BeginForm())
    {
        

#line default
#line hidden
            BeginContext(272, 23, false);
#line 13 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
   Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(299, 39, true);
            WriteLiteral("        <div class=\"form-horizontal\">\r\n");
            EndContext();
            BeginContext(396, 12, true);
            WriteLiteral("            ");
            EndContext();
            BeginContext(409, 64, false);
#line 18 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
       Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(473, 14, true);
            WriteLiteral("\r\n            ");
            EndContext();
            BeginContext(488, 36, false);
#line 19 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
       Write(Html.HiddenFor(model => model.ResID));

#line default
#line hidden
            EndContext();
            BeginContext(524, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(586, 56, true);
            WriteLiteral("\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(643, 99, false);
#line 23 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
           Write(Html.LabelFor(model => model.CustomerID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(742, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(806, 187, false);
#line 25 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
               Write(Html.DropDownListFor(model => model.CustomerID, new SelectList(Model.Customers, "CustID", "CustomerName"), "Select Customer", htmlAttributes: new { @class = "form-control selectpicker" }));

#line default
#line hidden
            EndContext();
            BeginContext(993, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1016, 88, false);
#line 26 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.CustomerID, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1104, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1207, 105, false);
#line 31 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
           Write(Html.LabelFor(model => model.RoomID, "RoomID", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1312, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(1376, 145, false);
#line 33 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
               Write(Html.DropDownListFor(model => model.RoomID, new SelectList(Model.Rooms, "RoomID", "RoomNumber"), htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1521, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(1544, 84, false);
#line 34 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.RoomID, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1628, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(1731, 100, false);
#line 39 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
           Write(Html.LabelFor(model => model.CheckInDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1831, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(1895, 100, false);
#line 41 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
               Write(Html.EditorFor(model => model.CheckInDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1995, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2018, 89, false);
#line 42 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.CheckInDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2107, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2210, 101, false);
#line 47 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
           Write(Html.LabelFor(model => model.CheckOutDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2311, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(2375, 101, false);
#line 49 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
               Write(Html.EditorFor(model => model.CheckOutDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2476, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(2499, 90, false);
#line 50 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.CheckOutDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2589, 102, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n\r\n            <div class=\"form-group\">\r\n                ");
            EndContext();
            BeginContext(2692, 104, false);
#line 55 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
           Write(Html.LabelFor(model => model.TotalPaymentDue, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2796, 63, true);
            WriteLiteral("\r\n                <div class=\"col-md-10\">\r\n                    ");
            EndContext();
            BeginContext(2860, 127, false);
#line 57 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
               Write(Html.EditorFor(model => model.TotalPaymentDue, new { htmlAttributes = new { @class = "form-control", disabled = "disabled" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2987, 22, true);
            WriteLiteral("\r\n                    ");
            EndContext();
            BeginContext(3010, 93, false);
#line 58 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
               Write(Html.ValidationMessageFor(model => model.TotalPaymentDue, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3103, 273, true);
            WriteLiteral(@"
                </div>
            </div>

            <div class=""form-group"">
                <div class=""col-md-offset-2 col-md-10"">
                    <input type=""submit"" value=""Save"" class=""btn btn-primary"" style=""margin-right:5px;"" />
                    <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 3376, "\"", 3419, 1);
#line 65 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
WriteAttributeValue("", 3383, Url.Action("Index", "Reservations"), 3383, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(3420, 146, true);
            WriteLiteral(" class=\"btn btn-danger\">\r\n                        Cancel\r\n                    </a>\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n");
            EndContext();
#line 72 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Edit.cshtml"
}

#line default
#line hidden
            BeginContext(3569, 54, true);
            WriteLiteral("\r\n        <div>\r\n\r\n        </div>\r\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3641, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(3646, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "4524353ba681a01b44f1551c1421ca20ffa1917b14964", async() => {
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
                BeginContext(3690, 1, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelReservation.ViewModels.ReservationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591