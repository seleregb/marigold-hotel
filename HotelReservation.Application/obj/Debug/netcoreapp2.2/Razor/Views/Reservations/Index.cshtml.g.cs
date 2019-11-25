#pragma checksum "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9f1cc1f514081a3dcd454ac044754d8b64f7f4b3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_Index), @"mvc.1.0.view", @"/Views/Reservations/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservations/Index.cshtml", typeof(AspNetCore.Views_Reservations_Index))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9f1cc1f514081a3dcd454ac044754d8b64f7f4b3", @"/Views/Reservations/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beaf7bdd7101040862628f00d9f5d37499cfe8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<HotelReservation.ViewModels.ReservationViewModel>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(69, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
  
    ViewBag.Title = "Index";

#line default
#line hidden
            BeginContext(104, 127, true);
            WriteLiteral("\n<div class=\"card\" style=\"margin-top: 20px;\">\n    <div class=\"card-body\">\r\n        <h2 class=\"card-title\">Reservations</h2>\r\n\r\n");
            EndContext();
#line 11 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
         if ((User.IsInRole("admin") || User.IsInRole("receptionist")) && User.Identity.IsAuthenticated)
    {

#line default
#line hidden
            BeginContext(344, 25, true);
            WriteLiteral("        <p>\r\n            ");
            EndContext();
            BeginContext(370, 49, false);
#line 14 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
       Write(Html.ActionLink("Make New Reservation", "Create"));

#line default
#line hidden
            EndContext();
            BeginContext(419, 16, true);
            WriteLiteral("\r\n        </p>\r\n");
            EndContext();
#line 16 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
}
else
{

#line default
#line hidden
            BeginContext(445, 13, true);
            WriteLiteral("<p>\r\n        ");
            EndContext();
            BeginContext(459, 58, false);
#line 19 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
   Write(Html.ActionLink("Make New Reservation", "MakeReservation"));

#line default
#line hidden
            EndContext();
            BeginContext(517, 10, true);
            WriteLiteral("\r\n    </p>");
            EndContext();
#line 20 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
        }

#line default
#line hidden
            BeginContext(530, 91, true);
            WriteLiteral("        <table class=\"table\">\r\n            <tr>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(622, 48, false);
#line 24 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.RoomTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(670, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(738, 48, false);
#line 27 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(786, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(854, 49, false);
#line 30 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.DateOfBooking));

#line default
#line hidden
            EndContext();
            BeginContext(903, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(971, 47, false);
#line 33 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CheckInDate));

#line default
#line hidden
            EndContext();
            BeginContext(1018, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1086, 48, false);
#line 36 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.CheckOutDate));

#line default
#line hidden
            EndContext();
            BeginContext(1134, 67, true);
            WriteLiteral("\r\n                </th>\r\n                <th>\r\n                    ");
            EndContext();
            BeginContext(1202, 51, false);
#line 39 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayNameFor(model => model.TotalPaymentDue));

#line default
#line hidden
            EndContext();
            BeginContext(1253, 73, true);
            WriteLiteral("\r\n                </th>\r\n                <th></th>\r\n            </tr>\r\n\r\n");
            EndContext();
#line 44 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
             foreach (var item in Model)
        {

#line default
#line hidden
            BeginContext(1379, 60, true);
            WriteLiteral("            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1440, 47, false);
#line 48 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.RoomTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(1487, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1555, 47, false);
#line 51 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CustomerName));

#line default
#line hidden
            EndContext();
            BeginContext(1602, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1670, 48, false);
#line 54 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.DateOfBooking));

#line default
#line hidden
            EndContext();
            BeginContext(1718, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1786, 46, false);
#line 57 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CheckInDate));

#line default
#line hidden
            EndContext();
            BeginContext(1832, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(1900, 47, false);
#line 60 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.CheckOutDate));

#line default
#line hidden
            EndContext();
            BeginContext(1947, 67, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(2015, 50, false);
#line 63 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.DisplayFor(modelItem => item.TotalPaymentDue));

#line default
#line hidden
            EndContext();
            BeginContext(2065, 47, true);
            WriteLiteral("\r\n                </td>\r\n                <td>\r\n");
            EndContext();
#line 66 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
                     if ((User.IsInRole("receptionist") || User.IsInRole("admin")) && !item.RoomReserved)
                {
                    

#line default
#line hidden
            BeginContext(2259, 101, false);
#line 68 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.ActionLink("| Continue Payment", "Create", "Payments", new { reservationId = item.ResID }, null));

#line default
#line hidden
            EndContext();
#line 68 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
                                                                                                                          
            }

#line default
#line hidden
            BeginContext(2377, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 70 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
                     if ((User.IsInRole("receptionist") || User.IsInRole("admin")))
                {
                    

#line default
#line hidden
            BeginContext(2502, 58, false);
#line 72 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.ActionLink("| Edit", "Edit", new { id = item.ResID }));

#line default
#line hidden
            EndContext();
            BeginContext(2583, 64, false);
#line 73 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.ActionLink("| Details", "Details", new { id = item.ResID }));

#line default
#line hidden
            EndContext();
            BeginContext(2670, 62, false);
#line 74 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.ActionLink("| Delete", "Delete", new { id = item.ResID }));

#line default
#line hidden
            EndContext();
#line 74 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
                                                                                   
            }

#line default
#line hidden
            BeginContext(2749, 20, true);
            WriteLiteral("                    ");
            EndContext();
#line 76 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
                     if ((User.IsInRole("user") || User.IsInRole("guest")))
                {
                    

#line default
#line hidden
            BeginContext(2866, 63, false);
#line 78 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
               Write(Html.ActionLink("|Details", "Details", new { id = item.ResID }));

#line default
#line hidden
            EndContext();
#line 78 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
                                                                                    

            }

#line default
#line hidden
            BeginContext(2948, 44, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
            EndContext();
#line 84 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(2999, 38, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<HotelReservation.ViewModels.ReservationViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591