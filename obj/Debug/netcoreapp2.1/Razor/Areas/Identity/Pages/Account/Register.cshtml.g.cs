#pragma checksum "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "96b1856bc1aa68fea7f52b6e30dde64aae5283dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Identity_Pages_Account_Register), @"mvc.1.0.razor-page", @"/Areas/Identity/Pages/Account/Register.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Areas/Identity/Pages/Account/Register.cshtml", typeof(AspNetCore.Areas_Identity_Pages_Account_Register), null)]
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
#line 1 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#line 2 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"96b1856bc1aa68fea7f52b6e30dde64aae5283dc", @"/Areas/Identity/Pages/Account/Register.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Areas/Identity/Pages/Account/_ViewImports.cshtml")]
    public class Areas_Identity_Pages_Account_Register : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/fontawesome-free/css/all.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/sb-admin.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "_ValidationScriptsPartial", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "Identity", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/Login", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("d-block small"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Account/ForgotPassword", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_11 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_12 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery-easing/jquery.easing.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_13 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("bg-dark"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(68, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 4 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
  
    Layout = null;
    ViewData["Title"] = "Register";

#line default
#line hidden
            BeginContext(134, 37, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            EndContext();
            BeginContext(171, 576, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "731a6b5818ef41edb3762c4eb70cf468", async() => {
                BeginContext(177, 13, true);
                WriteLiteral("\r\n    <title>");
                EndContext();
                BeginContext(191, 17, false);
#line 12 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
      Write(ViewData["Title"]);

#line default
#line hidden
                EndContext();
                BeginContext(208, 227, true);
                WriteLiteral("</title>\r\n    <meta charset=\"utf-8\">\r\n    <meta http-equiv=\"X-UA-Compatible\" content=\"IE=edge\">\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1, shrink-to-fit=no\">\r\n\r\n    <!-- Bootstrap core CSS-->\r\n    ");
                EndContext();
                BeginContext(435, 68, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "6ef49e70eb494ae4b0b63f171191ce75", async() => {
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
                BeginContext(503, 50, true);
                WriteLiteral("\r\n    <!-- Custom fonts for this template-->\r\n    ");
                EndContext();
                BeginContext(553, 85, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "8a0ae3566c2445e5985d5368dfa03ee0", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(638, 51, true);
                WriteLiteral("\r\n    <!-- Custom styles for this template-->\r\n    ");
                EndContext();
                BeginContext(689, 49, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e96648d598ec4942ae9be9b24e1dfc15", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(738, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(747, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(749, 4518, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7e4f22a98d4744e3a64c2073cd9c8d53", async() => {
                BeginContext(771, 191, true);
                WriteLiteral("\r\n    <div class=\"container\">\r\n        <div class=\"card card-register mx-auto mt-5\">\r\n            <div class=\"card-header\">Register an Account</div>\r\n            <div class=\"card-body\">\r\n\r\n\r\n");
                EndContext();
#line 31 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                 using (Html.BeginForm())
                {
                    

#line default
#line hidden
                BeginContext(1045, 19, false);
#line 33 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
               Write(ViewData["Mesagge"]);

#line default
#line hidden
                EndContext();
                BeginContext(1066, 47, true);
                WriteLiteral("                    <div style=\"color: green;\">");
                EndContext();
                BeginContext(1114, 19, false);
#line 34 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                                          Write(Model.StatusSuccess);

#line default
#line hidden
                EndContext();
                BeginContext(1133, 8, true);
                WriteLiteral("</div>\r\n");
                EndContext();
                BeginContext(1162, 64, false);
#line 35 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
               Write(Html.ValidationSummary(true, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1230, 70, true);
                WriteLiteral("                    <div class=\"form-group\">\r\n                        ");
                EndContext();
                BeginContext(1301, 40, false);
#line 38 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                   Write(Html.LabelFor(model => model.Input.Name));

#line default
#line hidden
                EndContext();
                BeginContext(1341, 86, true);
                WriteLiteral("\r\n                        <div class=\"form-label-group\">\r\n                            ");
                EndContext();
                BeginContext(1428, 117, false);
#line 40 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                       Write(Html.EditorFor(model => model.Input.Name, new { htmlAttributes = new { @class = "form-control", autofocus = true } }));

#line default
#line hidden
                EndContext();
                BeginContext(1545, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(1576, 88, false);
#line 41 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Input.Name, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(1664, 132, true);
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
                EndContext();
                BeginContext(1797, 41, false);
#line 45 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                   Write(Html.LabelFor(model => model.Input.Email));

#line default
#line hidden
                EndContext();
                BeginContext(1838, 86, true);
                WriteLiteral("\r\n                        <div class=\"form-label-group\">\r\n                            ");
                EndContext();
                BeginContext(1925, 100, false);
#line 47 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                       Write(Html.EditorFor(model => model.Input.Email, new { htmlAttributes = new { @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2025, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(2056, 89, false);
#line 48 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Input.Email, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2145, 240, true);
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <div class=\"form-row\">\r\n                            <div class=\"col-md-6\">\r\n                                ");
                EndContext();
                BeginContext(2386, 44, false);
#line 54 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                           Write(Html.LabelFor(model => model.Input.Password));

#line default
#line hidden
                EndContext();
                BeginContext(2430, 102, true);
                WriteLiteral("\r\n                                <div class=\"form-label-group\">\r\n                                    ");
                EndContext();
                BeginContext(2533, 129, false);
#line 56 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                               Write(Html.EditorFor(model => model.Input.Password, new { htmlAttributes = new { placeholder = "Password", @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(2662, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(2701, 92, false);
#line 57 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Input.Password, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(2793, 162, true);
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                            <div class=\"col-md-6\">\r\n                                ");
                EndContext();
                BeginContext(2956, 51, false);
#line 61 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                           Write(Html.LabelFor(model => model.Input.ConfirmPassword));

#line default
#line hidden
                EndContext();
                BeginContext(3007, 102, true);
                WriteLiteral("\r\n                                <div class=\"form-label-group\">\r\n                                    ");
                EndContext();
                BeginContext(3110, 144, false);
#line 63 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                               Write(Html.EditorFor(model => model.Input.ConfirmPassword, new { htmlAttributes = new { placeholder = "Confirm Password", @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(3254, 38, true);
                WriteLiteral("\r\n                                    ");
                EndContext();
                BeginContext(3293, 99, false);
#line 64 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                               Write(Html.ValidationMessageFor(model => model.Input.ConfirmPassword, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3392, 208, true);
                WriteLiteral("\r\n                                </div>\r\n                            </div>\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        ");
                EndContext();
                BeginContext(3601, 47, false);
#line 70 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                   Write(Html.LabelFor(model => model.Input.PhoneNumber));

#line default
#line hidden
                EndContext();
                BeginContext(3648, 86, true);
                WriteLiteral("\r\n                        <div class=\"form-label-group\">\r\n                            ");
                EndContext();
                BeginContext(3735, 136, false);
#line 72 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                       Write(Html.EditorFor(model => model.Input.PhoneNumber, new { htmlAttributes = new { placeholder = "Phone Number", @class = "form-control" } }));

#line default
#line hidden
                EndContext();
                BeginContext(3871, 30, true);
                WriteLiteral("\r\n                            ");
                EndContext();
                BeginContext(3902, 95, false);
#line 73 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                       Write(Html.ValidationMessageFor(model => model.Input.PhoneNumber, "", new { @class = "text-danger" }));

#line default
#line hidden
                EndContext();
                BeginContext(3997, 235, true);
                WriteLiteral("\r\n                        </div>\r\n                    </div>\r\n                    <div class=\"form-group\">\r\n                        <button type=\"submit\" class=\"btn btn-primary btn-block\">Register</button>\r\n                    </div>\r\n");
                EndContext();
#line 79 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                }

#line default
#line hidden
                BeginContext(4251, 2, true);
                WriteLiteral("\r\n");
                EndContext();
                DefineSection("Scripts", async() => {
                    BeginContext(4287, 22, true);
                    WriteLiteral("\r\n                    ");
                    EndContext();
                    BeginContext(4309, 44, false);
                    __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "23dcc9cf56f248279696c326e6beaf80", async() => {
                    }
                    );
                    __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
                    __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
                    __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
                    __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                    await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                    if (!__tagHelperExecutionContext.Output.IsContentModified)
                    {
                        await __tagHelperExecutionContext.SetOutputContentAsync();
                    }
                    Write(__tagHelperExecutionContext.Output);
                    __tagHelperExecutionContext = __tagHelperScopeManager.End();
                    EndContext();
                    BeginContext(4353, 18, true);
                    WriteLiteral("\r\n                ");
                    EndContext();
                }
                );
                BeginContext(4374, 67, true);
                WriteLiteral("\r\n\r\n                <div class=\"text-center\">\r\n                    ");
                EndContext();
                BeginContext(4441, 80, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "710511a7fd4845aa98c55d953f05eafb", async() => {
                    BeginContext(4512, 5, true);
                    WriteLiteral("Login");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_7.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4521, 22, true);
                WriteLiteral("\r\n                    ");
                EndContext();
                BeginContext(4543, 100, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "54bbe09afa2e47dea860f53cf65c0083", async() => {
                    BeginContext(4623, 16, true);
                    WriteLiteral("Forgot password?");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_6.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_9.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_9);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4643, 29, true);
                WriteLiteral("\r\n\r\n                    <!-- ");
                EndContext();
                BeginContext(4673, 97, false);
#line 90 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
                    Write(Html.ActionLink("Login", "Login", new { htmlAttributes = new { @class = "d-block small mt-3" } }));

#line default
#line hidden
                EndContext();
                BeginContext(4770, 11, true);
                WriteLiteral("\r\n         ");
                EndContext();
                BeginContext(4782, 122, false);
#line 91 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Areas\Identity\Pages\Account\Register.cshtml"
    Write(Html.ActionLink("Forgot your password?", "ForgotPassword", new { htmlAttributes = new { @class = "d-block small mt-3" } }));

#line default
#line hidden
                EndContext();
                BeginContext(4904, 122, true);
                WriteLiteral("-->\r\n                </div>\r\n\r\n            </div>\r\n        </div>\r\n    </div>\r\n    <!-- Bootstrap core JavaScript-->\r\n    ");
                EndContext();
                BeginContext(5026, 50, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e65427d5607e44eca66e83b66a6dfc70", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5076, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(5082, 66, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7ab8a77cf59f41fca85987d85cd0662c", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_11);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5148, 42, true);
                WriteLiteral("\r\n    <!-- Core plugin JavaScript-->\r\n    ");
                EndContext();
                BeginContext(5190, 64, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9a9a53d917004ca283179526714c7355", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_12);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(5254, 6, true);
                WriteLiteral("\r\n\r\n\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_13);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5267, 9, true);
            WriteLiteral("\r\n</html>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Ecommerce.Areas.Identity.Pages.Account.RegisterModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecommerce.Areas.Identity.Pages.Account.RegisterModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Ecommerce.Areas.Identity.Pages.Account.RegisterModel>)PageContext?.ViewData;
        public Ecommerce.Areas.Identity.Pages.Account.RegisterModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591