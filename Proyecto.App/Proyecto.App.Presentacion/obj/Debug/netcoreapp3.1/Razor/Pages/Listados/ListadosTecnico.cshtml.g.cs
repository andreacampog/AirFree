#pragma checksum "C:\Proyecto\Proyecto.App\Proyecto.App.Presentacion\Pages\Listados\ListadosTecnico.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b6168584a852da4d9869dd70dbce745d79be09dc"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Proyecto.App.Presentacion.Pages.Listados.Pages_Listados_ListadosTecnico), @"mvc.1.0.razor-page", @"/Pages/Listados/ListadosTecnico.cshtml")]
namespace Proyecto.App.Presentacion.Pages.Listados
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
#line 1 "C:\Proyecto\Proyecto.App\Proyecto.App.Presentacion\Pages\_ViewImports.cshtml"
using Proyecto.App.Presentacion;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b6168584a852da4d9869dd70dbce745d79be09dc", @"/Pages/Listados/ListadosTecnico.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"840f9654679f78cf6e4330965c638021945b85a4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Listados_ListadosTecnico : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <h1>Listado Técnicos</h1>\r\n      <table class = \"table\">\r\n\r\n");
#nullable restore
#line 7 "C:\Proyecto\Proyecto.App\Proyecto.App.Presentacion\Pages\Listados\ListadosTecnico.cshtml"
         foreach (var tecnico in Model.ListaTecnicos) 
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <tr>  \r\n                <td>\r\n                    ");
#nullable restore
#line 11 "C:\Proyecto\Proyecto.App\Proyecto.App.Presentacion\Pages\Listados\ListadosTecnico.cshtml"
               Write(tecnico);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n");
#nullable restore
#line 14 "C:\Proyecto\Proyecto.App\Proyecto.App.Presentacion\Pages\Listados\ListadosTecnico.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proyecto.App.Presentacion.Pages.ListadosTecnicoModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto.App.Presentacion.Pages.ListadosTecnicoModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto.App.Presentacion.Pages.ListadosTecnicoModel>)PageContext?.ViewData;
        public Proyecto.App.Presentacion.Pages.ListadosTecnicoModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
