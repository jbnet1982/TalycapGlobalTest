#pragma checksum "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Clientes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b3e8bdf34c26c5f1288a7ccf10723ec0ff5855d5"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Clientes_Create), @"mvc.1.0.view", @"/Views/Clientes/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b3e8bdf34c26c5f1288a7ccf10723ec0ff5855d5", @"/Views/Clientes/Create.cshtml")]
    public class Views_Clientes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TalycapGlobalNetCore5App.Models.Cliente>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Clientes\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Cliente</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nit"" class=""control-label""></label>
                <input asp-for=""Nit"" class=""form-control"" />
                <span asp-validation-for=""Nit"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Nombre"" class=""control-label""></label>
                <input asp-for=""Nombre"" class=""form-control"" />
                <span asp-validation-for=""Nombre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Direccion"" class=""control-label""></label>
                <input asp-for=""Direccion"" class=""form-control"" />
                <span asp-validation-for=""Direccion"" class=""text-danger""></span>
            ");
            WriteLiteral(@"</div>
            <div class=""form-group"">
                <label asp-for=""Telefono"" class=""control-label""></label>
                <input asp-for=""Telefono"" class=""form-control"" />
                <span asp-validation-for=""Telefono"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Indicativo"" class=""control-label""></label>
                <input asp-for=""Indicativo"" class=""form-control"" />
                <span asp-validation-for=""Indicativo"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""CiudadId"" class=""control-label""></label>
                <select asp-for=""CiudadId"" class =""form-control"" asp-items=""ViewBag.CiudadId""></select>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Bac");
            WriteLiteral("k to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 57 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Clientes\Create.cshtml"
      await Html.RenderPartialAsync("_ValidationScriptsPartial");

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TalycapGlobalNetCore5App.Models.Cliente> Html { get; private set; }
    }
}
#pragma warning restore 1591
