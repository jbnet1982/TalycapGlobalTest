#pragma checksum "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Productoes\Edit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbd98ab1c4e51e232fbf5c011afa071a251ab45c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Productoes_Edit), @"mvc.1.0.view", @"/Views/Productoes/Edit.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbd98ab1c4e51e232fbf5c011afa071a251ab45c", @"/Views/Productoes/Edit.cshtml")]
    public class Views_Productoes_Edit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TalycapGlobalNetCore5App.Models.Producto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Productoes\Edit.cshtml"
  
    ViewData["Title"] = "Edit";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Edit</h1>

<h4>Producto</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Edit"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <input type=""hidden"" asp-for=""Id"" />
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
                <span asp-validati");
            WriteLiteral(@"on-for=""Descripcion"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""AlmacenId"" class=""control-label""></label>
                <select asp-for=""AlmacenId"" class=""form-control"" asp-items=""ViewBag.AlmacenId""></select>
                <span asp-validation-for=""AlmacenId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TipoProductoId"" class=""control-label""></label>
                <select asp-for=""TipoProductoId"" class=""form-control"" asp-items=""ViewBag.TipoProductoId""></select>
                <span asp-validation-for=""TipoProductoId"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""precio"" class=""control-label""></label>
                <input asp-for=""precio"" class=""form-control"" />
                <span asp-validation-for=""precio"" class=""text-danger""></span>
            </div>
            <div c");
            WriteLiteral("lass=\"form-group\">\r\n                <input type=\"submit\" value=\"Save\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 59 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Productoes\Edit.cshtml"
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
