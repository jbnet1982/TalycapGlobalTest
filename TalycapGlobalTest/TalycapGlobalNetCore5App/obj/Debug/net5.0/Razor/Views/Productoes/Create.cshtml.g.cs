#pragma checksum "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Productoes\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5674d36c8d8afe2b49ca16030314eff39fa4336f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productoes_Create), @"mvc.1.0.view", @"/Views/Productoes/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5674d36c8d8afe2b49ca16030314eff39fa4336f", @"/Views/Productoes/Create.cshtml")]
    public class Views_Productoes_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TalycapGlobalNetCore5App.Models.Producto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Productoes\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Producto</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""CodRef"" class=""control-label""></label>
                <input asp-for=""CodRef"" class=""form-control"" />
                <span asp-validation-for=""CodRef"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Nombre"" class=""control-label""></label>
                <input asp-for=""Nombre"" class=""form-control"" />
                <span asp-validation-for=""Nombre"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""Descripcion"" class=""control-label""></label>
                <input asp-for=""Descripcion"" class=""form-control"" />
                <span asp-validation-for=""Descripcion"" class=""text-danger""></spa");
            WriteLiteral(@"n>
            </div>
            <div class=""form-group"">
                <label asp-for=""AlmacenId"" class=""control-label""></label>
                <select asp-for=""AlmacenId"" class =""form-control"" asp-items=""ViewBag.AlmacenId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""TipoProductoId"" class=""control-label""></label>
                <select asp-for=""TipoProductoId"" class =""form-control"" asp-items=""ViewBag.TipoProductoId""></select>
            </div>
            <div class=""form-group"">
                <label asp-for=""precio"" class=""control-label""></label>
                <input asp-for=""precio"" class=""form-control"" />
                <span asp-validation-for=""precio"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</d");
            WriteLiteral("iv>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 56 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Productoes\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TalycapGlobalNetCore5App.Models.Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591
