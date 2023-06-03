#pragma checksum "D:\ProyectoKardexFrontend\Backend\v04\SistemaKardexBackend\WebVentas\Views\Producto\Create.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "894c51441abeb70f6cff668c98f75fed3489fe80"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Producto_Create), @"mvc.1.0.view", @"/Views/Producto/Create.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"894c51441abeb70f6cff668c98f75fed3489fe80", @"/Views/Producto/Create.cshtml")]
    public class Views_Producto_Create : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<EntidadesVentas.Producto.DT_Producto>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\ProyectoKardexFrontend\Backend\v04\SistemaKardexBackend\WebVentas\Views\Producto\Create.cshtml"
  
    ViewData["Title"] = "Create";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>Create</h1>

<h4>DT_Producto</h4>
<hr />
<div class=""row"">
    <div class=""col-md-4"">
        <form asp-action=""Create"">
            <div asp-validation-summary=""ModelOnly"" class=""text-danger""></div>
            <div class=""form-group"">
                <label asp-for=""cProducto"" class=""control-label""></label>
                <input asp-for=""cProducto"" class=""form-control"" />
                <span asp-validation-for=""cProducto"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""cPrecioProd"" class=""control-label""></label>
                <input asp-for=""cPrecioProd"" class=""form-control"" />
                <span asp-validation-for=""cPrecioProd"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""nCantidadProd"" class=""control-label""></label>
                <input asp-for=""nCantidadProd"" class=""form-control"" />
                <span asp-validation-for=""nCantid");
            WriteLiteral(@"adProd"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""cDescripcion"" class=""control-label""></label>
                <input asp-for=""cDescripcion"" class=""form-control"" />
                <span asp-validation-for=""cDescripcion"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""idUsuReg"" class=""control-label""></label>
                <input asp-for=""idUsuReg"" class=""form-control"" />
                <span asp-validation-for=""idUsuReg"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""dFechaReg"" class=""control-label""></label>
                <input asp-for=""dFechaReg"" class=""form-control"" />
                <span asp-validation-for=""dFechaReg"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""idUsuMod"" class=""control-label""></label>
");
            WriteLiteral(@"                <input asp-for=""idUsuMod"" class=""form-control"" />
                <span asp-validation-for=""idUsuMod"" class=""text-danger""></span>
            </div>
            <div class=""form-group"">
                <label asp-for=""dFechaMod"" class=""control-label""></label>
                <input asp-for=""dFechaMod"" class=""form-control"" />
                <span asp-validation-for=""dFechaMod"" class=""text-danger""></span>
            </div>
            <div class=""form-group form-check"">
                <label class=""form-check-label"">
                    <input class=""form-check-input"" asp-for=""lVigente"" /> ");
#nullable restore
#line 57 "D:\ProyectoKardexFrontend\Backend\v04\SistemaKardexBackend\WebVentas\Views\Producto\Create.cshtml"
                                                                     Write(Html.DisplayNameFor(model => model.lVigente));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                </label>
            </div>
            <div class=""form-group"">
                <input type=""submit"" value=""Create"" class=""btn btn-primary"" />
            </div>
        </form>
    </div>
</div>

<div>
    <a asp-action=""Index"">Back to List</a>
</div>

");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
#nullable restore
#line 72 "D:\ProyectoKardexFrontend\Backend\v04\SistemaKardexBackend\WebVentas\Views\Producto\Create.cshtml"
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<EntidadesVentas.Producto.DT_Producto> Html { get; private set; }
    }
}
#pragma warning restore 1591
