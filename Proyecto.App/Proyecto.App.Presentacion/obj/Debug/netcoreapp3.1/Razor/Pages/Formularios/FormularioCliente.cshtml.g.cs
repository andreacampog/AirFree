#pragma checksum "C:\Proyecto\Proyecto.App\Proyecto.App.Presentacion\Pages\Formularios\FormularioCliente.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2695469e0f78d87432c4bc22ef30cb0000d36c13"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Proyecto.App.Presentacion.Pages.Formularios.Pages_Formularios_FormularioCliente), @"mvc.1.0.razor-page", @"/Pages/Formularios/FormularioCliente.cshtml")]
namespace Proyecto.App.Presentacion.Pages.Formularios
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2695469e0f78d87432c4bc22ef30cb0000d36c13", @"/Pages/Formularios/FormularioCliente.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"840f9654679f78cf6e4330965c638021945b85a4", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Formularios_FormularioCliente : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
            WriteLiteral("    <title>AirFree</title>\r\n    <!--<link rel=\"stylesheet\" href=\"EstiloFormulario.css\">-->\r\n    <h1");
            BeginWriteAttribute("class", " class =", 179, "", 187, 0);
            EndWriteAttribute();
            WriteLiteral(@" domiciliosairfree>Domicilios AirFree </h1>
    <table style= ""width: 40%;"">
            <tr>
                <td style=""background-color:dodgerblue;"">
                    <h3>Servicios Virtuales</h3>
                </td>
            </tr>

            <tr>
                <td class=""frame_form"">
                    <h3 class=""titulo"">Registro Cliente</h3>
                    <h4 class=""titulo"">Datos Personales </h4>
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2695469e0f78d87432c4bc22ef30cb0000d36c134277", async() => {
                WriteLiteral(@"
                        
                        <label class=""subtitulo"" for=""nombre"">Nombre</label> <br>
                        <input class =""textfield"" type=""text"" id=""nombre ""> <br> <br>        
                        <label class=""subtitulo"" for=""apellido"">Apellido</label> <br>
                        <input class =""textfield"" type=""text"" id=""apellido ""> <br> <br>  
                        <label class=""subtitulo"" for=""direccion"">Direccion</label> <br>
                        <input class =""textfield"" type=""text"" id=""direccion ""> <br> <br>  
                        <label class=""subtitulo"" for=""telefono"">Telefono</label> <br>
                        <input class =""textfield"" type=""text"" id=""telefono ""> <br> <br> 
                        <label class=""subtitulo"" for=""correo"">Correo</label> <br>                
                        <input class =""textfield"" type=""text"" id=""correo ""> <br> <br> 
                        <label class=""subtitulo"" for=""edad"">Edad</label> <br>
                ");
                WriteLiteral(@"        <input class =""textfield"" type=""text"" id=""edad ""> <br> <br> 
                                   <input class =""radios""  type=""radio"" name=""_selectgenero"" id=""generoFemenino"" value=""Femenino"">
                        <label class=""subtitulo"" for=""Femenino"">Femenino</label>
                        <input class =""radios"" type=""radio"" name=""_selectgenero"" id=""generoMasculino"" value=""Masculino"">
                        <label class=""subtitulo"" for=""Masculino"">Masculino</label> <br>
                        <p style=""font-style:oblique ;"">¿Deseas adquirir nuestra membresia? <br>
                            Podras disfrutar del 10% de descuento  <br>
                            en todas tus compras...                         </p> 
                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("   \r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2695469e0f78d87432c4bc22ef30cb0000d36c137451", async() => {
                WriteLiteral(@"
                            <input class=""radios"" type=""radio"" name=""_selectmembresia"" id=""membresia_si"" value=""si"">
                            <label for=""Si"">Si</label>
                            <input class=""radios"" type=""radio"" name=""_selectmembresia"" id=""membresia_no"" value=""no"">
                            <label for=""No"">No</label> <br> <br>
                    
                            <input class= ""boton"" type=""submit"" value= "" Registrar ""> <br> <br>      <br>              
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n    </table>\r\n");
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Proyecto.App.Presentacion.Pages.FormularioClienteModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto.App.Presentacion.Pages.FormularioClienteModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Proyecto.App.Presentacion.Pages.FormularioClienteModel>)PageContext?.ViewData;
        public Proyecto.App.Presentacion.Pages.FormularioClienteModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
