#pragma checksum "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e5003ca1e0908efce357b2883c5fa01f9f0d05e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Reservations_MakeReservation), @"mvc.1.0.view", @"/Views/Reservations/MakeReservation.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Reservations/MakeReservation.cshtml", typeof(AspNetCore.Views_Reservations_MakeReservation))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e5003ca1e0908efce357b2883c5fa01f9f0d05e", @"/Views/Reservations/MakeReservation.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beaf7bdd7101040862628f00d9f5d37499cfe8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Reservations_MakeReservation : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelReservation.ViewModels.ReservationViewModel>
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
#line 3 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
  
    ViewBag.Title = "Make Reservation";

#line default
#line hidden
            BeginContext(102, 151, true);
            WriteLiteral("\n<div class=\"card\" style=\"margin-top: 20px;\">\n    <div class=\"card-body\">\n        <h2 class=\"card-title\">\n            Create Reservation\n        </h2>\n");
            EndContext();
#line 12 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(310, 23, false);
#line 14 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(334, 58, true);
            WriteLiteral("            <div class=\"form-horizontal\">\n                ");
            EndContext();
            BeginContext(393, 64, false);
#line 16 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(457, 17, true);
            WriteLiteral("\n                ");
            EndContext();
            BeginContext(475, 41, false);
#line 17 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
           Write(Html.HiddenFor(model => model.CustomerID));

#line default
#line hidden
            EndContext();
            BeginContext(516, 78, true);
            WriteLiteral("\n               \n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(595, 99, false);
#line 20 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
               Write(Html.LabelFor(model => model.RoomTypeID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(694, 69, true);
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(764, 182, false);
#line 22 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.DropDownListFor(model => model.RoomTypeID, new SelectList(Model.RoomTypes, "RoomTypeID", "TypeDescription"), "Select Room Type", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(946, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(972, 88, false);
#line 23 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.ValidationMessageFor(model => model.RoomTypeID, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(1174, 95, false);
#line 28 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
               Write(Html.LabelFor(model => model.RoomID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1269, 69, true);
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(1339, 160, false);
#line 30 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.DropDownListFor(model => model.RoomID, new SelectList(Model.Rooms, "RoomID", "RoomNumber"), "Select Room", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1499, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(1525, 84, false);
#line 31 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.ValidationMessageFor(model => model.RoomID, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1609, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(1723, 121, false);
#line 36 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
               Write(Html.LabelFor(model => model.NumberOfGuests, "NumberOfGuests", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1844, 69, true);
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(1914, 114, false);
#line 38 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.DropDownList("NumberOfGuests", null, "Choose No. of Guests", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(2028, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2054, 92, false);
#line 39 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.ValidationMessageFor(model => model.NumberOfGuests, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2146, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(2260, 119, false);
#line 44 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
               Write(Html.LabelFor(model => model.NumberOfRooms, "NumberOfRooms", htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2379, 69, true);
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(2449, 135, false);
#line 46 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.DropDownList("NumberOfRooms", null, "Choose No. of Rooms", htmlAttributes: new { @class = "form-control", disabled = "disabled" }));

#line default
#line hidden
            EndContext();
            BeginContext(2584, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2610, 91, false);
#line 47 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.ValidationMessageFor(model => model.NumberOfRooms, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2701, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(2815, 100, false);
#line 52 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
               Write(Html.LabelFor(model => model.CheckInDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2915, 69, true);
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(2985, 100, false);
#line 54 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.EditorFor(model => model.CheckInDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3085, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(3111, 89, false);
#line 55 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.ValidationMessageFor(model => model.CheckInDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3200, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(3314, 101, false);
#line 60 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
               Write(Html.LabelFor(model => model.CheckOutDate, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3415, 69, true);
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(3485, 101, false);
#line 62 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.EditorFor(model => model.CheckOutDate, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(3586, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(3612, 90, false);
#line 63 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.ValidationMessageFor(model => model.CheckOutDate, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3702, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(3816, 104, false);
#line 68 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
               Write(Html.LabelFor(model => model.TotalPaymentDue, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(3920, 69, true);
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(3990, 122, false);
#line 70 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.EditorFor(model => model.TotalPaymentDue, new { htmlAttributes = new { @class = "form-control", @readonly = true } }));

#line default
#line hidden
            EndContext();
            BeginContext(4112, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(4138, 93, false);
#line 71 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
                   Write(Html.ValidationMessageFor(model => model.TotalPaymentDue, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(4231, 376, true);
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <div class=""btn-group"">
                            <input type=""submit"" value=""Create"" class=""btn btn-primary"" style=""margin-right: 5px;"" />
                        </div>
                        <a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 4607, "\"", 4650, 1);
#line 80 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
WriteAttributeValue("", 4614, Url.Action("Index", "Reservations"), 4614, 36, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(4651, 158, true);
            WriteLiteral(" class=\"btn btn-danger\">\n                            Cancel\n                        </a>\n                    </div>\n                </div>\n            </div>\n");
            EndContext();
#line 86 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Reservations/MakeReservation.cshtml"
        }

#line default
#line hidden
            BeginContext(4819, 19, true);
            WriteLiteral("    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(4856, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(4861, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9e5003ca1e0908efce357b2883c5fa01f9f0d05e18653", async() => {
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
                BeginContext(4905, 2859, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(document).ready(function () {

            // select the element and wait for the onchange event
            $(""#RoomTypeID"").change(function () {

                var t = $(this).val();

                if (t !== """") {
                    // post the id (if given) to the specified route to return the price
                    var reqUrl = ""/api/Reservations/GetRoomsByRoomType?roomTypeID="";
                    $.get(reqUrl + t, function (res) {
                        // return price value only when success is true
                        if (res.success === ""true"") {
                            $(""#RoomID"").html("""");
                            $(""#RoomID"")
                                .append('<option>--- Select Room # ---</option>')
                            $.each(res.data, function (i, room) {
                                $(""#RoomID"")
                                    .append($('<option></option>')
                                        .val(room");
                WriteLiteral(@".RoomID).html(room.RoomNumber));
                            });
                            $(""#NumberOfRooms"").removeAttr(""disabled"");
                            // based on the assumption that these rooms are the same price
                            $(""#TotalPaymentDue"").val(res.data[0].Price);
                            console.log(res.data[0].Price);
                        } else {
                            alert(""Error getting list of rooms!"");
                        }
                    });
                } else {
                    // if no id value passed keep the price text field empty
                    $(""input.RoomID"").html("""");
                }

            });


            $(""#NumberOfRooms"").change(function () {
                var rCount = $(this).val();
                console.log(""count changed"", rCount);
                var rType = $(""#RoomTypeID"").val();
                console.log(rType);
                var reqUrl = ""/api/Reservations/CalculateRoomTypePrice?roomTypeId="";
 ");
                WriteLiteral(@"               if (rCount !== """") {
                    $.get(reqUrl + rType
                        + ""&roomCount="" + rCount, function (res) {
                            if (res.success === ""true"") {

                                $(""#TotalPaymentDue"").val(res.data);
                            } else {
                                alert(""Error calculating amount due!"");
                            }
                    });
                    //var currentPrice = $(""#TotalPaymentDue"").val();
                    //var totalPrice = currentPrice * rCount;
                    //console.log(totalPrice);
                    //$(""#TotalPaymentDue"").val(totalPrice);
                } else {
                    $(""#TotalPaymentDue"").val("""");
                }
            });
        });
    </script>
");
                EndContext();
            }
            );
            BeginContext(7766, 4, true);
            WriteLiteral("\n\n\n\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelReservation.ViewModels.ReservationViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
