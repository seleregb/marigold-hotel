#pragma checksum "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0144cc276db27fede81dbbd3f87b78272daad951"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_Delete), @"mvc.1.0.view", @"/Views/Rooms/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rooms/Delete.cshtml", typeof(AspNetCore.Views_Rooms_Delete))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0144cc276db27fede81dbbd3f87b78272daad951", @"/Views/Rooms/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beaf7bdd7101040862628f00d9f5d37499cfe8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Rooms_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelReservation.ViewModels.RoomViewModel>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml"
  
    ViewBag.Title = "Delete";

#line default
#line hidden
            BeginContext(85, 232, true);
            WriteLiteral("\n<div class=\"card\">\n    <div class=\"card-title\">Delete Room</div>\n    <div class=\"card-body\">\n        <h3>Are you sure you want to delete this?</h3>\n        <hr />\n        <dl class=\"dl-horizontal\">\n            <dt>\n                ");
            EndContext();
            BeginContext(318, 48, false);
#line 14 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.RoomTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(366, 53, true);
            WriteLiteral("\n            </dt>\n\n            <dd>\n                ");
            EndContext();
            BeginContext(420, 44, false);
#line 18 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml"
           Write(Html.DisplayFor(model => model.RoomTypeName));

#line default
#line hidden
            EndContext();
            BeginContext(464, 53, true);
            WriteLiteral("\n            </dd>\n\n            <dt>\n                ");
            EndContext();
            BeginContext(518, 41, false);
#line 22 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(559, 53, true);
            WriteLiteral("\n            </dt>\n\n            <dd>\n                ");
            EndContext();
            BeginContext(613, 37, false);
#line 26 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Price));

#line default
#line hidden
            EndContext();
            BeginContext(650, 53, true);
            WriteLiteral("\n            </dd>\n\n            <dt>\n                ");
            EndContext();
            BeginContext(704, 41, false);
#line 30 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml"
           Write(Html.DisplayNameFor(model => model.Floor));

#line default
#line hidden
            EndContext();
            BeginContext(745, 53, true);
            WriteLiteral("\n            </dt>\n\n            <dd>\n                ");
            EndContext();
            BeginContext(799, 37, false);
#line 34 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml"
           Write(Html.DisplayFor(model => model.Floor));

#line default
#line hidden
            EndContext();
            BeginContext(836, 35, true);
            WriteLiteral("\n            </dd>\n\n        </dl>\n\n");
            EndContext();
#line 39 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml"
         using (Html.BeginForm())
            {
            

#line default
#line hidden
            BeginContext(932, 23, false);
#line 41 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(957, 145, true);
            WriteLiteral("            <div class=\"form-actions no-color\">\n                <input type=\"submit\" value=\"Delete\" class=\"btn btn-primary\" /> |\n                ");
            EndContext();
            BeginContext(1103, 40, false);
#line 45 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml"
           Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(1143, 20, true);
            WriteLiteral("\n            </div>\n");
            EndContext();
#line 47 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Delete.cshtml"
        }

#line default
#line hidden
            BeginContext(1173, 18, true);
            WriteLiteral("    </div>\n</div>\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelReservation.ViewModels.RoomViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
