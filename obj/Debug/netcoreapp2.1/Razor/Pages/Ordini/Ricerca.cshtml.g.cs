#pragma checksum "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1df07d305e4f5350c7492f1bba3c78307387efbe"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Pages_Ordini_Ricerca), @"mvc.1.0.razor-page", @"/Pages/Ordini/Ricerca.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Ordini/Ricerca.cshtml", typeof(AspNetCore.Pages_Ordini_Ricerca), null)]
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
#line 1 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\_ViewImports.cshtml"
using Ecommerce;

#line default
#line hidden
#line 2 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\_ViewImports.cshtml"
using Ecommerce.Models;

#line default
#line hidden
#line 3 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
using Ecommerce.Pages.Ordini;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1df07d305e4f5350c7492f1bba3c78307387efbe", @"/Pages/Ordini/Ricerca.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6bbcd7c65731fc074a835809e73fcf2cf9014c29", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Ordini_Ricerca : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "OrdiniByFilter", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("submit"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-secondary btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(7, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 5 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
  
    ViewData["Title"] = "Ricerca";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
            BeginContext(151, 131, true);
            WriteLiteral("\r\n\r\n<!-- Breadcrumbs-->\r\n<ol class=\"breadcrumb\">\r\n    <li class=\"breadcrumb-item\">\r\n        Filter le ordine:\r\n    </li>\r\n</ol>\r\n\r\n");
            EndContext();
#line 18 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
 using (Html.BeginForm())
{

#line default
#line hidden
            BeginContext(312, 210, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"form-group col-md-12\">\r\n            <div class=\"form-label-group form-inline col-md-12\">\r\n                <div class=\"col-md-3 form-label-group\">\r\n                    ");
            EndContext();
            BeginContext(523, 162, false);
#line 24 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
               Write(Html.TextBoxFor(x => Model.FilterData, "{0:yyyy-MM-dd}", htmlAttributes: new { type = "date", @class = "form-control", @onchange = "CallChangefunc(this.value)" }));

#line default
#line hidden
            EndContext();
            BeginContext(685, 103, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-3 form-label-group\">\r\n                    ");
            EndContext();
            BeginContext(789, 191, false);
#line 27 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
               Write(Html.DropDownListFor(x => Model.IDProd, new SelectList(Model.GetProdotto(), "Value", "Text"), "- Select Prodotto -", new { @class = "form-control", @onchange = "CallChangefunc(this.value)" }));

#line default
#line hidden
            EndContext();
            BeginContext(980, 103, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-3 form-label-group\">\r\n                    ");
            EndContext();
            BeginContext(1084, 183, false);
#line 30 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
               Write(Html.DropDownListFor(x => Model.IDCita, new SelectList(Model.GetCita(), "Value", "Text"), "- Select Cita -", new { @class = "form-control", @onchange = "CallChangefunc(this.value)" }));

#line default
#line hidden
            EndContext();
            BeginContext(1267, 86, true);
            WriteLiteral("\r\n                </div>\r\n                <div class=\"col-md-2\">\r\n                    ");
            EndContext();
            BeginContext(1353, 109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("button", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c4508bb061a1417c946ebdbde5d510f0", async() => {
                BeginContext(1447, 6, true);
                WriteLiteral("Filter");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormActionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormActionTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1462, 74, true);
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 38 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
}

#line default
#line hidden
            BeginContext(1539, 1171, true);
            WriteLiteral(@"
<!-- DataTables Example -->
<div class=""card mb-3"">
    <div class=""card-header"">
        <i class=""fas fa-table""></i>
        La lista delle Ordine
    </div>
    <div class=""card-body"">
        <div class=""table-responsive"">
            <table class=""table table-bordered"" id=""dataTable"" cellspacing=""0"">
                <thead>
                    <tr>
                        <th>Prodotto Descrizione</th>
                        <th>Nome Cliente</th>
                        <th>Quantita</th>
                        <th>Prezzo</th>
                        <th>SommaTotale</th>
                        <th>Cita</th>
                        <th>Date</th>
                    </tr>
                </thead>
                <tfoot>
                    <tr>
                        <th>Prodotto Descrizione</th>
                        <th>Nome Cliente</th>
                        <th>Quantita</th>
                        <th>Prezzo</th>
                        <th>SommaTotale</th>
         ");
            WriteLiteral("               <th>Cita</th>\r\n                        <th>Date</th>\r\n                    </tr>\r\n                </tfoot>\r\n                <tbody>\r\n");
            EndContext();
#line 72 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                     if (@Model.ordini == null)
                    {

#line default
#line hidden
            BeginContext(2782, 49, true);
            WriteLiteral("                        <tr>no items found</tr>\r\n");
            EndContext();
#line 75 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                    }
                    else
                    {
                        

#line default
#line hidden
#line 78 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                         foreach (var item in @Model.ordini)
                        {

#line default
#line hidden
            BeginContext(2992, 108, true);
            WriteLiteral("                            <tr>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3101, 55, false);
#line 82 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Prodotto.Descrizione));

#line default
#line hidden
            EndContext();
            BeginContext(3156, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3272, 47, false);
#line 85 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Cliente.Nome));

#line default
#line hidden
            EndContext();
            BeginContext(3319, 2, true);
            WriteLiteral("  ");
            EndContext();
            BeginContext(3322, 50, false);
#line 85 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                                                                                 Write(Html.DisplayFor(modelItem => item.Cliente.Cognome));

#line default
#line hidden
            EndContext();
            BeginContext(3372, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3488, 43, false);
#line 88 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Quantita));

#line default
#line hidden
            EndContext();
            BeginContext(3531, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3647, 50, false);
#line 91 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Prodotto.Prezzo));

#line default
#line hidden
            EndContext();
            BeginContext(3697, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3813, 46, false);
#line 94 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                               Write(Html.DisplayFor(modelItem => item.SommaTotale));

#line default
#line hidden
            EndContext();
            BeginContext(3859, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(3975, 39, false);
#line 97 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Cita));

#line default
#line hidden
            EndContext();
            BeginContext(4014, 115, true);
            WriteLiteral("\r\n                                </td>\r\n                                <td>\r\n                                    ");
            EndContext();
            BeginContext(4130, 39, false);
#line 100 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                               Write(Html.DisplayFor(modelItem => item.Date));

#line default
#line hidden
            EndContext();
            BeginContext(4169, 76, true);
            WriteLiteral("\r\n                                </td>\r\n                            </tr>\r\n");
            EndContext();
#line 103 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                        }

#line default
#line hidden
#line 103 "C:\Users\Ilir Gashi\Downloads\eComerce\Ecommerce\Pages\Ordini\Ricerca.cshtml"
                         
                    }

#line default
#line hidden
            BeginContext(4295, 88, true);
            WriteLiteral("\r\n                </tbody>\r\n            </table>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RicercaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RicercaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<RicercaModel>)PageContext?.ViewData;
        public RicercaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
