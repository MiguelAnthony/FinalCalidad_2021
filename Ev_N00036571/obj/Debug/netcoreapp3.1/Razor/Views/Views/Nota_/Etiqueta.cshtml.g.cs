#pragma checksum "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f7626f8410d6cde01be384a2126577f89d3a30df"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Views_Nota__Etiqueta), @"mvc.1.0.view", @"/Views/Views/Nota_/Etiqueta.cshtml")]
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
#nullable restore
#line 1 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\_ViewImports.cshtml"
using Ev_N00036571;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\_ViewImports.cshtml"
using Ev_N00036571.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f7626f8410d6cde01be384a2126577f89d3a30df", @"/Views/Views/Nota_/Etiqueta.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"79b35a7e206a9edd40b4779c0aa8b98729f9280d", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"500617df62cf067ac0e89735be5fe51e91f9ee5a", @"/Views/Views/_ViewImports.cshtml")]
    public class Views_Views_Nota__Etiqueta : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<div class=\"col-md-12\">\n    <a href=\"/Nota_\" style=\"margin-left:20px;\" class=\"btn btn-success float-lg-right\">Atras</a>\n    <br />\n    <br />\n</div>\n\n");
#nullable restore
#line 7 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
 foreach (var item in ViewBag.notas)
{


#line default
#line hidden
#nullable disable
            WriteLiteral("    <div class=\"container-fluid\">\n        <ul class=\"list-group\">\n            <li class=\"list-group-item\">\n                <a");
            BeginWriteAttribute("href", " href=\"", 315, "\"", 353, 2);
            WriteAttributeValue("", 322, "/Nota_/Detalle?Id=", 322, 18, true);
#nullable restore
#line 13 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
WriteAttributeValue("", 340, item.nota.Id, 340, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("><strong>");
#nullable restore
#line 13 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
                                                             Write(item.nota.Titulo);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong></a>\n                <br />\n                <span>\n                    <strong>Contenido: </strong>\n");
#nullable restore
#line 17 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
                     if (item.nota.Contenido.Length > 50)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <parcial>");
#nullable restore
#line 19 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
                            Write(item.nota.Contenido.Substring(0, 50));

#line default
#line hidden
#nullable disable
            WriteLiteral(" ...</parcial>\n");
#nullable restore
#line 20 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <parcial>");
#nullable restore
#line 23 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
                            Write(item.nota.Contenido);

#line default
#line hidden
#nullable disable
            WriteLiteral("</parcial>\n");
#nullable restore
#line 24 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </span>\n\n                <div align=\"right\">\n                    <a");
            BeginWriteAttribute("href", " href=\"", 892, "\"", 931, 2);
            WriteAttributeValue("", 899, "/Nota_/Eliminar?id=", 899, 19, true);
#nullable restore
#line 28 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
WriteAttributeValue("", 918, item.nota.Id, 918, 13, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" style=\"margin-left:20px;\" class=\"btn btn-outline-danger float-lg-right\">Eliminar</a>\n                    <button id=\"editModal\" style=\"margin-right:20px;\" class=\"btn btn-outline-primary float-lg-right\" href=\"#\" data-toggle=\"modal\" data-target=\"#edit\"");
            BeginWriteAttribute("onclick", " onclick=\"", 1183, "\"", 1260, 7);
            WriteAttributeValue("", 1193, "selCuenta(", 1193, 10, true);
#nullable restore
#line 29 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
WriteAttributeValue("", 1203, item.nota.Id, 1203, 13, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1216, ",\'", 1216, 2, true);
#nullable restore
#line 29 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
WriteAttributeValue("", 1218, item.nota.Titulo, 1218, 17, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1235, "\',\'", 1235, 3, true);
#nullable restore
#line 29 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
WriteAttributeValue("", 1238, item.nota.Contenido, 1238, 20, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1258, "\')", 1258, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Editar</button>\n                </div>\n            </li>\n        </ul>\n        <br />\n    </div>\n");
#nullable restore
#line 35 "C:\Users\Miguel Anthony\source\repos\Ev_N00036571\Ev_N00036571\Views\Views\Nota_\Etiqueta.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"


<div class=""modal fade"" id=""edit"" tabindex=""-1"" aria-labelledby=""edit"" aria-hidden=""true"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLabel"">Editar Nota</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"" id=""editNotita"">
            </div>
            <div class=""modal-footer"">
                <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Cancelar</button>
                <button type=""button"" class=""btn btn-primary"" onclick=""submitForm()"">Guardar</button>
            </div>
        </div>
    </div>
</div>


<script>
    function selCuenta(id, titulo, contenido) {
        $('#mtxtId').val(id);
        $('#mtxtTitulo').val(titulo);
        $('#mtxtContenido').val(contenido);
    };
");
            WriteLiteral(@"
    $.ajax({
        url: '/Nota_/Edit',
        type: 'get'
    }).done(function (html) {
        $('#editNotita').html(html);
    })

    function submitForm() {
        $('#editNota').submit();
    }

    function editar(event) {
        event.preventDefault();
        var dataString = new FormData($('#edit form')[0]);
        $.ajax({
            url: ""/Nota_/Edit"",
            type: ""post"",
            processData: false,  // Important!
            contentType: false,
            cache: false,
            data: dataString
        }).done(function (html) {
            location.reload();
        }).fail(function (html) {
            $('#editNotita').html(html.responseText);
        });
    }
</script>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
