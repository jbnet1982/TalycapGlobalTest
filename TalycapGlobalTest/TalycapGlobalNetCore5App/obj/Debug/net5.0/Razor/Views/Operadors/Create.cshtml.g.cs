#pragma checksum "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Operadors\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4cc473e670b982ea03029d382a2f4da0db68096a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Operadors_Create), @"mvc.1.0.view", @"/Views/Operadors/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4cc473e670b982ea03029d382a2f4da0db68096a", @"/Views/Operadors/Create.cshtml")]
    public class Views_Operadors_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TalycapGlobalNetCore5App.Models.Operador>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Operadors\Create.cshtml"
  
    ViewData["Title"] = "Create";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>Operador</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""Nombres"" class=""control-label""></label>
                <input asp-for=""Nombres"" class=""form-control"" />
                <span asp-validation-for=""Nombres"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""NumDoc"" class=""control-label""></label>
                <input asp-for=""NumDoc"" class=""form-control"" />
                <span asp-validation-for=""NumDoc"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""TipoDocId"" class=""control-label""></label>
                <select asp-for=""TipoDocId"" class =""form-control"" asp-items=""ViewBag.TipoDocId""></select>
            </div>
            <div class");
            WriteLiteral("=\"form-group\">\r\n                <input type=\"submit\" value=\"Create\" class=\"btn btn-primary\" />\r\n            </div>\r\n        </form>\r\n    </div>\r\n</div>\r\n\r\n<div>\r\n    <a asp-action=\"Index\">Back to List</a>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 42 "C:\Users\bulan\Desktop\TalycapGlobal Test\TalycapGlobalTest\TalycapGlobalNetCore5App\Views\Operadors\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TalycapGlobalNetCore5App.Models.Operador> Html { get; private set; }
    }
}
#pragma warning restore 1591
