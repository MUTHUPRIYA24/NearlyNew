#pragma checksum "C:\Users\manmeet\Desktop\PROJECT\TermProject_NearlyNew\TermProject_NearlyNew\Views\Home\Tracking.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cca2c8c9df17b588cc50ab36225cc6e8efc55c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Tracking), @"mvc.1.0.view", @"/Views/Home/Tracking.cshtml")]
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
#nullable restore
#line 1 "C:\Users\manmeet\Desktop\PROJECT\TermProject_NearlyNew\TermProject_NearlyNew\Views\_ViewImports.cshtml"
using TermProject_NearlyNew.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cca2c8c9df17b588cc50ab36225cc6e8efc55c3", @"/Views/Home/Tracking.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4559fd688e723cc25dcdc9ec6e8cd9057927c496", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Tracking : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\manmeet\Desktop\PROJECT\TermProject_NearlyNew\TermProject_NearlyNew\Views\Home\Tracking.cshtml"
  
    ViewData["Title"] = "Tracking";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"   
<!--================Tracking Box Area =================-->

<section class=""tracking_box_area section_padding"">
    <div class=""container"">
        <div class=""row align-items-center justify-content-center"">
            <div class=""col-lg-12"">
                <div class=""tracking_box_inner"">
                    <p>
                        To track your order please enter your Order ID in the box below and press the ""Track"" button. This was
                        given
                        to you on your receipt and in the confirmation email you should have received.
                    </p>
                    
                        <div class=""col-md-12 form-group"">
                            <input type=""text"" class=""form-control"" id=""order"" name=""order"" placeholder=""Order ID"">
                        </div>

                        <div class=""col-md-12 form-group"">
                            <button onclick=""myFunction()"">Track Order</button>

                            <");
            WriteLiteral(@"p id=""demo""></p>

                            

                            <script>
                                function myFunction() {
                                    document.getElementById(""demo"").innerHTML = ""Your Order is under Process"";
                                }
                            </script>
                        </div>


                  
                </div>
            </div>

        </div>

    </div>
</section>
<!--================End Tracking Box Area =================-->
");
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
