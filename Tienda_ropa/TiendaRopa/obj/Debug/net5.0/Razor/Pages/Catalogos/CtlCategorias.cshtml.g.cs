#pragma checksum "C:\Users\kenne\OneDrive\Escritorio\trabajos c#\GRUPO1-TiendaRopa\Tienda_ropa\TiendaRopa\Pages\Catalogos\CtlCategorias.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bdc6ece6e581e8821a765bc1b55c36dacd6d926f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(TiendaRopa.Pages.Catalogos.Pages_Catalogos_CtlCategorias), @"mvc.1.0.razor-page", @"/Pages/Catalogos/CtlCategorias.cshtml")]
namespace TiendaRopa.Pages.Catalogos
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
#line 1 "C:\Users\kenne\OneDrive\Escritorio\trabajos c#\GRUPO1-TiendaRopa\Tienda_ropa\TiendaRopa\Pages\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\kenne\OneDrive\Escritorio\trabajos c#\GRUPO1-TiendaRopa\Tienda_ropa\TiendaRopa\Pages\_ViewImports.cshtml"
using TiendaRopa;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\kenne\OneDrive\Escritorio\trabajos c#\GRUPO1-TiendaRopa\Tienda_ropa\TiendaRopa\Pages\_ViewImports.cshtml"
using TiendaRopa.Data;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bdc6ece6e581e8821a765bc1b55c36dacd6d926f", @"/Pages/Catalogos/CtlCategorias.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6c5a4b2cd05a715e003f5a4b54e977300f8ad042", @"/Pages/_ViewImports.cshtml")]
    #nullable restore
    public class Pages_Catalogos_CtlCategorias : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/Categoriast.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "0", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bdc6ece6e581e8821a765bc1b55c36dacd6d926f4981", async() => {
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
            WriteLiteral(@"
<script src=""https://kit.fontawesome.com/433c5e385c.js"" crossorigin=""anonymous""></script>

<div class=""Princ"">
<div class=""container-fluid"">
    <div class=""row mb-2"">
       
        <div class=""col-4"">
            <label for=""code"" class=""form-label"">Codigo</label>
            <input type=""text"" class=""form-control"" id=""txtcode"" placeholder=""Codigo"">
        </div>
        <div class=""col-6"">
            <label for=""name"" class=""form-label"">Nombre</label>
            <input type=""text"" class=""form-control"" id=""txtname"" placeholder=""Nombre"">
        </div>
        <div class=""col-2"">
            <label for=""ddstate"" class=""form-label"">Estado</label>
            <select class=""form-control form-select form-select-sm"" id=""ddstate"" aria-label=""select"">
                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc6ece6e581e8821a765bc1b55c36dacd6d926f6939", async() => {
                WriteLiteral("Activo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bdc6ece6e581e8821a765bc1b55c36dacd6d926f8425", async() => {
                WriteLiteral("Inactivo");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </select>
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <label for=""description"" class=""form-label"">Descripcion</label>
            <textarea class=""form-control"" id=""txtdescription"" rows=""3""></textarea>
        </div>
    </div>
    <div class=""row my-2"">
        <div class=""col d-flex justify-content-end"">
            <button  type=""button"" class=""btn btn-primary"" id=""BtnSave"" value=""Guardar""> 
<i class=""fa-solid fa-file-circle-plus""></i>
                </button>
        </div>
    </div>
</div>
<div class=""container-fluid mt-4"">
    <div class=""row"">
        <div class=""col"">
            <h4>Lista de Categorias</h4>
        </div>
    </div>
    <div class=""row"">
        <div class=""col"">
            <table id=""TableData"" class=""table"">
                <thead>

                </thead>
                <tbody>
                </tbody>
            </table>
        </div>
    </div>
</div>
</div>

<script type=""module""");
            WriteLiteral(@">
    import CreateTable from ""../js/TableComponent.js"";
    const LoadData = async () => {
        let url = ""../api/Value/GetCategories"";
        let response = await fetch(url);
        response = await response.json();
        CreateTable(response, TableData, FunctionEdit);
    }
    const FunctionEdit = async (Item) => {
        console.log(Item)
        txtcode.value = Item.id_categoria;
        txtname.value = Item.categoria;
        txtdescription.value = Item.descripcion;
        ddstate.value = Item.estado;

       
    }
    window.onload = () => {
        BtnSave.onclick = async () => {
            const ObjIns = {
                Id_categoria: (txtcode.value == """" ? -1 : txtcode.value),
                Categoria: txtname.value,
                Descripcion: txtdescription.value,
                Estado: parseInt(ddstate.value)
            }
            let url = ""../api/Value/SaveCategory"";
            let response = await fetch(url, {
                method: 'POST',
   ");
            WriteLiteral(@"             headers: {
                    'Content-type': 'application/json; charset-utf-8',
                    'Accept': '*/*'
                },
                body: JSON.stringify(ObjIns)
            });
            response = await response.json();
            if (response == true) {
                LoadData();
                txtcode.value = ""-1"";
                txtname.value = """";
                txtdescription.value = """";
                ddstate.value = 1;
            }
        }
        LoadData();
    }
</script>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TiendaRopa.Pages.Catalogos.CtlCategoriasModel> Html { get; private set; } = default!;
        #nullable disable
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TiendaRopa.Pages.Catalogos.CtlCategoriasModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<TiendaRopa.Pages.Catalogos.CtlCategoriasModel>)PageContext?.ViewData;
        public TiendaRopa.Pages.Catalogos.CtlCategoriasModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
