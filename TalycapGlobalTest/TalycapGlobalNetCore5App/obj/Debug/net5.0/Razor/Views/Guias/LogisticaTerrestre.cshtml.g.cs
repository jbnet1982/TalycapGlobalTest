#pragma checksum "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0fe461fcccc9f1e3c7df52f4c8e910eb710e95bc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Guias_LogisticaTerrestre), @"mvc.1.0.view", @"/Views/Guias/LogisticaTerrestre.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0fe461fcccc9f1e3c7df52f4c8e910eb710e95bc", @"/Views/Guias/LogisticaTerrestre.cshtml")]
    public class Views_Guias_LogisticaTerrestre : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<TalycapGlobalNetCore5App.Models.Guia>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
  
    ViewData["Title"] = "LogisticaTerrestre";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>LogisticaTerrestre</h1>\r\n\r\n<p>\r\n    <a asp-action=\"Create\">Create New</a>\r\n</p>\r\n<table class=\"table\">\r\n    <thead>\r\n        <tr>\r\n            <th>\r\n                ");
#nullable restore
#line 17 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.NumGuia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 20 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.cliente));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 23 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.pruducto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 26 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 29 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.PrecioUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 32 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalNeto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 35 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.PorcDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 38 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.ValorDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 41 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.TotalEnvio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 44 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.almacen));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 47 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.vehiculo));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 50 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.operador));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 53 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 56 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.FechaEntrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 59 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.estado));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th>\r\n                ");
#nullable restore
#line 62 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayNameFor(model => model.tipoEnvio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </th>\r\n            <th></th>\r\n        </tr>\r\n    </thead>\r\n    <tbody>\r\n");
#nullable restore
#line 68 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
 foreach (var item in Model) {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
#nullable restore
#line 71 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.NumGuia));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 74 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.cliente.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 77 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.pruducto.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 80 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.Cantidad));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 83 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.PrecioUnit));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 86 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalNeto));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 89 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.PorcDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 92 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.ValorDesc));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 95 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.TotalEnvio));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 98 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.almacen.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 101 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.vehiculo.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 104 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.operador.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 107 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaRegistro));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 110 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.FechaEntrega));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 113 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.estado.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                ");
#nullable restore
#line 116 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
           Write(Html.DisplayFor(modelItem => item.tipoEnvio.Id));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </td>\r\n            <td>\r\n                <a asp-action=\"Edit\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3690, "\"", 3713, 1);
#nullable restore
#line 119 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
WriteAttributeValue("", 3705, item.Id, 3705, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a> |\r\n                <a asp-action=\"Details\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3766, "\"", 3789, 1);
#nullable restore
#line 120 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
WriteAttributeValue("", 3781, item.Id, 3781, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Details</a> |\r\n                <a asp-action=\"Delete\"");
            BeginWriteAttribute("asp-route-id", " asp-route-id=\"", 3844, "\"", 3867, 1);
#nullable restore
#line 121 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
WriteAttributeValue("", 3859, item.Id, 3859, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n            </td>\r\n        </tr>\r\n");
#nullable restore
#line 124 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Guias\LogisticaTerrestre.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral("    </tbody>\r\n</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<TalycapGlobalNetCore5App.Models.Guia>> Html { get; private set; }
    }
}
#pragma warning restore 1591
