#pragma checksum "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ef976ec12a46b6572475cbe88a6a80b10da2ccec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Rooms_Create), @"mvc.1.0.view", @"/Views/Rooms/Create.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Rooms/Create.cshtml", typeof(AspNetCore.Views_Rooms_Create))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ef976ec12a46b6572475cbe88a6a80b10da2ccec", @"/Views/Rooms/Create.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9beaf7bdd7101040862628f00d9f5d37499cfe8c", @"/Views/_ViewImports.cshtml")]
    public class Views_Rooms_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HotelReservation.ViewModels.RoomViewModel>
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(49, 1, true);
            WriteLiteral("\n");
            EndContext();
#line 3 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
  
    ViewBag.Title = "Create";

#line default
#line hidden
            BeginContext(85, 117, true);
            WriteLiteral("\n<div class=\"card\" style=\"margin-top: 20px;\">\n    <div class=\"card-body\">\n        <h2 class=\"card-title\">Rooms</h2>\n\n");
            EndContext();
#line 11 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
         using (Html.BeginForm())
        {
            

#line default
#line hidden
            BeginContext(259, 23, false);
#line 13 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
       Write(Html.AntiForgeryToken());

#line default
#line hidden
            EndContext();
            BeginContext(284, 111, true);
            WriteLiteral("            <div class=\"form-horizontal\">\n                <h4>Room</h4>\n                <hr />\n                ");
            EndContext();
            BeginContext(396, 64, false);
#line 18 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
           Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(460, 63, true);
            WriteLiteral("\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(524, 99, false);
#line 21 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
               Write(Html.LabelFor(model => model.RoomNumber, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(623, 69, true);
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(693, 99, false);
#line 23 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
                   Write(Html.EditorFor(model => model.RoomNumber, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(792, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(818, 88, false);
#line 24 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.RoomNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(906, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(1020, 99, false);
#line 29 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
               Write(Html.LabelFor(model => model.RoomTypeID, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1119, 69, true);
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(1189, 166, false);
#line 31 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
                   Write(Html.DropDownListFor(model => model.RoomTypeID, new SelectList(Model.RoomTypes, "RoomTypeID", "TypeDescription"), "", htmlAttributes: new { @class = "form-control" }));

#line default
#line hidden
            EndContext();
            BeginContext(1355, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(1381, 88, false);
#line 32 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.RoomTypeID, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1469, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(1583, 94, false);
#line 37 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
               Write(Html.LabelFor(model => model.Price, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(1677, 69, true);
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(1747, 127, false);
#line 39 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
                   Write(Html.EditorFor(model => model.Price, new { htmlAttributes = new { @class = "form-control roomPrice", disabled = "disabled" } }));

#line default
#line hidden
            EndContext();
            BeginContext(1874, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(1900, 83, false);
#line 40 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Price, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(1983, 113, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n                <div class=\"form-group\">\n                    ");
            EndContext();
            BeginContext(2097, 94, false);
#line 45 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
               Write(Html.LabelFor(model => model.Floor, htmlAttributes: new { @class = "control-label col-md-2" }));

#line default
#line hidden
            EndContext();
            BeginContext(2191, 69, true);
            WriteLiteral("\n                    <div class=\"col-md-10\">\n                        ");
            EndContext();
            BeginContext(2261, 94, false);
#line 47 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
                   Write(Html.EditorFor(model => model.Floor, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
            EndContext();
            BeginContext(2355, 25, true);
            WriteLiteral("\n                        ");
            EndContext();
            BeginContext(2381, 83, false);
#line 48 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Floor, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(2464, 94, true);
            WriteLiteral("\n                    </div>\n                </div>\n\n\n                <div class=\"form-group\">\n");
            EndContext();
            BeginContext(2681, 120, true);
            WriteLiteral("                    <div class=\"col-md-10\">\n                        <div class=\"checkbox\">\r\n                            ");
            EndContext();
            BeginContext(2801, 197, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("label", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ef976ec12a46b6572475cbe88a6a80b10da2ccec11932", async() => {
                BeginContext(2827, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2861, 28, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef976ec12a46b6572475cbe88a6a80b10da2ccec12345", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
#line 58 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Reserved);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2889, 34, true);
                WriteLiteral("\r\n                                ");
                EndContext();
                BeginContext(2924, 36, false);
#line 59 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
                           Write(Html.DisplayNameFor(m => m.Reserved));

#line default
#line hidden
                EndContext();
                BeginContext(2960, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LabelTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper);
#line 57 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Reserved);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_LabelTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2998, 33, true);
            WriteLiteral("\r\n                        </div>\n");
            EndContext();
            BeginContext(3160, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3185, 86, false);
#line 63 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
                   Write(Html.ValidationMessageFor(model => model.Reserved, "", new { @class = "text-danger" }));

#line default
#line hidden
            EndContext();
            BeginContext(3271, 309, true);
            WriteLiteral(@"
                    </div>
                </div>

                <div class=""form-group"">
                    <div class=""col-md-offset-2 col-md-10"">
                        <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
                    </div>
                </div>
            </div>
");
            EndContext();
#line 73 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
        }

#line default
#line hidden
            BeginContext(3590, 27, true);
            WriteLiteral("\n        <div>\n            ");
            EndContext();
            BeginContext(3618, 40, false);
#line 76 "/Users/gbenro/Documents/development/hotelreservation_netcore/HotelReservation.Application/Views/Rooms/Create.cshtml"
       Write(Html.ActionLink("Back to List", "Index"));

#line default
#line hidden
            EndContext();
            BeginContext(3658, 35, true);
            WriteLiteral("\n        </div>\n    </div>\n</div>\n\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3711, 5, true);
                WriteLiteral("\n    ");
                EndContext();
                BeginContext(3716, 44, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "ef976ec12a46b6572475cbe88a6a80b10da2ccec17524", async() => {
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
                BeginContext(3760, 1018, true);
                WriteLiteral(@"

    <script type=""text/javascript"">
        $(function(){
            // select the element and wait for the onchange event
            $(""#RoomTypeID"").change(function() {

                var t = $(this).val();

                if (t !== """") {
                    // post the id (if given) to the specified route to return the price
                    var reqUrl = ""/api/Rooms/GetRoomPrice?roomTypeID="";

                    $.post(reqUrl + t, function (res) {
                        // return price value only when success is true
                        if (res.success === ""true"") {
                            $(""#Price"").val(res.data.price);
                        } else {
                            alert(""Error getting price of room!"");
                        }
                    });
                } else {
                    // if no id value passed keep the price text field empty
                    $(""input.roomPrice"").val('');
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HotelReservation.ViewModels.RoomViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591