#pragma checksum "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f2bfa754189307bac62962be79062483e839c0be"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Payments_Index), @"mvc.1.0.view", @"/Views/Payments/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Payments/Index.cshtml", typeof(AspNetCore.Views_Payments_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f2bfa754189307bac62962be79062483e839c0be", @"/Views/Payments/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beaf7bdd7101040862628f00d9f5d37499cfe8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Payments_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelReservation.ViewModels.PaymentViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(65, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(100, 129, true);
            WriteLiteral("<div class=\"card\" style=\"margin-top: 20px;\">\n    <div class=\"card-body\">\r\n        <h2 class=\"card-title\">Payment History</h2>\r\n\r\n");
            EndContext();
            BeginContext(314, 91, true);
            WriteLiteral("        <table class=\"table\">\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(406, 48, false);
#line 16 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(454, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(522, 54, false);
#line 19 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PaymentDescription));

#line default
#line hidden
            EndContext();
            BeginContext(576, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(644, 49, false);
#line 22 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PaymentAmount));

#line default
#line hidden
            EndContext();
            BeginContext(693, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(761, 50, false);
#line 25 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.PaymentDetails));

#line default
#line hidden
            EndContext();
            BeginContext(811, 73, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n\r\n");
            EndContext();
#line 30 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
             foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(937, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(998, 47, false);
#line 34 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1045, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1113, 53, false);
#line 37 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PaymentDescription));

#line default
#line hidden
            EndContext();
            BeginContext(1166, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1234, 48, false);
#line 40 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PaymentAmount));

#line default
#line hidden
            EndContext();
            BeginContext(1282, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1350, 49, false);
#line 43 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.PaymentDetails));

#line default
#line hidden
            EndContext();
            BeginContext(1399, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 46 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
                     if ((User.IsInRole("RECEPTIONIST") || User.IsInRole("ADMIN")))
                {
                    

#line default
#line hidden
            BeginContext(1571, 60, false);
#line 48 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
               Write(Html.ActionLink("Edit", "Edit", new { id = item.PaymentID }));

#line default
#line hidden
            EndContext();
#line 48 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
                                                                                 
            }

#line default
#line hidden
            BeginContext(1646, 23, true);
            WriteLiteral("|\r\n                    ");
            EndContext();
            BeginContext(1670, 66, false);
#line 50 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
               Write(Html.ActionLink("Details", "Details", new { id = item.PaymentID }));

#line default
#line hidden
            EndContext();
            BeginContext(1736, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(1852, 42, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n");
            EndContext();
#line 55 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Payments/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(1901, 38, true);
            WriteLiteral("\r\n        </table>\r\n    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelReservation.ViewModels.PaymentViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591